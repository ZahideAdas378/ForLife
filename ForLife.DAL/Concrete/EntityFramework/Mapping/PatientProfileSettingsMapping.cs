using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    class PatientProfileSettingsMapping:EntityTypeConfiguration<PatientProfileSettings>
    {
        public PatientProfileSettingsMapping()
        {
            HasKey(a => a.PatientID);           
        }
    }
}
