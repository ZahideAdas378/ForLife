using Entities.ForLife;
using ForLife.CORE.DataAccess.EntityFramework;
using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework.DAL
{
    public class PatientDAL : EFRepositoryBase<Patient, ForLifeDbContext>, IPatientDAL
    {
        ForLifeDbContext _db;
        public PatientDAL(ForLifeDbContext db) : base(db)
        {
            _db = db;
        }

        public int Count(System.Linq.Expressions.Expression<Func<Patient, bool>> predicate)
        {
            return _db.Set<Patient>().Where(predicate).Count();
        }

      
    }
}
