using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebApiServer.Controllers
{
    [RoutePrefix("api/TreatPlan")]
    public class TreatPlanController : ApiController
    {
        public TreatPlanController(ITreatPlanService _treatPlanService)
        {
            treatPlanService = _treatPlanService;
        }

        private ITreatPlanService treatPlanService;

        [Route("{id:int}")]
        public IEnumerable<TruncatedTreatPlan> Get(int id)
        {
            return treatPlanService.GetPatientTreatPlans(id);
        }

        [Route("info/{id:int}")]
        public TruncatedTreatPlan GetInfo(int id)
        {
            return treatPlanService.GetTreatPlan(id);
        }
    }
}
