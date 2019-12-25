using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    public class BloodGroupMapping: EntityTypeConfiguration<BloodGroup>
    {
        public BloodGroupMapping()
        {
            HasKey(a => a.BloodGroupID);

            Property(a => a.BloodGroupName)
                .IsRequired()
                .HasMaxLength(10);

            Property(a => a.BloodGroupID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);        
        }
    }
}
