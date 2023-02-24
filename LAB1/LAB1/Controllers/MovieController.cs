using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB1.Models;

namespace LAB1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            Movie movie = new Movie() { Name = "movie 1" };
            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
            };
            return View(movies);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id= "+ Id);
        }
        public ActionResult Release(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}