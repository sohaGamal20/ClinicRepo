using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class DiagnosisMainCategory :Entity
    {
        public string Code { get; set; }
        public string Category { get; set; }
        public ICollection<DiagnosisSubCategory> DiagnosisSubs { get; set; }
        public string CombinedField { get; set; }
    }
}
