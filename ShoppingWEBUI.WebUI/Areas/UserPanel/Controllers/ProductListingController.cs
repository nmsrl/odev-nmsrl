using Microsoft.AspNetCore.Mvc;

namespace ShoppingWEBUI.WebUI.Areas.UserPanel.Controllers
{
    public class ProductListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
