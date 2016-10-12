namespace Libraries.Providers.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CommonHelpers.AirportsHelper;
    using IO.Swagger.Model;

    public class FlightAffiliateSearchApiResponseModel
    {
        public static Func<AffiliateSearchResult, AffiliateSearchMeta, FlightAffiliateSearchApiResponseModel> FromModel
        {
            get
            {
                return (res, met) => new FlightAffiliateSearchApiResponseModel
                {
                    Airline = res.Airline,
                    LogoMedium = met.Carriers[res.Airline].Logos.Medium,
                    LogoSmall = met.Carriers[res.Airline].Logos.Small,
                    TotalPrice = res.Fare.TotalPrice,
                    DurationHours = int.Parse(res.Outbound.Duration.Split(':')[0]),
                    DurationMinutes = int.Parse(res.Outbound.Duration.Split(':')[1]),
                    Currency = res.Fare.Currency,
                    Flights = res.Outbound.Flights.Select(FlightAffiliateApiResponseModel.FromModel)
                };
            }
        }

        public string Airline { get; private set; }

        public string LogoMedium { get; private set; }

        public string LogoSmall { get; private set; }

        public string TotalPrice { get; private set; }

        public int DurationHours { get; private set; }

        public int DurationMinutes { get; private set; }

        public string Currency { get; private set; }

        public IEnumerable<FlightAffiliateApiResponseModel> Flights { get; set; }
    }
}
