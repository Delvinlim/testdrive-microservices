using DataModelLayer;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReservationBLL
    {
        List<ReservationsClass> Reservation_List = new List<ReservationsClass>();
        private readonly string baseUrl = APISettings.apiUrl;

        // Get All Reservation List
        public List<ReservationsClass> GetReservations()
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("/reservations", Method.GET);
                Reservation_List = client.Execute<List<ReservationsClass>>(request).Data;

                return Reservation_List;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateReservation(int Params)
        {
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("reservations/{id}", Method.PUT)
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
