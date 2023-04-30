using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    //lookup table
    public class DiscountLookup : Entity
    {
        public string? Agency { get; set; }
        public double DiscountPercentage { get; set; } 


    }
}
