using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class TreatmentLookup:Entity //category
    {
        public string category { get; set; }
        public ICollection<TreatmentProductionName> treatmentProductionName { get; set; }

    }
}
