using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    public class CityMapping:EntityTypeConfiguration<City>
    {
        public CityMapping()
        {
            HasKey(a => a.CityID);

            Property(a => a.CityName)
                .IsRequired()
                .HasMaxLength(30);


            HasRequired(a => a.Country)
                .WithMany(a => a.Cities)
                .HasForeignKey(a => a.CountryID);

        }
    }
}
