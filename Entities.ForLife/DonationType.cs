using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class DonationType : IEntity
    {
        public DonationType()
        {
            Patients = new HashSet<Patient>();
            Donors = new HashSet<Donor>();
            PatientDonors = new HashSet<PatientDonor>();
        }
        public int DonationTypeID { get; set; }
        public string DonationTypeName { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Donor> Donors { get; set; }
        public virtual ICollection<PatientDonor> PatientDonors { get; set; }
    }
}
