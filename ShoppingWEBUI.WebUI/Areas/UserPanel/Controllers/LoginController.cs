using Microsoft.AspNetCore.Mvc;

namespace ShoppingWEBUI.WebUI.Areas.UserPanel.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
