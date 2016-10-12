namespace Libraries.Providers.Models
{
    using System;
    using CommonHelpers.AirportsHelper;
    using IO.Swagger.Model;

    public class FlightAffiliateApiResponseModel
    {
        public static Func<FlightSearchSegment, FlightAffiliateApiResponseModel> FromModel
        {
            get
            {
                return m =>
                {
                    var departsAt = DateTime.Parse(m.DepartsAt);
                    var arrivesAt = DateTime.Parse(m.ArrivesAt);

                    return new FlightAffiliateApiResponseModel
                    {
                        DepartsAt = departsAt,
                        ArrivesAt = arrivesAt,
                        Duration = arrivesAt - departsAt,
                        TravelClass = m.BookingInfo.TravelClass,
                        OriginCodeName = m.Origin._Airport,
                        OriginName = AirportsHelpers.GetNameFromCode(m.Origin._Airport),
                        DestinationCodeName = m.Destination._Airport,
                        DestinationName = AirportsHelpers.GetNameFromCode(m.Destination._Airport),
                    };
                };
            }
        }

        public DateTime ArrivesAt { get; set; }

        public DateTime DepartsAt { get; set; }

        public TimeSpan Duration { get; set; }

        public string DestinationCodeName { get; set; }

        public string DestinationName { get; set; }

        public string OriginCodeName { get; set; }

        public string OriginName { get; set; }

        public string TravelClass { get; set; }
    }
}
