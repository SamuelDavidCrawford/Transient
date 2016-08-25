using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transient.Models;

namespace Transient.ViewModels
{
    public class LocationFormViewModel
    {
        public Location Location { get; set; }
        public string Title
        {
            get
            {
                if (Location != null && Location.Id != 0)
                    return "Edit Location";
                return "New Location";
            }
        }
    }
}