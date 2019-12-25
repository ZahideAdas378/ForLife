using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class City : IEntity
    {
        public City()
        {
            Donors = new HashSet<Donor>();
            Patients = new HashSet<Patient>();
        }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Donor> Donors { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
