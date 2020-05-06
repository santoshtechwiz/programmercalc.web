using Microsoft.AspNetCore.Mvc;
using programmercalc.web.Models;
using programmercalc.web.Services;
namespace programmercalc.web.Controllers
{
    public class BinaryCotroller : Controller
    {
        public ActionResult UTFToAsci()
        {
            return View(new InputViewModel());
        }

        [HttpPost]
        public ActionResult UTFToAsci(InputViewModel model)
        {
            InputViewModel inputViewModel = new InputViewModel();
            inputViewModel.Input = model.Input;
            inputViewModel.Output = model.Input.EncodeNonAsciiCharacters();
            this.ModelState.Clear();
            return (ActionResult)this.View((object)inputViewModel);
        }
    }
}