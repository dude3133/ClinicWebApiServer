using BusinessLogicLayer.Models;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Mappers
{
    public interface ITruncatedDoctorMapper
    {
        TruncatedDoctor Map(Doctor p);
    }
    public class TruncatedDoctorMapper: ITruncatedDoctorMapper
    {
        public TruncatedDoctor Map(Doctor p)
        {
            return new TruncatedDoctor
            {
                FirstName = p.FirstName,
                LastName = p.LastName
            };
        }
    }
}
