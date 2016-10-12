namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using Infrastructure.Mapping;
    using Libraries.Providers.Models;

    public class SegmentFlightViewModel : IMapFrom<FlightAffiliateApiResponseModel>
    {
        public DateTime ArrivesAt { get; private set; }

        public DateTime DepartsAt { get; private set; }

        public TimeSpan Duration { get; set; }

        public string DestinationCodeName { get; set; }

        public string DestinationName { get; set; }

        public string OriginCodeName { get; set; }

        public string OriginName { get; set; }

        public string TravelClass { get; set; }
    }
}
