/* 
 * Amadeus Travel Innovation Sandbox
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// LowFareSearchResult
    /// </summary>
    [DataContract]
    public partial class LowFareSearchResult :  IEquatable<LowFareSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LowFareSearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LowFareSearchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LowFareSearchResult" /> class.
        /// </summary>
        /// <param name="Itineraries">Itineraries.</param>
        /// <param name="Fare">The price and fare information which applies to all itineraries in this response (required).</param>
        public LowFareSearchResult(List<FlightSearchItinerary> Itineraries = null, FlightSearchPrice Fare = null)
        {
            // to ensure "Fare" is required (not null)
            if (Fare == null)
            {
                throw new InvalidDataException("Fare is a required property for LowFareSearchResult and cannot be null");
            }
            else
            {
                this.Fare = Fare;
            }
            this.Itineraries = Itineraries;
        }
        
        /// <summary>
        /// Gets or Sets Itineraries
        /// </summary>
        [DataMember(Name="itineraries", EmitDefaultValue=false)]
        public List<FlightSearchItinerary> Itineraries { get; set; }
        /// <summary>
        /// The price and fare information which applies to all itineraries in this response
        /// </summary>
        /// <value>The price and fare information which applies to all itineraries in this response</value>
        [DataMember(Name="fare", EmitDefaultValue=false)]
        public FlightSearchPrice Fare { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LowFareSearchResult {\n");
            sb.Append("  Itineraries: ").Append(Itineraries).Append("\n");
            sb.Append("  Fare: ").Append(Fare).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LowFareSearchResult);
        }

        /// <summary>
        /// Returns true if LowFareSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of LowFareSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LowFareSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Itineraries == other.Itineraries ||
                    this.Itineraries != null &&
                    this.Itineraries.SequenceEqual(other.Itineraries)
                ) && 
                (
                    this.Fare == other.Fare ||
                    this.Fare != null &&
                    this.Fare.Equals(other.Fare)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Itineraries != null)
                    hash = hash * 59 + this.Itineraries.GetHashCode();
                if (this.Fare != null)
                    hash = hash * 59 + this.Fare.GetHashCode();
                return hash;
            }
        }
    }

}
