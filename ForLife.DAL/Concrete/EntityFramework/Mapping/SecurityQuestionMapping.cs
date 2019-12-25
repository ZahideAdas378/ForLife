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
   public class SecurityQuestionMapping:EntityTypeConfiguration<SecurityQuestion>
    {
        public SecurityQuestionMapping()
        {
            HasKey(a => a.SecurityQuestionID);

            Property(a => a.Question)
                .IsRequired()
                .HasMaxLength(70);

            Property(a => a.SecurityQuestionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
