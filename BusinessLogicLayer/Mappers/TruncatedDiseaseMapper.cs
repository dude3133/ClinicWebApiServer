using BusinessLogicLayer.Models;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Mappers
{
    public interface ITruncatedDiseaseMapper
    { 
        TruncatedDisease Map(Disease p);
    }

    public class TruncatedDiseaseMapper: ITruncatedDiseaseMapper
    {
        public TruncatedDisease Map(Disease p)
        {
            return new TruncatedDisease
            {
                Description = p.Description,
                Name = p.Name
            };
        }
    }
}
