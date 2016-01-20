using BusinessLogicLayer.Mappers;
using BusinessLogicLayer.Models;
using DataAccesLayer;
using DataAccesLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public interface ITreatPlanService
    {
        IEnumerable<TruncatedTreatPlan> GetPatientTreatPlans(int id);

        TruncatedTreatPlan GetTreatPlan(int id);
    }

    public class TreatPlanService : ITreatPlanService
    {
        public TreatPlanService(ITruncatedTreatPlanMapper _truncatedTreatPlanMapper)
        {
            truncatedTreatPlanMapper = _truncatedTreatPlanMapper;
        }

        private ITruncatedTreatPlanMapper truncatedTreatPlanMapper;

        public IEnumerable<TruncatedTreatPlan> GetPatientTreatPlans(int id)
        {
            using (ClinicContext context = ClinicContextProvider.GetContext())
            {
                var y = context.TreatPlans.Where(x => x.Patient_Id == id).Select(x => new { x, x.Disease, x.Doctor, x.Medication, x.Patient }).ToList();
                y.ForEach(x => { x.x.Disease = x.Disease; x.x.Doctor = x.Doctor; x.x.Medication = x.Medication; x.x.Patient = x.Patient; });
                var res = y.Select(t => truncatedTreatPlanMapper.Map(t.x));
                return res;
            }
        }


        public TruncatedTreatPlan GetTreatPlan(int id)
        {
            using (ClinicContext context = ClinicContextProvider.GetContext())
            {
                var y = context.TreatPlans.Where(x => x.Id == id).Select(x => new { x, x.Disease, x.Doctor, x.Medication, x.Patient }).SingleOrDefault();
                 y.x.Disease = y.Disease; y.x.Doctor = y.Doctor; y.x.Medication = y.Medication; y.x.Patient = y.Patient; 
                return truncatedTreatPlanMapper.Map(y.x);
            }
        }
    }
}
