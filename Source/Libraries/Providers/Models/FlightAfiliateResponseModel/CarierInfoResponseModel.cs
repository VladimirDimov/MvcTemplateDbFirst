namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    using System;
    using IO.Swagger.Model;

    public class CarierInfoResponseModel
    {
        public LogosResponseModel Logos { get; set; }

        public string Name { get; set; }

        public static Func<CarrierInfo, CarierInfoResponseModel> FromModel
        {
            get
            {
                return m => new CarierInfoResponseModel
                {
                    Name = m.Name,
                    Logos = new LogosResponseModel
                    {
                        Medium = m.Logos.Medium,
                        Small = m.Logos.Small
                    }
                };
            }
        }
    }
}
