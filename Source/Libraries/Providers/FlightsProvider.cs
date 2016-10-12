namespace Libraries.Providers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using Contracts;
    using IO.Swagger.Api;
    using IO.Swagger.Model;
    using Models;

    public class FlightsProvider : IFlightsProvider
    {
        private const string DateFormat = "yyyy-MM-dd";

        private IDefaultApi defaultApi;

        public FlightsProvider(IDefaultApi defaultApi)
        {
            this.defaultApi = defaultApi;
        }

        public async Task<IEnumerable<FlightAffiliateSearchApiResponseModel>> AffiliateSearch(FlightAffiliateApiRequestModel model)
        {
            this.Validate(model);

            var response = await this.defaultApi.FlightAffiliateSearchAsync(
                                                                model.ApiKey,
                                                                model.Origin,
                                                                model.Destination,
                                                                model.DepartureDate.ToString(DateFormat),
                                                                model.ReturnDate.HasValue ? model.ReturnDate.Value.ToString(DateFormat) : null,
                                                                model.Adults,
                                                                model.Children,
                                                                model.Infants,
                                                                model.IncludeMerchants.Count != 0 ? model.IncludeMerchants : null,
                                                                model.ExcludeMerchants.Count != 0 ? model.ExcludeMerchants : null,
                                                                model.MaxPrice,
                                                                model.Currency,
                                                                model.Mobile);

            var result = new List<FlightAffiliateSearchApiResponseModel>();
            foreach (var item in response.Results)
            {
                result.Add(FlightAffiliateSearchApiResponseModel.FromModel(item, response.Meta));
            }

            return result;
        }

        public async Task<IEnumerable<AirportAutocompleteApiResponseModel>> GetAirportsAutocompleteSuggestions(AirportAutocompleteApiRequestModel model)
        {
            this.Validate(model);

            var suggestions = await this.defaultApi.AirportAutocompleteAsync(
                                                                            model.ApiKey,
                                                                            model.Term,
                                                                            model.Country,
                                                                            model.AllAirports);

            var responseModel = suggestions.Select(AirportAutocompleteApiResponseModel.FromModel);

            return responseModel;
        }

        private void Validate(object objToValdiate)
        {
            var context = new ValidationContext(objToValdiate, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(objToValdiate, context, validationResults);

            if (validationResults.Any())
            {
                throw new ValidationException(string.Join("; ", validationResults.Select(x => x.ErrorMessage)));
            }
        }
    }
}
