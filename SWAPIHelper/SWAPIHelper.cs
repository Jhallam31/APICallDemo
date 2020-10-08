using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SWAPIDemo
{
    public class SWAPIHelper
    {
        private const string _baseURL = "https://swapi.dev/api/";
        private HttpClient httpClient = new HttpClient();

        public SWAPIHelper()
        {
            httpClient.BaseAddress = new Uri(_baseURL);
        }
         public async Task<VehicleModel> GetVehicleByIDAsync(int id)
        {
            HttpResponseMessage vehicleRequest = await httpClient.GetAsync("vehicles/" + id);
            if(vehicleRequest.IsSuccessStatusCode)
            {
                string responseBody = await vehicleRequest.Content.ReadAsStringAsync();
                VehicleModel requestedVehicle = JsonConvert.DeserializeObject<VehicleModel>(responseBody);
                return requestedVehicle;
            }
            return new VehicleModel();
        }

        public async Task<Person> GetPersonByIDAsync(int id)
        {
            HttpResponseMessage personRequest = await httpClient.GetAsync("people/" + id);
            if(personRequest.IsSuccessStatusCode)
            {
                string reponseBody = await personRequest.Content.ReadAsStringAsync();
                Person requestedPerson = JsonConvert.DeserializeObject<Person>(reponseBody);
                return requestedPerson;
            }
            return new Person();

        }

    }
}
