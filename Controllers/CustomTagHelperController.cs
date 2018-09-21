using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelpers.Controllers
{
    public class CustomTagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}