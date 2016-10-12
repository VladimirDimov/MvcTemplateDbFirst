namespace TourPoc.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Filters;
    using Infrastructure.Mapping;
    using Libraries.Providers.Models;
    using Services.Data.Contracts;
    using ViewModels.Flights;

    public class FlightsController : BaseController
    {
        private IFlightServices flightServices;

        public FlightsController(IFlightServices flightServices)
        {
            this.flightServices = flightServices;
        }

        public async Task<ActionResult> Index(AffiliateFlightsSearchModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(nameof(this.Search));
            }

            var responseModel = await this.GetSegments(model);

            var indexViewModel = new IndexViewModel
            {
                AffiliateFlightsSearchModel = model,
                BookingListViewModel = SegmentListViewModel.FromModel(responseModel, model),
                MinPrices = MinPricesViewModel.FromModel(responseModel),
                Airlines = AirlineMinPriceViewModel.FromModel(responseModel),
                Airports = AirportNamesViewModel.FromModel(model)
            };

            return this.View("Index", indexViewModel);
        }

        public ActionResult Search()
        {
            return this.View("Search");
        }

        [ValidateIsAjaxRequest]
        public async Task<ActionResult> AirportsAutocomplete(AirportsAutocompleteRequestModel model)
        {
            var apiRequestModel = this.Mapper.Map<AirportAutocompleteApiRequestModel>(model);
            var suggestedAirports = await this.flightServices.AirportsAutocompleteAsync(apiRequestModel);
            var response = suggestedAirports.AsQueryable().To<AirportAutocompleteViewModel>().ToList();

            return this.Json(response, JsonRequestBehavior.AllowGet);
        }

        private async Task<IEnumerable<SegmentViewModel>> GetSegments(AffiliateFlightsSearchModel model)
        {
            var requestModel = this.Mapper.Map<FlightAffiliateApiRequestModel>(model);
            var response = await this.flightServices.FlightAffiliateSearchAsync(requestModel);
            var responseModel = response.AsQueryable().To<SegmentViewModel>().ToList();

            return responseModel;
        }
    }
}
