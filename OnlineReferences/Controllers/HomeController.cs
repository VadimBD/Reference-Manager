using Microsoft.AspNetCore.Mvc;

namespace OnlineReferences.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public ViewResult Index() 
        { 
            return View();
        }
    }
}
