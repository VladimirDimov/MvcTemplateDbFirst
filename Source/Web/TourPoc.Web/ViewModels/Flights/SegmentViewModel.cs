namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using AutoMapper;
    using CommonHelpers.AirlinesHelper;
    using CommonHelpers.CurrencyHelper;
    using Infrastructure.Mapping;
    using Libraries.Providers.Models;

    public class SegmentViewModel : IMapFrom<FlightAffiliateSearchApiResponseModel>, IHaveCustomMappings
    {
        public string Airline { get; private set; }

        public string LogoMedium { get; private set; }

        public string LogoSmall { get; private set; }

        public decimal TotalPrice { get; private set; }

        public int DurationHours { get; private set; }

        public int DurationMinutes { get; private set; }

        public string CurrencySymbol { get; set; }

        public IEnumerable<SegmentFlightViewModel> Flights { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<FlightAffiliateSearchApiResponseModel, SegmentViewModel>()
                .ForMember(x => x.CurrencySymbol, opt => opt.MapFrom(x => CurrencyHelpers.GetCurrencySymbol(x.Currency)))
                .ForMember(x => x.Flights, opt => opt.MapFrom(x => x.Flights.AsQueryable().To<SegmentFlightViewModel>().ToList()))
                .ForMember(x => x.TotalPrice, opt => opt.MapFrom(x => decimal.Parse(x.TotalPrice)))
                .ForMember(x => x.Airline, opt => opt.MapFrom(x => AirlinesHelper.AirlineInfoModel(x.Airline.ToUpper()).name));
        }
    }
}
