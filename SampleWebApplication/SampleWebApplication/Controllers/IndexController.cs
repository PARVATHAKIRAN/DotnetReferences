using Microsoft.AspNetCore.Mvc;


namespace SampleWebApplication.Controllers
{
    public class IndexController : Controller
    {
        public string? Ename { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check(string nameentered) 
        {
            if (string.IsNullOrEmpty(Ename))
            {
                ViewBag.Message = "Input value is empty!";
            }
            else
            {
                ViewBag.Message = "Input value is: " + Ename;
            }

            return View("Index");
        }
    }
}
