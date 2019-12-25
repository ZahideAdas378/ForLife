using ForLife.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.UnitOfWork
{
    interface IUnitOfWork:IDisposable
    {
        IAdminDAL AdminDAL { get;}
        IBloodGroupDAL BloodGroupDAL { get;}
        ICityDAL CityDAL { get;}
        ICountryDAL CountryDAL { get;}
        IDonationTypeDAL DonationTypeDAL { get;}
        IDonorDAL DonorDAL { get;}
        IMessageDAL MessageDAL { get;}
        IPatientDAL PatientDAL { get;}
        IPatientDonorDAL PatientDonorDAL { get;}
        ISecurityQuestionDAL SecurityQuestionDAL { get;}
        ISettingDAL SettingDAL { get;}

        int Complete();
        
    }
}
