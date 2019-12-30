using Entities.ForLife;
using ForLife.BLL.Abstract;
using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.BLL.Concrete
{
    public class PatientService : IPatientService
    {
        IPatientDAL _dal;
        public PatientService(IPatientDAL patient)
        {
            _dal = patient;
        }

        public int Count(Expression<Func<Patient, bool>> predicate)
        {
            return _dal.Count(predicate);
        }

        public void Delete(Patient entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Patient patient = _dal.Get(a => a.PatientID == id);
            _dal.Delete(patient);
        }

        public List<Patient> FilterPatients(Country country, DonationType donationType, DateTime date)
        {
            return _dal.GetAll(a => a.City.Country == country && a.DonationTypes == donationType && a.DonationDate == date).ToList();

        }

        public Patient Get(int entityID)
        {
            return _dal.Get(a => a.PatientID == entityID);
        }

        public ICollection<Patient> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Patient entity)
        {
            _dal.Add(entity);
        }

        public void Update(Patient entity)
        {
            _dal.Update(entity);
        }
    }
}
