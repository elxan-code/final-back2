using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Areas.admin.Controllers
{
    [Area("admin")]
    public class RegisterController : Controller
    {
    
        public IActionResult Login()
        {
            return View();
        }
    }
}
