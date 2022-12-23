using DataModelLayer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class VehiclesBLL
    {
        List<VehiclesClass> Vehicles_List = new List<VehiclesClass>();
        VehiclesClass Vehicle;
        private readonly string baseUrl = APISettings.apiUrl;

        // Get All Vehicles In Form Selection
        public List<VehiclesClass> GetVehicles()
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/vehicles", Method.GET);
                Vehicles_List = client.Execute<List<VehiclesClass>>(request).Data;
                if (Vehicles_List != null)
                    return Vehicles_List;
                else
                    throw new Exception("Vehicles not found");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Get A Single Vehicle When User Click One Of The List
        public VehiclesClass GetVehicle(string Params)
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/vehicles/{id}", Method.GET)
                    .AddUrlSegment("id", Params);

                Vehicle = client.Execute<VehiclesClass>(request).Data;

                return Vehicle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Insert Vehicle
        public void InsertVehicle(VehiclesClass Vehicle)
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/vehicles", Method.POST);
                request.RequestFormat = DataFormat.Json;

                request.AddBody(Vehicle);
                var response = client.Execute(request);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Delete Vehicle   
        public void DeleteVehicle(int Params)
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/vehicles/{id}", Method.DELETE)
                    .AddUrlSegment("id", Params);
                var response = client.Execute(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
