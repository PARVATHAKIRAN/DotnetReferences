using Microsoft.AspNetCore.Mvc;
using SampleWebApplication.Models;


namespace SampleWebApplication.Controllers
{
    //public class IndexController : Controller
    //{
    //    public string? Ename { get; private set; }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

        //[HttpPost]
        //public ActionResult Check(string nameentered) 
        //{
        //    if (string.IsNullOrEmpty(Ename))
        //    {
        //        ViewBag.Message = "Input value is empty!";
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Input value is: " + Ename;
        //    }

        //    return View("Index");
        //}


public class IndexController : Controller
    {
        private readonly AppDbContext _context;

        public IndexController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(string name)
        {
            var newName = new Name
            {
                FullName = name
            };

            _context.Names.Add(newName);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }

    internal class Name : Models.Index
    {
        public string FullName { get; set; }
    }
}
