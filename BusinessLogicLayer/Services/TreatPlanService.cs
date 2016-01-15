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
    public interface ITreatPlanService
    {
        IEnumerable<TruncatedTreatPlan> GetPatientTreatPlans(int id);
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
                return context.TreatPlans.Where(x => x.Patient_Id == id).ToList().Select(x => truncatedTreatPlanMapper.Map(x));
            }
        }
    }
}
