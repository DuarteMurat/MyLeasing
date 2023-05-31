using Microsoft.AspNetCore.Mvc;

namespace MyLeasing.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
