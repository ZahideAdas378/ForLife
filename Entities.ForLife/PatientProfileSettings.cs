using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class PatientProfileSettings:IEntity
    {
        public int PatientID { get; set; }
        public bool isDisplayName { get; set; }
        public bool isDisplayLastName { get; set; }
        public bool isDisplayGender { get; set; }
        public bool isDisplayCity { get; set; }
        public bool isDisplayCountry { get; set; }
        public bool isDisplayGSM { get; set; }
        public bool isDisplayEmail { get; set; }
        public bool isDisplayDonationType { get; set; }
        public bool isDispayBloodGroup { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
