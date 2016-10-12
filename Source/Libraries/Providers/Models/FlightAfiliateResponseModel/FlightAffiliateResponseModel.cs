using System;
using System.Linq;
using IO.Swagger.Model;

namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    public class ResultsResponseModel
    {
        public string Airline { get; internal set; }

        public FlightSearchBoundResponseModel Inbound { get; internal set; }

        public FlightSearchBoundResponseModel Outbound { get; internal set; }

        public PayoutResponseModel Payout { get; set; }

        /// <summary>
        /// Gets the response from the Third Party API and maps it to the custom response model
        /// </summary>
        public static Func<AffiliateSearchResult, ResultsResponseModel> FromModel
        {
            get
            {
                return responseResult => new ResultsResponseModel
                {
                    Airline = responseResult?.Airline,
                    Inbound = new FlightSearchBoundResponseModel
                    {

                    },
                    Outbound = new FlightSearchBoundResponseModel
                    {
                        Duration = responseResult.Outbound.Duration,
                        Flights = responseResult.Outbound.Flights.Select(x => new FlightSearchSegmentResponseModel
                        {
                            Aircraft = x.Aircraft,
                            ArrivesAt = x.ArrivesAt,
                            BookingInfo = x.BookingInfo,
                            DepartsAt = x.DepartsAt,
                            Destination = new AirportResponseModel
                            {
                                Terminal = x.Destination.Terminal,
                                _Airport = x.Destination.Terminal
                            },
                            FlightNumber = x.FlightNumber,
                            MarketingAirline = x.MarketingAirline,
                            OperatingAirline = x.OperatingAirline,
                            Origin = new AirportResponseModel
                            {
                                Terminal = x.Origin.Terminal,
                                _Airport = x.Origin._Airport
                            }
                        })

                    },
                    Payout = new PayoutResponseModel
                    {
                        CPA = new AmountResponseModel
                        {
                            Currency = responseResult?.Payout?.CPA?.Currency,
                            Amount = responseResult?.Payout?.CPA?._Amount,
                        },
                        CPS = new AmountResponseModel
                        {
                            Currency = responseResult?.Payout?.CPS?.Currency,
                            Amount = responseResult?.Payout?.CPS?._Amount,
                        },
                        CPC = new AmountResponseModel
                        {
                            Currency = responseResult?.Payout?.CPC?.Currency,
                            Amount = responseResult?.Payout?.CPC?._Amount
                        }
                    }
                };
            }
        }
    }
}
