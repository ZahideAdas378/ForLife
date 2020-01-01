using ForLife.BLL.Abstract;
using ForLife.BLL.Concrete;
using ForLife.BLL.IOC.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ForLifeUI.MVC.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
     
        private readonly IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBllBinds();
        }
        
        private void AddBllBinds()
        {
            this.kernel.Bind<IAdminService>().To<AdminService>();
            this.kernel.Bind<IBloodGroupService>().To<BloodGroupService>();
            this.kernel.Bind<ICountryService>().To<CountryService>();
            this.kernel.Bind<ICityService>().To<CityService>();
            this.kernel.Bind<IDonationTypeService>().To<DonationTypeService>();
            this.kernel.Bind<IDonorProfileSettingsService>().To<DonorProfileSettingsService>();
            this.kernel.Bind<IDonorService>().To<DonorService>();
            this.kernel.Bind<IMessageService>().To<MessageService>();
            this.kernel.Bind<IPatientDonorService>().To<PatientDonorService>();
            this.kernel.Bind<IPatientProfileSettingsService>().To<PatientProfileSettingsService>();
            this.kernel.Bind<IPatientService>().To<PatientService>();
            this.kernel.Bind<ISecurityQuestionService>().To<SecurityQuestionService>();
            this.kernel.Bind<ISettingService>().To<SettingService>();
            this.kernel.Load<CustomDALModule>();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);

        }

    }
}