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
    class CityService : ICityService
    {
        ICityDAL _dal;
        public CityService(ICityDAL city)
        {
            _dal = city;
        }
        public void Delete(City entity)
        {
             _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            City city = _dal.Get(a => a.CityID == id);
            _dal.Delete(city);
        }

        public City Get(int entityID)
        {
            return _dal.Get(a => a.CityID == entityID);
        }

        public ICollection<City> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(City entity)
        {
            _dal.Add(entity);
        }

        public void Update(City entity)
        {
            _dal.Update(entity);
        }
    }
}
