using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using programmercalc.web.Models;
using programmercalc.web.Services;

namespace programmercalc.web.Controllers
{
    public class Base64Controller : Controller
    {

      
        [HttpGet]
        public ActionResult ToBase64()
        {
            return View("Base64");
        }

        [HttpGet]
        public IActionResult ToUSrting()
        {
            return View();

        }
       
    }
}