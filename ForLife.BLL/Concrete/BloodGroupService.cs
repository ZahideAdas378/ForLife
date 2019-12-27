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
    //TODO:Burdaki metotlar fazla !!!
    class BloodGroupService : IBloodGroupService
    {
        IBloodGroupDAL _dal;
        public BloodGroupService(IBloodGroupDAL blood)
        {
            _dal = blood;

        }
        public void Delete(BloodGroup entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            BloodGroup bloodGroup = _dal.Get(a => a.BloodGroupID == id);
            _dal.Delete(bloodGroup);
        }

        public BloodGroup Get(int entityID)
        {
            return _dal.Get(a => a.BloodGroupID == entityID);
        }

        public ICollection<BloodGroup> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(BloodGroup entity)
        {
            _dal.Add(entity);
        }

        public void Update(BloodGroup entity)
        {
            _dal.Update(entity);
        }
    }
}
