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
    public class DonorMapping : EntityTypeConfiguration<Donor>
    {
        public DonorMapping()
        {
            HasKey(a => a.DonorID);
            Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(30);

            Property(a => a.IdentityNumber)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(11);

            Property(a => a.Gender)
                .IsRequired()
                .HasColumnType("bit");

            Property(a => a.Photo)
               .IsRequired()
               .HasColumnType("nvarchar");

            Property(a => a.Address)
               .IsRequired()
              .HasMaxLength(200);

            Property(a => a.Phone)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(15);

            Property(a => a.Email)
              .IsRequired()
              .HasMaxLength(50);

            Property(a => a.ContactChannel)
             .IsRequired()
             .HasMaxLength(70);
             

            Property(a => a.PersonelInformation)
              .IsRequired();

            Property(a => a.UserName)
             .IsRequired()
             .HasMaxLength(30);

            Property(a => a.Password)
             .IsRequired()
             .HasMaxLength(15);

            Property(a => a.IsActive)
              .HasColumnType("bit")
              .IsRequired();

            Map(a => a.MapInheritedProperties());
            

            Property(a => a.DonorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



            HasRequired(a => a.BloodGroup)
                .WithMany(a => a.Donors)
                .HasForeignKey(a=>a.BloodGroupID);

            HasRequired(a => a.City)
                .WithMany(a => a.Donors)
                .HasForeignKey(a=>a.CityID);

            

            HasRequired(a => a.SecurityQuestion)
               .WithMany(a => a.Donors)
               .HasForeignKey(a => a.SecurityQuestionID);



        }
    }
}
