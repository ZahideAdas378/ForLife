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
        static HttpPostedFileBase _file;
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
            List<SelectListItem> contacts = new List<SelectListItem> { new SelectListItem { Text = "İnternet" },new SelectListItem { Text="Reklam"}, new SelectListItem { Text = "Gazete" }, new SelectListItem { Text = "Dergi" } };

            ViewBag.ContactChannel = contacts;
            return View();
        }
        [Filter.PatientFilter]
        public ActionResult RegisterOne()
        {
            Patient patient = Session["patient"] as Patient;
            List<SelectListItem> cities = new List<SelectListItem>();
            List<SelectListItem> countries = new List<SelectListItem>();
            List<SelectListItem> bloodGroups = new List<SelectListItem>();
            List<SelectListItem> donatationTypes = new List<SelectListItem>();
            List<SelectListItem> genders = new List<SelectListItem> { new SelectListItem { Text = "Erkek", Value = "Erkek" }, new SelectListItem { Text = "Kadın", Value = "Kadın" } };
            ViewBag.Gender = genders;
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

        [Filter.PatientFilter]
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
        [HttpPost]
        public ActionResult PatientRegisterPost(Patient patient)
        {
            Session["patient"] = patient;
            return RedirectToAction("RegisterOne", "Patient");
        }

        [HttpPost]
        public ActionResult PatientRegisterPostOne(Patient patient)
        {
            //Patient tempPatient = Session["patient"] as Patient;
            //patient.FirstName = tempPatient.FirstName;
            //patient.LastName = tempPatient.LastName;
            //(Session["patient"] as Patient).FirstName = patient.FirstName;
            //(Session["patient"] as Patient).LastName = patient.LastName;
            //(Session["patient"] as Patient).Photo = patient.Photo;
            //(Session["patient"] as Patient).BirthDate = patient.BirthDate;
            //(Session["patient"] as Patient).ContactChannel = patient.ContactChannel;
            //patient.ContactChannel = tempPatient.ContactChannel;

            (Session["patient"] as Patient).IdentityNumber = patient.IdentityNumber;
            (Session["patient"] as Patient).Address = patient.Address;
            (Session["patient"] as Patient).Phone = patient.Phone;
            (Session["patient"] as Patient).CityID = patient.CityID;
            (Session["patient"] as Patient).DonationTypeID = patient.DonationTypeID;
            (Session["patient"] as Patient).BloodGroupID = patient.BloodGroupID;
            (Session["patient"] as Patient).DonationDate = patient.DonationDate;
            (Session["patient"] as Patient).Gender = patient.Gender;
            
            return RedirectToAction("RegisterTwo", "Patient");
        }
        //[Filter.PatientFilter]
        [HttpPost]
        public ActionResult PatientRegisterPostTwo(Patient patient)
        {
            (Session["patient"] as Patient).UserName = patient.UserName;
            (Session["patient"] as Patient).Password = patient.Password;
            (Session["patient"] as Patient).SecurityQuestionID = patient.SecurityQuestionID;
            (Session["patient"] as Patient).SecurityAnswer = patient.SecurityAnswer;
            (Session["patient"] as Patient).IsActive = false;
            (Session["patient"] as Patient).CreateDate = DateTime.Now;
            //tempPatient.UserName = patient.UserName;
            //tempPatient.Password = patient.Password;
            //tempPatient.SecurityAnswer = patient.SecurityAnswer;
            //tempPatient.SecurityQuestionID = patient.SecurityQuestionID;
            _patientService.Insert((Session["patient"] as Patient));            
            Session["patient"] = null;
            //Session["donor"] = null;
            //Session["donoronay"] = null;
            return RedirectToAction("Index", "Patient");
        }


     
    }
}