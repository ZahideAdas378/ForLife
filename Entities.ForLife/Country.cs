using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class Country : IEntity
    {
        public Country()
        {
            Cities = new HashSet<City>();
            //Donors = new HashSet<Donor>();

        }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<City>  Cities { get; set; }
        //public virtual ICollection<Donor> Donors { get; set; }



    }
}
