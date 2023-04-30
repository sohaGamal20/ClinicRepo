using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.DTOs
{
    public class PatientDTO
    {
        public long Id{ get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? FamilyName { get; set; }

        public string? CompositeName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string? Mobile { get; set; }
        public bool Cash { get; set; }
        public bool Consultation { get; set; }

        public string? InsuranceNumber { get; set; }
        public int InsuranceCompanyID { get; set; }
        public string? FamilyHistory { get; set; }
        public string? PastHistory { get; set; }
        public DateTime BirthdDate { get; set; }

        public bool? isChecked { get; set; }
        public DateTime? visitDate { get; set; }
    }
}
