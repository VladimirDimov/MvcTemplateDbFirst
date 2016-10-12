namespace Libraries.Providers.Models
{
    using System;
    using IO.Swagger.Model;

    public class AirportAutocompleteApiResponseModel
    {
        public static Func<AirportAutocompleteResponse, AirportAutocompleteApiResponseModel> FromModel
        {
            get
            {
                return m => new AirportAutocompleteApiResponseModel
                {
                    Label = m.Label,
                    Value = m.Value,
                };
            }
        }

        public string Label { get; private set; }

        public string Value { get; private set; }
    }
}
