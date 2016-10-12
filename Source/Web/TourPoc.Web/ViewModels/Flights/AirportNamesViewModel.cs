using System;
using CommonHelpers.AirportsHelper;

namespace TourPoc.Web.ViewModels.Flights
{
    public class AirportNamesViewModel
    {
        public static Func<AffiliateFlightsSearchModel, AirportNamesViewModel> FromModel
        {
            get
            {
                return m =>
                {
                    return new AirportNamesViewModel
                    {
                        OriginAirportName = AirportsHelpers.RemoveCodeFromAirportName(m.Origin),
                        DestinationAirportName = AirportsHelpers.RemoveCodeFromAirportName(m.Destination)
                    };
                };
            }
        }

        public string OriginAirportName { get; set; }

        public string DestinationAirportName { get; set; }
    }
}