using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(x=>x.Genre).ToList();
            return View(movies);
        }
        public ActionResult Detail(int id)
        {
            var model = _context.Movies.Include(x=>x.Genre).FirstOrDefault(x => x.Id == id);

            if(model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
    }
}