using Naiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;



namespace Naiva.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult CVIndex()
        {
            var AdressList = CvMenu.GetFirstMenus();
            return View(AdressList);
        }

        //GET: Create/Comment

        
    }
}