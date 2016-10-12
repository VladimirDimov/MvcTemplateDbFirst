using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Hosting;

namespace CommonHelpers.AirportsHelper
{
    public class AirportsHelpers
    {
        private static IEnumerable<AirportInfoModel> airportsCollection = null;

        /// <summary>
        /// Returns the full airport name by provided code name. For example: "MAD" => "General Madariaga Airport"
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetNameFromCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentNullException("The airport code name cannot be null or empty.");
            }

            var collection = GetAirportsCollection();
            var concreteAirport = collection.FirstOrDefault(x => x.iata_code.ToUpper() == code.ToUpper());
            if (concreteAirport == null)
            {
                return null;
            }
            return concreteAirport.name;
        }

        /// <summary>
        /// Returns a locally stored collection of all airports in the world.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<AirportInfoModel> GetAirportsCollection()
        {
            if (airportsCollection == null)
            {
                var filePath = HostingEnvironment.MapPath("/App_Data/AppFiles/AirportsInfo.json");
                airportsCollection = JsonProvider.JsonProvider.DeserializeFromFile<IEnumerable<AirportInfoModel>>(filePath);
            }

            return airportsCollection;
        }

        /// <summary>
        /// Gets the code from given full name in the format it is returned by the autocomplete functionality of th Amadeus API. The name must end with [AirportCodeName]
        /// Example: "Sofia Airport [SOF]" => returns: "SOF".
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCodeFromNameOrDefault(string name)
        {
            name = name.Trim();
            var match = Regex.Match(name.Trim(), @"\[(.[A-z]+)\]$");
            if (!match.Success)
            {
                return null;
            }

            var gr = match.Groups[1];

            return gr.Value;
        }

        /// <summary>
        /// Removes the airport code from It's name.
        /// Example: input: "Sofia Airport [SOF]"; output: "Sofia Airport"
        /// </summary>
        /// <param name="airportName">Airport name with the airport code in it</param>
        /// <returns></returns>
        public static string RemoveCodeFromAirportName(string airportName)
        {
            var formattedName = Regex.Replace(airportName, "\\[[^[\\]]*\\]", string.Empty);

            return formattedName;
        }
    }
}
