using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class SecurityQuestion : IEntity
    {
        public SecurityQuestion()
        {
            Donors = new HashSet<Donor>();
            Patients = new HashSet<Patient>();
        }

        public int SecurityQuestionID { get; set; }
        public string Question { get; set; }               
        public virtual ICollection<Donor> Donors { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
