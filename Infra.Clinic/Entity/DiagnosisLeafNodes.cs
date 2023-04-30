using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class DiagnosisLeafNodes :Entity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public long DiagnosisSubCategoryId { get; set; }
        public DiagnosisSubCategory DiagnosisSubCategory { get; set; }
        public string CombinedField { get; set; }
    }
}
