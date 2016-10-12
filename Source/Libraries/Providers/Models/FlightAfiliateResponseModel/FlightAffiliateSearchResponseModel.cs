namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    using System.Collections.Generic;

    public class FlightAffiliateSearchResponseModel
    {
        public IEnumerable<ResultsResponseModel> Results { get; set; }

        public IEnumerable<CarierInfoResponseModel> Carriers { get; set; }
    }
}
