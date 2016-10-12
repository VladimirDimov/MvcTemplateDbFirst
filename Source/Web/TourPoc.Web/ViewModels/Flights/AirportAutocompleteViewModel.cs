namespace TourPoc.Web.ViewModels.Flights
{
    using Libraries.Providers.Models;
    using TourPoc.Web.Infrastructure.Mapping;

    public class AirportAutocompleteViewModel : IMapFrom<AirportAutocompleteApiResponseModel>
    {
        public string Label { get; private set; }

        public string Value { get; private set; }
    }
}
