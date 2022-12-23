using Microsoft.EntityFrameworkCore;
using ReservationsApi.Data;
using ReservationsApi.Interfaces;
using ReservationsApi.Models;
using System.Net;
using System.Net.Mail;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RabbitMQ.Client.Events;
using Newtonsoft.Json;

namespace ReservationsApi.Services
{
    public class ReservationService : IReservation
    {
        private ApiDbContext dbContext;
        public ReservationService()
        {
            dbContext = new ApiDbContext();
        }
        public async Task<List<Reservation>> GetReservations()
        {
            // Add Receiver Code for Azure Service Bus (If Possible)
            // If Azure Account Still unable to uses
            // Then Use RabbitMQ as our Messaging Services
            // Add Code For RabbitMQ Messaging Consumer
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("reservations", durable: true, exclusive: false, autoDelete: false, arguments: null);
            var consumer = new EventingBasicConsumer(channel);
            if (consumer == null)
            {
                return null;
            };
            Console.WriteLine(consumer);
            Console.WriteLine("starting to process...");
            consumer.Received += async (sender, e) =>
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Body);
                Console.WriteLine("consuming messages...");
                var body = e.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(message);
                Console.WriteLine("passed data string", message);
                var data = JsonConvert.DeserializeObject<Reservation>(message);
                //var data = JsonSerializer.Deserialize<Reservation>(body);
                Console.WriteLine(data);
                Console.WriteLine("passed data deserialize", data);
                if (data != null)
                {
                    await dbContext.Reservation.AddAsync(data);
                    Thread.Sleep(5000);
                    await dbContext.SaveChangesAsync();
                };
            };
            channel.BasicConsume("reservations", true, consumer);
            return await dbContext.Reservation.ToListAsync();
        }

        public async Task UpdateMailStatus(int id)
        {
            var reservationResult = await dbContext.Reservation.FindAsync(id);
            Console.WriteLine("result");
            Console.WriteLine(reservationResult);
            if (reservationResult != null && reservationResult.IsMailSent == false)
            {
                // Use SMTP Client to Email Customer
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("delvinlim0606@gmail.com", "your_app_password"),
                    EnableSsl = true,
                };
                if (reservationResult.Email != null)
                {
                    smtpClient.Send("akunbot022021@gmail.com",
                                    recipients: reservationResult.Email,
                                    subject: "TestDriveYuk - Confirmation",
                                    body: $"Hi {reservationResult.Name},\nYour Test Drive Reservation is Confirmed");
                    reservationResult.IsMailSent = true;
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
