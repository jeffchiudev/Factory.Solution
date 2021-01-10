using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Factory.Models;
using System.Dynamic;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
        private readonly FactoryContext _db;

        public HomeController(FactoryContext db)
        {
            _db = db;
        }
        //[HttpGet("/")]
        public ActionResult Index(int id)
        {
            dynamic model = new ExpandoObject();
            model.Engineers = _db.Engineers.ToList();
            model.Machines = _db.Machines.ToList();
            return View(model);
        }
    }
}