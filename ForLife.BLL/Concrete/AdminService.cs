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
    public class AdminService : IAdminService
    {
        IAdminDAL _dal;
        public AdminService(IAdminDAL admin)
        {
            _dal = admin;
        }
        public void Delete(Admin entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Admin admin = _dal.Get(a => a.AdminID == id);
            _dal.Delete(admin);
        }

        public Admin Get(int entityID)
        {
            return _dal.Get(a => a.AdminID == entityID);
        }

        public ICollection<Admin> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Admin entity)
        {
            _dal.Add(entity);
        }

        public void Update(Admin entity)
        {
            _dal.Update(entity);
        }

    }
}
