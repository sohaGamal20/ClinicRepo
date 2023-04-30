using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class PhysicalHistory : Entity
    {
        public long PatientID { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI { get; set; }
        public double RBS { get; set; }

        public Patient Patient { get; set; }
    }
}
