namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinPricesViewModel
    {
        public static Func<IEnumerable<SegmentViewModel>, MinPricesViewModel> FromModel
        {
            get
            {
                return m =>
                {
                    if (m.Count() == 0)
                    {
                        return new MinPricesViewModel
                        {
                            NonStopMinValue = 0,
                            OneStopMinValue = 0,
                            ManyStopsMinValue = 0,
                        };
                    }

                    var nonStops = m.Where(x => x.Flights.Count() == 1);
                    var oneStops = m.Where(x => x.Flights.Count() == 2);
                    var manyStops = m.Where(x => x.Flights.Count() > 2);

                    return new MinPricesViewModel
                    {
                        NonStopMinValue = nonStops.Any() ? m.Where(x => x.Flights.Count() == 1).Min(x => x.TotalPrice) : 0,
                        OneStopMinValue = oneStops.Any() ? m.Where(x => x.Flights.Count() == 2).Min(x => x.TotalPrice) : 0,
                        ManyStopsMinValue = manyStops.Any() ? m.Where(x => x.Flights.Count() > 2).Min(x => x.TotalPrice) : 0,
                    };
                };
            }
        }

        public decimal NonStopMinValue { get; set; }

        public decimal OneStopMinValue { get; set; }

        public decimal ManyStopsMinValue { get; set; }
    }
}
