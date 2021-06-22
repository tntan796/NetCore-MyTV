using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTV.Controllers
{
    public class MyTVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}