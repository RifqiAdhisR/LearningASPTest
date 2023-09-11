using Microsoft.AspNetCore.Mvc;

namespace WebLearningTest.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
