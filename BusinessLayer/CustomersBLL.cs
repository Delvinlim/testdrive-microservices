using DataModelLayer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CustomersBLL
    {
        List<CustomersClass> Customers_List = new List<CustomersClass>();
        private readonly string baseUrl = APISettings.apiUrl;

        public void InsertCustomer(CustomersClass Customer)
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/customers", Method.POST);
                request.RequestFormat = DataFormat.Json;

                request.AddBody(Customer);
                var response = client.Execute(request);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
