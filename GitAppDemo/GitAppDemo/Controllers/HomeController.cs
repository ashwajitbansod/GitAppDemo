﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BhushanActionMethod()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FetchMethodTesting()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}