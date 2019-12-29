using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.Mapping
{
    class DonorProfileSettingsMapping:EntityTypeConfiguration<DonorProfileSettings>
    {
        public DonorProfileSettingsMapping()
        {
            HasKey(a =>a.DonorID);           
        }
    }
}
