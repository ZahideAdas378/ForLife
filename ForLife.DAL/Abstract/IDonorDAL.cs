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
    public interface IDonorDAL : IEntityRepository<Donor>
    {
        int Count(Expression<Func<Donor, bool>> predicate);
    }
}
