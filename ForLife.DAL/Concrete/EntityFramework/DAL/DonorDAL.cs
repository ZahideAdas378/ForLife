using Entities.ForLife;
using ForLife.CORE.DataAccess.EntityFramework;
using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.DAL
{
    public class DonorDAL : EFRepositoryBase<Donor, ForLifeDbContext>, IDonorDAL
    {
        ForLifeDbContext _db;
        public DonorDAL(ForLifeDbContext db) : base(db)
        {
            _db = db;
        }

        public int Count(Expression<Func<Donor, bool>> predicate)
        {
            return _db.Set<Donor>().Where(predicate).Count();
        }
    }
}
