﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nirisarri.com.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "This is my first production deployed app.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "email me....";

			return View();
		}
	}
}