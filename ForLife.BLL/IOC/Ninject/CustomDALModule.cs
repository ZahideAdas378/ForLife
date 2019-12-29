using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForLife.DAL.Abstract;
using ForLife.DAL.Concrete.EntityFramework.DAL;
using Ninject.Modules;

namespace ForLife.BLL.IOC.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminDAL>().To<AdminDAL>();
            Bind<IBloodGroupDAL>().To<BloodGroupDAL>();
            Bind<ICityDAL>().To<CityDAL>();
            Bind<ICountryDAL>().To<CountryDAL>();
            Bind<IDonationTypeDAL>().To<DonationTypeDAL>();
            Bind<IDonorDAL>().To<DonorDAL>();
            Bind<IMessageDAL>().To<MessageDAL>();
            Bind<IPatientDAL>().To<PatientDAL>();
            Bind<IPatientDonorDAL>().To<PatientDonorDAL>();
            Bind<ISecurityQuestionDAL>().To<SecurityQuestionDAL>();
            Bind<ISettingDAL>().To<SettingDAL>();
            Bind<IDonorProfileSettingsDAL>().To<DonorProfileSettingsDAL>();
            Bind<IPatientProfileSettingsDAL>().To<PatientProfileSettingsDAL>();
        }


    }
}
