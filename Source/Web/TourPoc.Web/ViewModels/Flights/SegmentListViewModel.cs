namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;

    public class SegmentListViewModel
    {
        public static Func<IEnumerable<SegmentViewModel>, AffiliateFlightsSearchModel, SegmentListViewModel> FromModel
        {
            get
            {
                return (segment, searchModel) =>
                {
                    return new SegmentListViewModel
                    {
                        AdulstNumber = searchModel.Adults ?? 1, // If no number of adults is provided the default value is 1
                        Segments = segment
                    };
                };
            }
        }

        public int AdulstNumber { get; set; }

        public IEnumerable<SegmentViewModel> Segments { get; set; }
    }
}
