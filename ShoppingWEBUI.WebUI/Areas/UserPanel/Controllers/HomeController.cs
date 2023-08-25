using Microsoft.AspNetCore.Mvc;

namespace ShoppingWEBUI.WebUI.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class HomeController : Controller
    {
        [HttpGet("/User/Anasayfa")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
