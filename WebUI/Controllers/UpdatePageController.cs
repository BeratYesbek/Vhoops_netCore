﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class UpdatePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Popup()
        {
            return PartialView();
        }
    }
}