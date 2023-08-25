using Microsoft.AspNetCore.Mvc;

namespace ShoppingWEBUI.WebUI.Areas.UserPanel.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
