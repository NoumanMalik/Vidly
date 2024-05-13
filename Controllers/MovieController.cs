using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

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

        #region Movies List and Detail
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
        #endregion
        
        #region Add and Edit Movie
        public ActionResult New()
        {
            ViewBag.Title = "New Movie";
            var genre =_context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genre = genre,
            };
            return View("Save",viewModel);
        }
        [HttpPost]
        public ActionResult Create(MovieFormViewModel viewModel)
        {
            try
            {
                var model = new Movies
                {
                    Id = viewModel.Movie.Id,
                    Name = viewModel.Movie.Name,
                    ReleaseDate = viewModel.Movie.ReleaseDate,
                    AddedDate = viewModel.Movie.AddedDate,
                    Stock = viewModel.Movie.Stock,
                    GenreId = viewModel.Movie.GenreId,
                };
                if(model.Id == 0)
                    _context.Movies.Add(model);
                else
                {
                    var movie = _context.Movies.Single(x => x.Id == model.Id);
                    movie.Name = model.Name;
                    movie.ReleaseDate = model.ReleaseDate;
                    movie.AddedDate = model.AddedDate;
                    movie.Stock = model.Stock;
                    movie.GenreId = model.GenreId;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //var c = ex.InnerException.Message;
            }
            return RedirectToAction("Index", "Movie");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Edit Movie";
            var model = _context.Movies.Single(x => x.Id == id);
            var viewModel = new MovieFormViewModel
            {
                Movie = model,
                Genre = _context.Genres.ToList(),
            };
            return View("Save", viewModel);
        }
        #endregion
    }
}