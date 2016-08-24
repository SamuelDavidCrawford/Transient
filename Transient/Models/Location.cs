using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transient.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public string Address { get; set; }

    }
}