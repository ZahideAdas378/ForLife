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
    public class AdminMapping : EntityTypeConfiguration<Admin>
    {
        public AdminMapping()
        {
            Property(a => a.FirstName)
               .IsRequired()
               .HasMaxLength(30);

            Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(30);

            Property(a => a.UserName)
                .IsRequired()
                .HasMaxLength(30);

            Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(25);

            Property(a => a.Email)
               .IsRequired();             

            HasKey(a => a.AdminID);

            Property(a => a.AdminID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);




        }
    }
}
