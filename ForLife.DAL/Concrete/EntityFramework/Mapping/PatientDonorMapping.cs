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
    class PatientDonorMapping:EntityTypeConfiguration<PatientDonor>
    {
        public PatientDonorMapping()
        {
            HasKey(a => a.PatientDonorID);

            HasRequired(a => a.Donor)
                 .WithMany(a => a.PatientDonors)
                 .HasForeignKey(a => a.DonorID);
         


            HasRequired(a => a.Patient)
                .WithMany(a => a.PatientDonors)
                .HasForeignKey(a => a.PatientID);
               


            HasRequired(a => a.DonationType)
                .WithMany(a => a.PatientDonors)
                .HasForeignKey(a => a.DonationID);
            

            Property(a => a.PatientDonorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
