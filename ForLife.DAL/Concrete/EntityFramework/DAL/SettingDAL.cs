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
   public class SettingDAL : EFRepositoryBase<Setting, ForLifeDbContext>, ISettingDAL
    {
        public SettingDAL(ForLifeDbContext db) : base(db)
        {

        }
    }
}
