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
    public class SettingService : ISettingService
    {
        ISettingDAL _dal;
        public SettingService(ISettingDAL setting)
        {
            _dal = setting;
        }
        public void Delete(Setting entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Setting setting = _dal.Get(a => a.SettingID == id);
            _dal.Delete(setting);
        }

        public Setting Get(int entityID)
        {
            return _dal.Get(a => a.SettingID == entityID);
        }

        public ICollection<Setting> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Setting entity)
        {
            _dal.Add(entity);
        }

        public void Update(Setting entity)
        {
            _dal.Update(entity);
        }
    }
}
