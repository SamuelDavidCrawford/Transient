using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transient.Models;
using Transient.ViewModels;
using System.Data.Entity;

namespace Transient.Controllers
{
    public class VehiclesController : Controller
    {
        // GET: Vehicles

        private ApplicationDbContext _context;

        public VehiclesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var vehicleTypes = _context.VehicleTypes.ToList();
            var viewModel = new VehicleFormViewModel
            {
                VehicleTypes = vehicleTypes
            };

            return View("VehicleForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Vehicle vehicle)
        {
            if (vehicle.Id == 0)
                _context.Vehicles.Add(vehicle);
            else
            {
                var vehicleInDb = _context.Vehicles.Single(v => v.Id == vehicle.Id);
                vehicleInDb.Name = vehicle.Name;
                vehicleInDb.Year = vehicle.Year;
                vehicleInDb.VehicleTypeId = vehicle.VehicleTypeId;
                vehicleInDb.NumberInStock = vehicle.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Vehicles");
        }

        public ActionResult Edit(int id)
        {
            var vehicle = _context.Vehicles.SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return HttpNotFound();

            var viewModel = new VehicleFormViewModel
            {
                Vehicle = vehicle,
                VehicleTypes = _context.VehicleTypes.ToList()
            };

            return View("VehicleForm", viewModel);
        }

        public ViewResult Index()
        {
            var vehicles = _context.Vehicles.Include(v => v.VehicleType).ToList();

            return View(vehicles);
        }

        public ActionResult Details(int id)
        {
            var vehicle = _context.Vehicles.Include(v => v.VehicleType).SingleOrDefault(v => v.Id == id);

            if (vehicle == null)
                return HttpNotFound();

            return View(vehicle);
        }

        //not being used
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