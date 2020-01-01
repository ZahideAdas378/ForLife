using Entities.ForLife;
using ForLife.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForLifeUI.MVC.Controllers
{
    public class PatientController : Controller
    {
        IPatientService _patientService;
        ISettingService _settingService;
        ICountryService _countryService;
        ICityService _cityService;
        IBloodGroupService _bloodGroup;
        IDonationTypeService _donationTypeService;
        ISecurityQuestionService _securityQuestionService;
        public PatientController(IPatientService patientService, ISettingService settingService, ICountryService countryService, ICityService cityService, IBloodGroupService bloodGroup, IDonationTypeService donationTypeService, ISecurityQuestionService securityQuestionService)
        {
            _patientService = patientService;
            _settingService = settingService;
            _countryService = countryService;
            _cityService = cityService;
            _bloodGroup = bloodGroup;
            _donationTypeService = donationTypeService;
            _securityQuestionService = securityQuestionService;
            ViewBag.Setting = _settingService.GetAll() as List<Setting>;
        }
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }
        //[Filter.PatientFilter]
        public ActionResult RegisterOne()
        {
            Patient patient = Session["patient"] as Patient;
            List<SelectListItem> cities = new List<SelectListItem>();
            List<SelectListItem> countries = new List<SelectListItem>();
            List<SelectListItem> bloodGroups = new List<SelectListItem>();
            List<SelectListItem> donatationTypes = new List<SelectListItem>();

            foreach (var item in _countryService.GetAll())
            {
                countries.Add(new SelectListItem{Text=item.CountryName,Value=item.CountryID.ToString() });
            }

            foreach (var item in _cityService.GetAll())
            {
                cities.Add(new SelectListItem { Text=item.CityName,Value=item.CityID.ToString()});
            }
            foreach (var item in _bloodGroup.GetAll())
            {
                bloodGroups.Add(new SelectListItem { Text = item.BloodGroupName, Value = item.BloodGroupID.ToString() });
            }
            foreach (var item in _donationTypeService.GetAll())
            {
                donatationTypes.Add(new SelectListItem { Text = item.DonationTypeName, Value = item.DonationTypeID.ToString() });
            }
            ViewBag.Country = countries;
            ViewBag.Cities = cities;
            ViewBag.BloodGroup = bloodGroups;
            ViewBag.DonationType = donatationTypes;
            return View(patient);
        }

        //[Filter.PatientFilter]
        public ActionResult RegisterTwo()
        {
            List<SelectListItem> securityQuestions = new List<SelectListItem>();
            foreach (var item in _securityQuestionService.GetAll())
            {
                securityQuestions.Add(new SelectListItem {Text=item.Question,Value=item.SecurityQuestionID.ToString()});
            }
            ViewBag.SecurityQuestion = securityQuestions;
            return View();
        }
        //[Filter.PatientFilter]
        //public ActionResult LastRegister()
        //{

            //Patient tempPatient = Session["patient"] as Patient;
            //Uye tempuye = uye;
            //tempuye.Type = true;
            //_uyeService.Insert(tempuye);
            //temphasta.UyeID = uye.ID;
            //_hastaService.Insert(ResimEkle.GetUploadPhoto(temphasta,_file));
            //Session["uye"] = null;
            //Session["hasta"] = null;
            //Session["donor"] = null;
            //Session["donoronay"] = null;
            //return RedirectToAction("Index", "Hasta");
        //}

        //[HttpPost]
        //public ActionResult PatientRegisterPost(string isim, string soyisim)
        //{
        //    Session["hasta"] = new Hasta { Isim = isim, Soyisim = soyisim };
        //    return RedirectToAction("Adim1", "Hasta");
        //}

        //[HttpPost]
        //public ActionResult PatientRegisterPostTwo(Hasta hasta, HttpPostedFileBase file)
        //{
        //    Hasta temphasta = Session["hasta"] as Hasta;
        //    _file = file;
        //    hasta.Isim = temphasta.Isim;
        //    hasta.Soyisim = temphasta.Soyisim;
        //    Session["hasta"] = hasta;
        //    return RedirectToAction("Adim2", "Hasta");
        //}
    }
}