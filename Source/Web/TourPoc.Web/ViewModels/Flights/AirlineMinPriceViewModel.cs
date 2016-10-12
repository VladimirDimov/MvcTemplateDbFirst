namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AirlineMinPriceViewModel
    {
        public static Func<IEnumerable<SegmentViewModel>, IEnumerable<AirlineMinPriceViewModel>> FromModel
        {
            get
            {
                return m =>
                {
                    var groupsByAirline = m.GroupBy(x => x.Airline);

                    return groupsByAirline.Select(x => new AirlineMinPriceViewModel
                    {
                        Name = x.Key,
                        MinPrice = x.Min(y => y.TotalPrice)
                    });
                };
            }
        }

        public string Name { get; set; }

        public decimal MinPrice { get; set; }
    }
}
