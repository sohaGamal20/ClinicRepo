using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class TreatmentProductionName :Entity
    {
        public string productName { get; set; }
        public string productImage { get; set; }
        public long TreatmentLookupId { get; set; }
        public TreatmentLookup TreatmentLookup { get; set; }
    }
}
