using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Libraries.Providers.Models
{
    public class AirportAutocompleteApiRequestModel
    {
        public bool? AllAirports { get; set; }

        [Required]
        public string ApiKey { get; set; }

        public string Country { get; set; }

        public string Term { get; set; }
    }
}
