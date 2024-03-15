using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artwork_Sharing_Platform.Areas.Admin.Controllers
{
    public class ManageController : Controller
    {
        // GET: Admin/Manage
         public ActionResult AdminPage()
        {
            return View();
        }
        public ActionResult UserPage()
        {
            return View();
        }
        public ActionResult RequestPage()
        {
            return View();
        }
        public ActionResult UserPageBySuperAdmin()
        {
            return View();
        }
        public ActionResult ReportPage()
        {
            return View();
        }
        public ActionResult OrderPage()
        {
            return View();
        }
        public ActionResult ArtWorkPage()
        {
            return View();
        }
        public ActionResult GenrePage()
        {
            return View();
        }
    }
}