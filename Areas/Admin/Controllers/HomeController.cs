﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ITS_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
