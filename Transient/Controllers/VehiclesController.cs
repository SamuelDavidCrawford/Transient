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
    }
}