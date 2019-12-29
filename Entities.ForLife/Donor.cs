﻿using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class Donor : BaseEntity
    {
        public Donor()
        {
            DonationTypes = new HashSet<DonationType>();
            Messages = new HashSet<Message>();
            PatientDonors = new HashSet<PatientDonor>();
        }
        public int DonorID { get; set; }
        

        
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<DonationType> DonationTypes { get; set; }
        public virtual SecurityQuestion SecurityQuestion { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<PatientDonor> PatientDonors { get; set; }
        public virtual DonorProfileSettings DonorProfileSettings { get; set; }
    }
}
