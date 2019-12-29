using Entities.ForLife;
using ForLife.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForLife.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IBloodGroupService _bloodGroupService;
       
        public HomeController(IBloodGroupService bloodGroupService)
        {
            _bloodGroupService = bloodGroupService;
            
        }      
        public ActionResult Index()
        {
            List<BloodGroup> bloodGroups = new List<BloodGroup>();
            bloodGroups = _bloodGroupService.GetAll().ToList();           
            return View(bloodGroups);
        }
    }
}