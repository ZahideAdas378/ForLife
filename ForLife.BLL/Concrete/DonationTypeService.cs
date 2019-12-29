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
    public class DonationTypeService : IDonationTypeService
    {
        IDonationTypeDAL _dal;
        public DonationTypeService(IDonationTypeDAL donationType)
        {
            _dal = donationType;
        }
        public void Delete(DonationType entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            DonationType donation = _dal.Get(a => a.DonationTypeID == id);
            _dal.Delete(donation);
        }

        public DonationType Get(int entityID)
        {
            return _dal.Get(a => a.DonationTypeID == entityID);
        }

        public ICollection<DonationType> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(DonationType entity)
        {
            _dal.Add(entity);
        }

        public void Update(DonationType entity)
        {
            _dal.Update(entity);
        }
    }
}
