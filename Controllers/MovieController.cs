using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies{Id = 1, Name = "Shrek"},
                new Movies{Id = 2,Name = "PK"},
                new Movies{Id = 3,Name = "Welcome"}
            };
        }
    }
}