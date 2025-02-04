﻿using Common_Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OrvosKliens.DataProviders
{
    internal class PatientDataProvider
    {
        private const string _url = "http://localhost:5000/api/patient";
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
                else
                {
                    MessageBox.Show($"Hiba történt! ({response.StatusCode.ToString()})");
                    return null;
                }
            }
        }

        public static void CreatePatient(Patient patient)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(patient);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_url, content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Hiba történt! ({response.StatusCode.ToString()})");
                }
            }
        }

        public static void UpdatePatient(Patient patient)
        {
            using (var client = new HttpClient())
            {
                var rawData = JsonConvert.SerializeObject(patient);
                var content = new StringContent(rawData, Encoding.UTF8, "application/json");

                var response = client.PutAsync($"{_url}/{patient.Id}", content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Hiba történt! ({response.StatusCode.ToString()})");
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
                    MessageBox.Show($"Hiba történt! ({response.StatusCode.ToString()})");
                }
            }
        }
    }
}
