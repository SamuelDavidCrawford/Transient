using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transient.Models;

namespace Transient.ViewModels
{
    public class VehicleFormViewModel
    {
        public IEnumerable<VehicleType> VehicleType { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}