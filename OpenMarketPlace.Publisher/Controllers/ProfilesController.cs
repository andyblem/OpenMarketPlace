using Microsoft.AspNetCore.Mvc;

namespace OpenMarketPlace.Publisher.Controllers
{
    public class ProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
