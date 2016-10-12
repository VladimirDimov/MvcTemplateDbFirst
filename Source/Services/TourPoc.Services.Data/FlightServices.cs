namespace TourPoc.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts;
    using Libraries.Providers.Contracts;
    using Libraries.Providers.Models;
    using TourPoc.Common;

    public class FlightServices : IFlightServices
    {
        private IFlightsProvider flightsProvider;

        public FlightServices(IFlightsProvider flightsProvider)
        {
            this.flightsProvider = flightsProvider;
        }

        public async Task<IEnumerable<FlightAffiliateSearchApiResponseModel>> FlightAffiliateSearchAsync(FlightAffiliateApiRequestModel model)
        {
            model.ApiKey = ApiGlobalConstants.ApiKey;
            var result = await this.flightsProvider.AffiliateSearch(model);

            return result;
        }

        public async Task<IEnumerable<AirportAutocompleteApiResponseModel>> AirportsAutocompleteAsync(AirportAutocompleteApiRequestModel model)
        {
            model.ApiKey = ApiGlobalConstants.ApiKey;
            var suggestions = await this.flightsProvider.GetAirportsAutocompleteSuggestions(model);

            return suggestions;
        }
    }
}
