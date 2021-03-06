﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Transient.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public DateTime? Year { get; set; }
        public DateTime? YearAdded { get; set; }
        public int NumberInStock { get; set; }
        public VehicleType VehicleType { get; set; } //navigation property

        [Required]
        public byte VehicleTypeId { get; set; }

    }

    // /vehicles/random
}