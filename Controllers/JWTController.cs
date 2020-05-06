using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using programmercalc.web.Models;
using programmercalc.web.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;

namespace programmercalc.web.Controllers
{
    public class JWTController : Controller
    {
        public bool IsValidKey(string key)
        {
            var bytesArray = Encoding.UTF8.GetBytes(key);
            return bytesArray.Count() > 60;
        }

        JWTInput jwtInput = null;
        public JWTController()
        {
            jwtInput = new JWTInput();
        }
        [HttpPost]
        public IActionResult Create([FromForm] JWTInput request)
        {

            var jwtResponse = TokenService.Authenticate(request);
            TempData["encoded"] = jwtResponse;
            return RedirectToAction("Index");

        }
        public IActionResult Create()
        {
            return View(jwtInput);

        }
        public IActionResult Index()
        {
            JWTViewModel model = null;
            if (TempData["model"] != null)
            {
                model = JsonConvert.DeserializeObject<JWTViewModel>((string)TempData["model"]);
                var headerAndPayload = model.Decoded.Split(new char[] { '.' });
                model.Header = headerAndPayload[0];
                model.Payload = headerAndPayload[1];
                return View(model);
            }
            else if (TempData["encoded"] != null)
            {
                model = new JWTViewModel();
                model.JWTString = (string)TempData["encoded"];
                return View(model);
            }

            else
            {
                return View(new JWTViewModel());
            }


        }
        [HttpPost]
        public IActionResult Index(JWTViewModel body)
        {
            var jwt = body.JWTString;
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);
            body.Decoded = token.ToString();

            TempData["model"] = JsonConvert.SerializeObject(body); ;
            return RedirectToAction(nameof(JWTController.Index), body);
        }
    }
}