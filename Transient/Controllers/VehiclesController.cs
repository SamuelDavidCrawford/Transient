using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transient.Models;

namespace Transient.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Vehicles
        public ActionResult Random()
        {
            var vehicle = new Vehicle() { Name = "Phantom" };

            return View(vehicle);
        }
    }
}