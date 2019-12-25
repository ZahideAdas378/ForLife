using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    class SettingMapping : EntityTypeConfiguration<Setting>
    {
        public SettingMapping()
        {
            HasKey(a => a.SettingID);
            Property(a => a.CircularLink)
                .IsRequired();
            Property(a => a.DecreeLink)
              .IsRequired();
            Property(a => a.LawLink)
              .IsRequired();
            Property(a => a.ReligionDecisionLink)
              .IsRequired();
            Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(50);
            Property(a => a.LegalWarning)
                .IsRequired()
              .HasMaxLength(300);
            Property(a => a.FirstAside)
               .HasMaxLength(300);
            Property(a => a.SecondAside)
                .HasMaxLength(300);
            Property(a => a.logo)
                .IsRequired()
                .HasColumnType("image");
            Property(a => a.About)
             .IsRequired()
             .HasMaxLength(1000); 
            
            Property(a => a.Mission)
              .IsRequired()
              .HasMaxLength(1000);

            Property(a => a.Vision)
              .IsRequired()
              .HasMaxLength(1000);


            Property(a => a.Phone)
                .IsRequired()
               .HasMaxLength(15);

            Property(a => a.Fax)
              .HasMaxLength(15);
            Property(a => a.Address)
               .HasMaxLength(15);

            Property(a => a.Facebook)
             .IsRequired();

            Property(a => a.Instagram)
             .IsRequired();

            Property(a => a.Youtube)
             .IsRequired();

            Property(a => a.HomeVideo)
             .IsRequired();

            Property(a => a.VideoDescription)
                .IsRequired()
               .HasMaxLength(300);
            Property(a => a.Email)
           .IsRequired();



        }
    }
}
