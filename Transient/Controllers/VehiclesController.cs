using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transient.Models;
using Transient.ViewModels;

namespace Transient.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Vehicles
        public ActionResult Random()
        {
            var vehicle = new Vehicle() { Name = "Phantom" };
            var customers = new List<Customer>()
            {
                new Customer { Name = "Johnny" },
                new Customer {Name= "Gilroy" }
            };

            var viewModel = new RandomVehicleViewModel()
            {
                Vehicle = vehicle,
                Customers = customers

            };

            return View(viewModel);
        }

        public ViewResult Index()
        {
            var vehicles = GetVehicles();

            return View(vehicles);
        }

        public ActionResult Details(int id)
        {
            var vehicle = GetVehicles();

            if (vehicle == null)
                return HttpNotFound();

            return View(vehicle);
        }

        private IEnumerable<Vehicle> GetVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle { Name = "Rolls Royce", Id = 1 },
                new Vehicle {Name = "Range Rover", Id = 2 }
            };
        }
    }
}