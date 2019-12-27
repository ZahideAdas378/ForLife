using Entities.ForLife;
using ForLife.BLL.Abstract;
using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.BLL.Concrete
{
    class CountryService : ICountryService
    {
        ICountryDAL _dal;
        public CountryService(ICountryDAL country)
        {
            _dal = country;
        }
        public void Delete(Country entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Country country = _dal.Get(a => a.CountryID == id);
            _dal.Delete(country);
        }

        public Country Get(int entityID)
        {
            return _dal.Get(a => a.CountryID == entityID);
        }

        public ICollection<Country> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Country entity)
        {
            _dal.Add(entity);
        }

        public void Update(Country entity)
        {
            _dal.Update(entity);
        }
    }
}
