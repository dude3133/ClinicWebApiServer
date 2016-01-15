using BusinessLogicLayer.Models;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Mappers
{
    public interface ITruncatedMedicationMapper
    {
        TruncatedMedication Map(Medication p);
    }
    public class TruncatedMedicationMapper : ITruncatedMedicationMapper
    {
        public TruncatedMedication Map(Medication p)
        {
            return new TruncatedMedication
            {
                Description = p.Description,
                Manufacturer = p.Manufacturer,
                Name = p.Name
            };
        }
    }
}
