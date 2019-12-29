using ForLife.BLL.Abstract;
using ForLife.BLL.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForLife.App_Start
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private readonly IKernel kernel;
        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBllBinds();
        }

        private void AddBllBinds()
        {
            this.kernel.Bind<IAdminService>().To<Admi>
        }
    }
}