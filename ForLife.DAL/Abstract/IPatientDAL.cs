using Entities.ForLife;
using ForLife.CORE.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Abstract
{
   public interface IPatientDAL : IEntityRepository<Patient>
    {
        int Count(Expression<Func<Patient, bool>> predicate);
    }
}
