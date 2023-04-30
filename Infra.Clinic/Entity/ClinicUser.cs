using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinic.Entity
{
    public class ClinicUser:Entity
    {
        public string  UserName { get; set; }
        public string Password { get; set; }
        public string  DisplayName { get; set; }
    }
}
