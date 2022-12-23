using CustomersApi.Data;
using CustomersApi.Interfaces;
using CustomersApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomersApi.Services
{
    public class CustomerService : ICustomer
    {
        private ApiDbContext dbContext;
        public CustomerService()
        {
            dbContext = new ApiDbContext();
        }
        public async Task AddCustomer(Customer customer)
        {
            var vehicleInDb = await dbContext.Vehicles.FirstOrDefaultAsync(v => v.Id == customer.VehicleId);
            if (vehicleInDb == null)
            {
                await dbContext.Vehicles.AddAsync(customer.Vehicle);
                await dbContext.SaveChangesAsync();
            }
            customer.Vehicle = null;
            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();

            // Add Code For RabbitMQ Messaging Publisher
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("reservations", durable: true, exclusive: false, autoDelete: false, arguments: null);
            //var objectString = JsonSerializer.Serialize(customer);
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(customer));

            channel.BasicPublish("", "reservations", null, body);
        }
    }
}
