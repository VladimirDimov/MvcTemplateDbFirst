namespace Libraries.Providers.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Libraries.Providers.Models;

    /// <summary>
    /// Perform flights operations through communication with the third party API
    /// </summary>
    public interface IFlightsProvider
    {
        /// <summary>
        /// Performs flights affiliate search through communication with the third party API
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IEnumerable<FlightAffiliateSearchApiResponseModel>> AffiliateSearch(FlightAffiliateApiRequestModel model);

        /// <summary>
        /// Searches the api database for all airports by provided string term.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Returns collection with all suggestions</returns>
        Task<IEnumerable<AirportAutocompleteApiResponseModel>> GetAirportsAutocompleteSuggestions(AirportAutocompleteApiRequestModel model);
    }
}
