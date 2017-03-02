﻿using Naiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Naiva.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var menuList = menu.GetIndexMenus();
            return View(menuList);
        }

        
    }
}