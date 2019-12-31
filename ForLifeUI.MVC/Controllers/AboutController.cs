using Entities.ForLife;
using ForLife.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForLifeUI.MVC.Controllers
{
    public class AboutController : Controller
    {
        ISettingService _settingService;
        public AboutController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        // GET: About
        public ActionResult Index()
        {
            Setting setting = null;           
                          
            setting =(Setting) _settingService.GetAll().FirstOrDefault();
            return View(setting);
        }
    }
}