﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Data.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
