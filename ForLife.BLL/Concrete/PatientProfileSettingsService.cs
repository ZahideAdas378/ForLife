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
    public class PatientProfileSettingsService : IPatientProfileSettingsService
    {
        IPatientProfileSettingsDAL _dal;
        public PatientProfileSettingsService(IPatientProfileSettingsDAL profileSettingsDAL)
        {
            _dal = profileSettingsDAL;
        }
        public void Delete(PatientProfileSettings entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            PatientProfileSettings profileSettings = _dal.Get(a => a.PatientID == id);
            _dal.Delete(profileSettings);

        }

        public PatientProfileSettings Get(int entityID)
        {

            return _dal.Get(a => a.PatientID == entityID);
        }

        public ICollection<PatientProfileSettings> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(PatientProfileSettings entity)
        {
            _dal.Add(entity);
        }

        public void Update(PatientProfileSettings entity)
        {
            _dal.Update(entity);
        }
    }
}
