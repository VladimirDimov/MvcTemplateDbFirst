namespace CommonHelpers.AirlinesHelper
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Hosting;

    public class AirlinesHelper
    {
        private static IEnumerable<AirlineInfoModel> airlinessCache = null;

        /// <summary>
        /// Get all airports from a local json collection.
        /// </summary>
        public static IEnumerable<AirlineInfoModel> GetAllAirports()
        {
            if (airlinessCache == null)
            {
                var filePath = HostingEnvironment.MapPath("/App_Data/AppFiles/AirlinesInfo.json");
                airlinessCache = JsonProvider.JsonProvider.DeserializeFromFile<IEnumerable<AirlineInfoModel>>(filePath);
            }

            return airlinessCache;
        }

        /// <summary>
        /// Retunrs an airport info model with the provieded iata code. Looks inside a local json collection.
        /// </summary>
        public static AirlineInfoModel AirlineInfoModel(string iata)
        {
            var airline = GetAllAirports().FirstOrDefault(a => a.iata.ToUpper() == iata.ToUpper());

            return airline;
        }
    }
}
