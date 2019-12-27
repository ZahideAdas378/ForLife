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
    class SecurityQuestionService : ISecurityQuestionService
    {
        ISecurityQuestionDAL _dal;
        public SecurityQuestionService(ISecurityQuestionDAL security)
        {
            _dal = security;
        }
        public void Delete(SecurityQuestion entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            SecurityQuestion security = _dal.Get(a => a.SecurityQuestionID == id);
            _dal.Delete(security);
        }

        public SecurityQuestion Get(int entityID)
        {
            return _dal.Get(a => a.SecurityQuestionID == entityID);
        }

        //todo
        public ICollection<SecurityQuestion> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(SecurityQuestion entity)
        {
            _dal.Add(entity);
        }

        public void Update(SecurityQuestion entity)
        {
            _dal.Update(entity);
        }
    }
}
