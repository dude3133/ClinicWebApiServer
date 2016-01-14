using BusinessLogicLayer.Mappers;
using BusinessLogicLayer.Models;
using DataAccesLayer;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Services
{
    public interface IPatientService
    {
        IEnumerable<TruncatedPatient> GetAllPatients();
    }

    public class PatientService : IPatientService
    {
        public PatientService(ITruncatedPatientMapper _truncatedPatientMapper)
        {
            truncatedPatientMapper = _truncatedPatientMapper;
        }

        private ITruncatedPatientMapper truncatedPatientMapper;

        public IEnumerable<TruncatedPatient> GetAllPatients()
        {
            using (ClinicContext context = ClinicContextProvider.GetContext())
            {
                return context.Patients.ToList().Select(x => truncatedPatientMapper.Map(x));
            }
        }
    }
}
