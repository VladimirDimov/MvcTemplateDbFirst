namespace TourPoc.Web.ViewModels.Flights
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public SegmentListViewModel BookingListViewModel { get; set; }

        public AffiliateFlightsSearchModel AffiliateFlightsSearchModel { get; set; }

        public MinPricesViewModel MinPrices { get; set; }

        public IEnumerable<AirlineMinPriceViewModel> Airlines { get; set; }

        public AirportNamesViewModel Airports { get; set; }
    }
}
