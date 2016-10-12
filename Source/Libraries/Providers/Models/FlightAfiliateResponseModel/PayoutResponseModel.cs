namespace Libraries.Providers.Models.FlightAfiliateResponseModel
{
    public class PayoutResponseModel
    {
        public AmountResponseModel CPA { get; internal set; }

        public AmountResponseModel CPC { get; internal set; }

        public AmountResponseModel CPS { get; internal set; }
    }
}
