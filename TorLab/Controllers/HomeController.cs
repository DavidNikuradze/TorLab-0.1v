using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorLab.Controllers
{
    public class HomeController : Controller
    {
        
      public IActionResult Index(int id)
        {
            return View();
        }
    }
}
