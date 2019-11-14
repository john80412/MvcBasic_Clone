using MvcBasic_Clone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";
            ViewData["Age"] = 33;
            ViewData["Single"] = true;
            return View();
        }
        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            ViewData["Nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;
            return View();
        }
        public ActionResult PetShop()
        {
            ViewData["Company"] = "汪星人寵物店";
            ViewBag.Address = "台北市信義區松山路100號";
            List<string> petsList = new List<string>();
            petsList.Add("狗");
            petsList.Add("貓");
            petsList.Add("魚");
            petsList.Add("鼠");
            petsList.Add("變色龍");
            return View(petsList);
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料,請聯絡系統管理員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
        public ActionResult PassViewModel()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.Employees = null;
            peopleVM.Friends = null;
            return View(peopleVM);
        }
    }
}