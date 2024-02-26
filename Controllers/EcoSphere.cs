using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Workspace.Controllers
{
    public class EcoSphere : Controller
    {
        public IActionResult ModernWeb()
        {
            return View();
        }
        public IActionResult DLT()
        {
            return View();
        }
    }
}
