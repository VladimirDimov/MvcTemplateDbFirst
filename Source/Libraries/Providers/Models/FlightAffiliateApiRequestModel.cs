namespace Libraries.Providers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FlightAffiliateApiRequestModel
    {
        public int? Adults { get; internal set; }

        [Required]
        public string ApiKey { get; set; }

        public int? Children { get; internal set; }

        public string Currency { get; internal set; }

        public DateTime DepartureDate { get; internal set; }

        [Required]
        public string Destination { get; internal set; }

        public List<string> ExcludeMerchants { get; internal set; }

        public List<string> IncludeMerchants { get; internal set; }

        public int? Infants { get; internal set; }

        public int? MaxPrice { get; internal set; }

        public bool? Mobile { get; internal set; }

        [Required]
        public string Origin { get; internal set; }

        public DateTime? ReturnDate { get; internal set; }
    }
}
