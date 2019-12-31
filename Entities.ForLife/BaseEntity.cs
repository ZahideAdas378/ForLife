using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class BaseEntity : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public bool Gender { get; set; }
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PersonelInformation { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CityID { get; set; }
        //public int CountryID { get; set; }
        public int SecurityQuestionID { get; set; }
        public string SecurityAnswer { get; set; }
        public int BloodGroupID { get; set; }
        public int DonationTypeID { get; set; }
        public DateTime? DonationDate { get; set; }
        public string ContactChannel { get; set; }

    }
}
