using Common_Library.Models;
using Microsoft.AspNetCore.Mvc;
using Orvos_Asszisztens_Szerver.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Orvos_Asszisztens_Szerver.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController : Controller
    {

        [HttpGet]
        public ActionResult<IEnumerable<Patient>> Get()
        {
            var patients = PatientRepository.GetPatients();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public ActionResult<Patient> Get(long id)
        {
            var patient = PatientRepository.GetPatient(id);

            if (patient != null)
            {
                return Ok(patient);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public ActionResult Post([FromBody] Patient patient)
        {
            PatientRepository.AddPatient(patient);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Patient patient, long id)
        {

            var dbPatient = PatientRepository.GetPatient(id);

            if(dbPatient != null)
            {
                PatientRepository.UpdatePatient(patient);
                return Ok();
            }
            return NotFound();
            
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var patient = PatientRepository.GetPatient(id);

            if (patient != null)
            {
                PatientRepository.DeletePatient(patient);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}
