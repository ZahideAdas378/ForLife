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
    class MessageMapping:EntityTypeConfiguration<Message>
    {
        public MessageMapping()
        {
            HasKey(a=>a.MessageID);
            Property(a => a.MessageDetails)
                .HasMaxLength(500);


            HasRequired(a => a.Donor)
                .WithMany(a => a.Messages)
                .HasForeignKey(a => a.DonorID);

            HasRequired(a => a.Patient)
               .WithMany(a => a.Messages)
               .HasForeignKey(a => a.PatientID);



            Property(a => a.MessageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
