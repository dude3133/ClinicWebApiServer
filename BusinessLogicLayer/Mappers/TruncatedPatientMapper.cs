using BusinessLogicLayer.Models;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Mappers
{
    public interface ITruncatedPatientMapper
    {
        TruncatedPatient Map(Patient p);
    }

    public class TruncatedPatientMapper : ITruncatedPatientMapper
    {
        public TruncatedPatient Map(Patient p)
        {
            return new TruncatedPatient
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Birthdate = p.Birthdate,
                Hometown = p.Hometown
            };
        }
    }
}
