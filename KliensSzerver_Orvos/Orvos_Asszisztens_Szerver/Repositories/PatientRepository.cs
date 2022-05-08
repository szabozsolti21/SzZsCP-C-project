using Common_Library.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Orvos_Asszisztens_Szerver.Repositories
{
    public static class PatientRepository
    {
        private const string FileName = "Patients.json";

        public static IEnumerable<Patient> GetPatients()
        {
            if(File.Exists(FileName))
            {
                var rawData = File.ReadAllText(FileName);
                var patients = JsonSerializer.Deserialize<IEnumerable<Patient>>(rawData);
                return patients;
            }

            return new List<Patient>();
        }

        public static void StorePatients(IEnumerable<Patient> patients)
        {
            var rawData = JsonSerializer.Serialize(patients);
            File.WriteAllText(FileName, rawData);
        }
    }
}
