using Microsoft.AspNetCore.Mvc;

namespace OnlineReferences.Controllers
{
    public class ErrorController : Controller
    {
       public ViewResult Error()
        {
            return View();
        }
    }
}
