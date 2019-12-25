using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class BloodGroup : IEntity
    {
        public BloodGroup()
        {
            Patients = new HashSet<Patient>();
            Donors = new HashSet<Donor>();

        }

        public int BloodGroupID { get; set; }
        public string BloodGroupName { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Donor> Donors { get; set; }

    }
}
