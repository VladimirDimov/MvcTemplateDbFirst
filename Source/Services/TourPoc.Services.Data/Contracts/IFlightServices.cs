namespace TourPoc.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Libraries.Providers.Models;

    /// <summary>
    /// Performs different kinds of searches through communication with the FlightsProvider.
    /// The FlightsProvider communicates with the third party API
    /// </summary>
    public interface IFlightServices
    {
        /// <summary>
        /// Performs flights affiliate search
        /// </summary>
        /// <param name="model">Request model for Flight Affiliate Search</param>
        /// <returns>Collection of flight results  </returns>
        Task<IEnumerable<FlightAffiliateSearchApiResponseModel>> FlightAffiliateSearchAsync(FlightAffiliateApiRequestModel model);

        /// <summary>
        /// Returns a collection with suggestted airport models based on provided string term through comunication with the Flights Provider
        /// </summary>
        Task<IEnumerable<AirportAutocompleteApiResponseModel>> AirportsAutocompleteAsync(AirportAutocompleteApiRequestModel model);
    }
}
