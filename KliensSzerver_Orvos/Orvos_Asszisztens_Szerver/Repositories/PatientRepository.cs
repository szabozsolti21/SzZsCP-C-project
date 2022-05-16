using Common_Library.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Orvos_Asszisztens_Szerver.Repositories
{
    public static class PatientRepository
    {
        public static IList<Patient> GetPatient()
        {
            using (var database = new PatientContext())
            {
                var patient = database.Patient.ToList();
                return patient;
            }
        }

        public static Patient GetPatient(int id)
        {
            using (var database = new PatientContext())
            {
                var patient = database.Patient.Where(p => p.Id == id).FirstOrDefault();
                return patient;
            }
        }

        public static void AddPatient(Patient patient)
        {
            using (var database = new PatientContext())
            {
                database.Patient.Add(patient);
                database.SaveChanges();
            }
        }

        public static bool UpdatePatient(Patient patient, int id)
        {
            using (var database = new PatientContext())
            {
                var dbPatient = database.Patient.Where(p => p.Id == id).FirstOrDefault();

                if (dbPatient != null)
                {
                    database.Patient.Update(patient);
                    database.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static void DeletePatient(Patient patient)
        {
            using (var database = new PatientContext())
            {
                database.Patient.Remove(patient);
                database.SaveChanges();
            }
        }
    }
}
