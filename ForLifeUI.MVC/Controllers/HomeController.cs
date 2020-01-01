using Entities.ForLife;
using ForLife.BLL.Abstract;
using ForLifeUI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForLifeUI.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IDonorService _donorService;
        IPatientService _patientService;
        ISettingService _settingService;

        public HomeController(IDonorService donorService, IPatientService patientService, ISettingService settingService)
        {
            _donorService = donorService;
            _patientService = patientService;
            _settingService = settingService;
            ViewBag.Setting = _settingService.GetAll() as List<Setting>;
        }
        public ActionResult Index()
        {
            ViewBag.PatientCount = _patientService.Count(a => a.PatientID > 0);
            ViewBag.DonorCount = _donorService.Count(a => a.DonorID > 0);      
            return View();
        }      
          
        public ActionResult About()
        {
          
            return View();
        }
     

        

    }
}