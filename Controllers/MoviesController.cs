using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Sample.Models;
using MVC_Sample.ViewModel;
using System.Data.Entity;
namespace MVC_Sample.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;
        public MoviesController() {

            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            var movie = _context.Movies.Include(c => c.Genre).ToList();
            return View(movie);
        }
        private IEnumerable<Movie> getMovie()
        {

            return new List<Movie> {
                new Movie{Id=1,Name="OMG"},
                new Movie {Id=2,Name="3 Idiot" }
            };

        }
        public ActionResult Details(int id) {

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c=>c.Id==id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }
        public ActionResult Random()
        {
            var movies = new Movie() { Name = "3Idiot" };
            var customer = new List<Customer>() {

                new Customer{ Name="Customer 1"},
                new Customer { Name = "Customer 2" }
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movies,
                Customer = customer

            };
            return View(ViewModel);
        }


    }

}
