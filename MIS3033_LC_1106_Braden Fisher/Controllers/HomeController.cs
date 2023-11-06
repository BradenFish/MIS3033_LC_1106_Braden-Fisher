using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1106_Braden_Fisher.Controllers
{
    public class HomeController : Controller// name is Home
    {
        public int GetInt()
        {
            return 20;
        }

        public IActionResult Index()// this is called action
        {
            return View();
        }
    }
}
