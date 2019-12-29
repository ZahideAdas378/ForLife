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
    public class DonorProfileSettingsService : IDonorProfileSettingsService
    {
        IDonorProfileSettingsDAL _dal;
        public DonorProfileSettingsService(IDonorProfileSettingsDAL donorProfileSettingsDAL)
        {
            _dal = donorProfileSettingsDAL;
        }
        public void Delete(DonorProfileSettings entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {

            DonorProfileSettings donorProfileSettings = _dal.Get(a => a.DonorID == id);
            _dal.Delete(donorProfileSettings);
        }

        public DonorProfileSettings Get(int entityID)
        {
            return _dal.Get(a => a.DonorID == entityID);
        }

        public ICollection<DonorProfileSettings> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(DonorProfileSettings entity)
        {
            _dal.Add(entity);
        }

        public void Update(DonorProfileSettings entity)
        {
            _dal.Update(entity);
        }
    }
}
