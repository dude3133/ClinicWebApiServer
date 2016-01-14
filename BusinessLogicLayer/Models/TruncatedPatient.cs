using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Models
{
    public class TruncatedPatient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
