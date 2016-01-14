using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccesLayer
{
    public static class ClinicContextProvider
    {
        public static ClinicContext GetContext()
        {
            return new ClinicContext();
        }
    }
}
