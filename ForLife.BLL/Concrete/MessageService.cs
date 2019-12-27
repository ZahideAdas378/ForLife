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
    class MessageService : IMessageService
    {
        IMessageDAL _dal;
        public MessageService(IMessageDAL message)
        {
            _dal = message;
        }
        public void Delete(Message entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Message message = _dal.Get(a => a.MessageID == id);
            _dal.Delete(message);
        }

        public Message Get(int entityID)
        {
            return _dal.Get(a => a.MessageID == entityID);
        }

        public ICollection<Message> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Message entity)
        {
            _dal.Add(entity);
        }

        public void Update(Message entity)
        {
            _dal.Update(entity);
        }
    }
}
