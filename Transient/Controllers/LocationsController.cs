using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transient.Models;
using Transient.ViewModels;

namespace Transient.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        private ApplicationDbContext _context;

        public LocationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var locations = _context.Locations.ToList();

            return View(locations);
        }

        public ActionResult Details(int id)
        {
            var location = _context.Locations.SingleOrDefault(l => l.Id == id);

            if (location == null)
                return HttpNotFound();

            return View(location);

        }

        public ViewResult New()
        {
            var viewModel = new LocationFormViewModel();

            return View("LocationForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var location = _context.Locations.SingleOrDefault(c => c.Id == id);
            if (location == null)
                return HttpNotFound();
            
            var viewModel = new LocationFormViewModel
            {
                Location = location

            };

            return View("LocationForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Location location)
        {
            if(location.Id == 0)
            {
                _context.Locations.Add(location);
            }
            else
            {
                var locationInDb = new Location();
                locationInDb.Name = location.Name;
                locationInDb.Address = location.Address;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Locations");
        }


    }

}