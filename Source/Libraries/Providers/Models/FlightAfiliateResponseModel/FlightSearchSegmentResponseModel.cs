using System.Collections.Generic;
using IO.Swagger.Model;

namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    public class FlightSearchSegmentResponseModel
    {
        public string DepartsAt { get; set; }

        public string ArrivesAt { get; set; }

        public AirportResponseModel Origin { get; set; }

        public AirportResponseModel Destination { get; set; }

        public string MarketingAirline { get; set; }

        public string OperatingAirline { get; set; }

        public string FlightNumber { get; set; }

        public string Aircraft { get; set; }

        public FlightSearchBookingInfo BookingInfo { get; set; }

    }
}
