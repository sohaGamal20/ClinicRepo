using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class Treatment : Entity
    {
        public long PatientID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
    }
}
