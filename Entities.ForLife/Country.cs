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
        }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<City>  Cities { get; set; }


    }
}
