using Microsoft.AspNetCore.Mvc;

namespace PetShopWebApp.Controllers
{
    public class SignInController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
