using ForLife.DAL.Abstract;
using ForLife.DAL.Concrete.EntityFramework;
using ForLife.DAL.Concrete.EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        private ForLifeDbContext _db;
        public UnitOfWork(ForLifeDbContext db)
        {
            _db = db;
            AdminDAL = new AdminDAL(_db); 

        }
        public IAdminDAL AdminDAL { get; }

        public IBloodGroupDAL BloodGroupDAL { get; }

        public ICityDAL CityDAL { get; }

        public ICountryDAL CountryDAL { get; }

        public IDonationTypeDAL DonationTypeDAL { get; }

        public IDonorDAL DonorDAL { get; }

        public IMessageDAL MessageDAL { get; }

        public IPatientDAL PatientDAL { get; }

        public IPatientDonorDAL PatientDonorDAL { get; }

        public ISecurityQuestionDAL SecurityQuestionDAL { get; }

        public ISettingDAL SettingDAL { get; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public int Complete()
        {
            return _db.SaveChanges();
        }
    }
}
