﻿using Entities.ForLife;
using ForLife.CORE.DataAccess.EntityFramework;
using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.DAL
{
    public class DonorProfileSettingsDAL:EFRepositoryBase<DonorProfileSettings,ForLifeDbContext>, IDonorProfileSettingsDAL
    {
        public DonorProfileSettingsDAL(ForLifeDbContext db):base(db)
        {

        }
    }
}
