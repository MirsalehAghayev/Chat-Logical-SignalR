using Microsoft.AspNetCore.Mvc;
using Signal_WebP323.Models;
using System.Diagnostics;

namespace Signal_WebP323.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        { 

        }

        public IActionResult Index()
        {
            return View();
        }


    }
}