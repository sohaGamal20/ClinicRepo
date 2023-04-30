using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class DiagnosisSubCategory :Entity
    {
        public string Code { get; set; }
        public string Category { get; set; }

        public long DiagnosisMainCategoryId { get; set; }
        public DiagnosisMainCategory DiagnosisMainCategory { get; set; }
        public ICollection<DiagnosisLeafNodes> DiagnosisLeaf { get; set; }
        public string CombinedField { get; set; }
    }
}
