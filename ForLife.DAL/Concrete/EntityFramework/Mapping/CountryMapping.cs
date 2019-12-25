using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    public class CountryMapping:EntityTypeConfiguration<Country>
    {
        public CountryMapping()
        {
            HasKey(a => a.CountryID);

            Property(a => a.CountryName)
                .IsRequired()
                .HasMaxLength(30);

        }
    }
}
