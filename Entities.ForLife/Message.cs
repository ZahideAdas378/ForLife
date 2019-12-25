using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
  public  class Message : IEntity
    {
        public int MessageID { get; set; }
        public string MessageDetails { get; set; }
        public int DonorID { get; set; }
        public int PatientID { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsRead { get; set; }

        public virtual Donor Donor { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
