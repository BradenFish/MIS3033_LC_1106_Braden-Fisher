using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1106_Braden_Fisher.Controllers
{
    public class AController : Controller// inherit, name is "A"
    {
        public IActionResult B()
        {
            return View();
        }

        public JsonResult GetR()// function, action, web api
        {
            var r = new { ID = "S123", Name = "Braden Fisher", Grade = 96.6 }; 
            return Json(r);
        }
        public IActionResult Index()// action, view
        {
            ViewBag.stu = new { ID = "S123", Name = "Braden Fisher", Grade = 96.6 };
            ViewBag.age = 20;
            
            return View();
        }
    }
}
