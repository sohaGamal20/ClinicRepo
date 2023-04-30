using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class Visit:Entity
    {
        public DateTime VisitDate { get; set; }
        /// <summary>
        /// 1=> consultation, 0=>Diagnosis
        /// </summary>
        public bool Consultation { get; set; }
        /// <summary>
        /// 1=cash, 0 means insurance
        /// </summary>
        public bool Cash { get; set; } 
        public string? InsuranceNumber { get; set; }
        public int InsuranceCompanyID { get; set; }

        public double fees { get; set; }
        public long PatientId { get; set; }
        public Patient Patient { get; set; }

        public bool isChecked { get; set; }
    }
}
