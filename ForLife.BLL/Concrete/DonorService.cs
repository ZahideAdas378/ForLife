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
    class DonorService : IDonorService
    {
        IDonorDAL _dal;
        public DonorService(IDonorDAL donor)
        {
            _dal = donor;
        }
        public void Delete(Donor entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            Donor donor = _dal.Get(a => a.DonorID == id);
            _dal.Delete(donor);
        }

        public List<Donor> FilterDonors(Country country, DonationType donationType, DateTime date)
        {
            return  _dal.GetAll(a=>a.City.Country==country&&a.DonationTypes==donationType&&a.DonationDate==date).ToList();
           
        }

        public Donor Get(int entityID)
        {
            return _dal.Get(a => a.DonorID == entityID);
        }

        public ICollection<Donor> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Donor entity)
        {
            _dal.Add(entity);
        }

        public void Update(Donor entity)
        {
            _dal.Update(entity);
        }
    }
}
