using Common_Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsszisztensKliens.DataProviders
{
    internal class PatientDataProvider
    {
        private const string _url = "https://localhost:5000/api/patient";
        public static IEnumerable<Patient> GetPatients()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rawData = response.Content.ReadAsStringAsync().Result;
                    var patients = JsonConvert.DeserializeObject<IEnumerable<Patient>>(rawData);
                    return patients;
                }

                throw new InvalidOperationException(response.StatusCode.ToString());
            }
        }

        public static void CreatePatient(Patient Patient)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(Patient);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void UpdatePatient(Patient Patient)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(Patient);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }

        public static void DeletePatient(long id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync($"{_url}/{id}").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(response.StatusCode.ToString());
                }
            }
        }
    }
}
