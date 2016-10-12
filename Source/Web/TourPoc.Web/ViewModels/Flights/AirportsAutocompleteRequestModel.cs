using Libraries.Providers.Models;
using TourPoc.Web.Infrastructure.Mapping;

namespace TourPoc.Web.ViewModels.Flights
{
    public class AirportsAutocompleteRequestModel : IMapTo<AirportAutocompleteApiRequestModel>
    {
        public bool? AllAirports { get; set; }

        public string Country { get; set; }

        public string Term { get; set; }
    }
}
