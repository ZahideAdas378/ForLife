﻿using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.BLL.Abstract
{
   public interface IDonorService:IBaseService<Donor>
    {
        List<Donor> FilterDonors(Country country, DonationType donationType, DateTime date);

    }
}
