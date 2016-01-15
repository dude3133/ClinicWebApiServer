using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace TestWebApiServer.Controllers
{
    public class PatientController : ApiController
    {
        public PatientController(IPatientService _patientService)
        {
            patientService = _patientService;
        }

        private IPatientService patientService;

        public IEnumerable<TruncatedPatient> Get()
        {
            return patientService.GetAllPatients();
        }

        public TruncatedPatient Get(int id)
        {
            return patientService.GetPatientById(id);
        } 
    }
}
