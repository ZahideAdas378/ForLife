using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    public class DonationTypeMapping:EntityTypeConfiguration<DonationType>
    {
        public DonationTypeMapping()
        {
            HasKey(a => a.DonationTypeID);

            Property(a => a.DonationTypeName)
                .IsRequired()
                .HasMaxLength(30);

        }
    }
}
