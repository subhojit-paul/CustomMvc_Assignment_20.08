using CustMovMVCAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustMovMVCAppWithAuthentication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index1()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        public ActionResult Details1(int id)
        {
            var singleMovie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (singleMovie == null)
                return HttpNotFound();
            return View(singleMovie);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
    }
}