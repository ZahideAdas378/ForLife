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
  public  class PatientDonorService : IPatientDonorService
    {
        IPatientDonorDAL _dal;
        public PatientDonorService(IPatientDonorDAL patientDonor)
        {
            _dal = patientDonor;
        }
        public void Delete(PatientDonor entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            PatientDonor patientDonor = _dal.Get(a => a.PatientDonorID == id);
            _dal.Delete(patientDonor);
        }

        public PatientDonor Get(int entityID)
        {
            return _dal.Get(a=>a.PatientDonorID==entityID);
        }

        public ICollection<PatientDonor> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(PatientDonor entity)
        {
            _dal.Add(entity);
        }

        public void Update(PatientDonor entity)
        {
            _dal.Update(entity);
        }
    }
}
