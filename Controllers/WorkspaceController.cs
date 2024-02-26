using System;
using Microsoft.AspNetCore.Mvc;
using Workspace.Models;
namespace Workspace.Controllers
{
    // public class HomeController : Controller
    public class Workspace : Controller
    {
        public IActionResult WorkspaceHello()
        {
            return View();
        }

        public IActionResult HelloAvantTek()
        {
            return View();
        }


        public IActionResult HelloHello()
        {

            Utility ut = new Utility(); 
             
            ut.Flag = 2;
            
            return View(ut);
        }
        public IActionResult NavbarFix()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Navtest()
        {
            return View();
        }
    }

}
