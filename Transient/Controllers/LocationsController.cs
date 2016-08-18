using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transient.Models;

namespace Transient.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public ActionResult Index()
        {
            var locations = GetLocations();

            return View(locations);
        }

        public ActionResult Details(int id)
        {
            var location = GetLocations().SingleOrDefault(l => l.Id == id);

            if (location == null)
                return HttpNotFound();

            return View(location);

        }

        private IEnumerable<Location> GetLocations()
        {
            return new List<Location>
            {
                new Location { Name = "Bucktown", Id = 1 },
                new Location { Name = "Wicker Park", Id = 2 }
            };

        }
    }

}