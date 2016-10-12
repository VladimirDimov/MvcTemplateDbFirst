namespace TourPoc.Web.ViewModels.Flights
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using CommonHelpers.AirportsHelper;
    using Infrastructure.Mapping;
    using Libraries.Providers.Models;

    public class AffiliateFlightsSearchModel : IMapTo<FlightAffiliateApiRequestModel>, IHaveCustomMappings, IValidatableObject
    {
        public int? Adults { get; set; }

        public int? Children { get; set; }

        public string Currency { get; set; }

        public DateTime DepartureDate { get; set; }

        [Required]
        public string Origin { get; set; }

        public string OriginOneWay { get; set; }

        [Required]
        public string Destination { get; set; }

        public List<string> ExcludeMerchants { get; set; }

        public List<string> IncludeMerchants { get; set; }

        public bool IncludeNoStop { get; set; }

        public bool IncludeOneStop { get; set; }

        public bool IncludeManyStops { get; set; }

        public int? Infants { get; set; }

        public int? MaxPrice { get; set; }

        public bool? Mobile { get; set; }

        public DateTime? ReturnDate { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<AffiliateFlightsSearchModel, FlightAffiliateApiRequestModel>()
                .ForMember(x => x.Origin, opt => opt.MapFrom(x => AirportsHelpers.GetCodeFromNameOrDefault(x.Origin)))
                .ForMember(x => x.Destination, opt => opt.MapFrom(x => AirportsHelpers.GetCodeFromNameOrDefault(x.Destination)));
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validationResults = new List<ValidationResult>();
            if (this.Origin == null && this.OriginOneWay == null)
            {
                validationResults.Add(new ValidationResult("The origin field is required!"));
            }

            if (this.Origin != null && this.Destination == null)
            {
                validationResults.Add(new ValidationResult("The destination field is required!"));
            }

            return validationResults;
        }
    }
}
