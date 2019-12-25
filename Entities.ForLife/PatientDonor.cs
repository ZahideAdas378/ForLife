using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
  public  class PatientDonor : IEntity
    {
        public int PatientDonorID { get; set; }
        public int DonorID { get; set; }
        public int PatientID { get; set; }
        public int DonationID { get; set; }


        public virtual Donor Donor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DonationType DonationType { get; set; }

    }
}
