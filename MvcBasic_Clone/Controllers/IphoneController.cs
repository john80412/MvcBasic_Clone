using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class IphoneController : Controller
    {
        // GET: Iphone
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IphonePage()
        {
            return View();
        }
    }
}