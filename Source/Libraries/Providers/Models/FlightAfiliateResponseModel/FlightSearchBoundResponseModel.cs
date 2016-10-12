namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FlightSearchBoundResponseModel
    {
        public IEnumerable<FlightSearchSegmentResponseModel> Flights { get; set; }

        public string Duration { get; set; }
    }
}
