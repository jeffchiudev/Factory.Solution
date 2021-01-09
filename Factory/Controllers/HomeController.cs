using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult Index()
        {
            List<Engineer> model = _db.Engineers.ToList();
            return View(model);
        }
    }
}