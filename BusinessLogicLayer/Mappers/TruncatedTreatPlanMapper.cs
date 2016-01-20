using BusinessLogicLayer.Models;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Mappers
{
    public interface ITruncatedTreatPlanMapper
    {
        TruncatedTreatPlan Map(TreatPlan p);
    }

    public class TruncatedTreatPlanMapper : ITruncatedTreatPlanMapper
    {
        public TruncatedTreatPlanMapper(ITruncatedDiseaseMapper _truncatedDiseaseMapper,
            ITruncatedDoctorMapper _truncatedDoctorMapper,
            ITruncatedMedicationMapper _truncatedMedicationMapper,
            ITruncatedPatientMapper _truncatedPatientMapper)
        {
            truncatedDiseaseMapper = _truncatedDiseaseMapper;
            truncatedDoctorMapper = _truncatedDoctorMapper;
            truncatedMedicationMapper = _truncatedMedicationMapper;
            truncatedPatientMapper = _truncatedPatientMapper;
        }

        private ITruncatedDiseaseMapper truncatedDiseaseMapper;
        private ITruncatedDoctorMapper truncatedDoctorMapper;
        private ITruncatedMedicationMapper truncatedMedicationMapper;
        private ITruncatedPatientMapper truncatedPatientMapper;

        public TruncatedTreatPlan Map(TreatPlan p)
        {
            return new TruncatedTreatPlan
            {
                Id = p.Id,
                Begin = p.Begin,
                End = p.End,
                Disease = truncatedDiseaseMapper.Map(p.Disease),
                Doctor= truncatedDoctorMapper.Map(p.Doctor),
                Medication= truncatedMedicationMapper.Map(p.Medication),
                Patient = truncatedPatientMapper.Map(p.Patient)
            };
        }
    }
}
