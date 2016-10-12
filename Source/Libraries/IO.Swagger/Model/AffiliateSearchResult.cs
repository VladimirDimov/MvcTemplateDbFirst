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
    /// AffiliateSearchResult
    /// </summary>
    [DataContract]
    public partial class AffiliateSearchResult :  IEquatable<AffiliateSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AffiliateSearchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchResult" /> class.
        /// </summary>
        /// <param name="Outbound">The flight from the origin to the destination (required).</param>
        /// <param name="Inbound">The return flight from the destination to the origin.</param>
        /// <param name="Fare">The price and fare information which applies to all itineraries in this response (required).</param>
        /// <param name="Payout">Details of the amount of payout that the affiliate will received per click or if this flight is sold (required).</param>
        /// <param name="Airline">The 2 character alphanumeric &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/Airline_codes\&quot;&gt;IATA airline code&lt;/a&gt; of the airline that is selling this result (required).</param>
        /// <param name="DeepLink">A link to the page from which this result can be purchased from the affiliate (required).</param>
        public AffiliateSearchResult(FlightSearchBound Outbound = null, FlightSearchBound Inbound = null, AffiliateFlightSearchPrice Fare = null, AffiliatePayout Payout = null, string Airline = null, string DeepLink = null)
        {
            // to ensure "Outbound" is required (not null)
            if (Outbound == null)
            {
                throw new InvalidDataException("Outbound is a required property for AffiliateSearchResult and cannot be null");
            }
            else
            {
                this.Outbound = Outbound;
            }
            // to ensure "Fare" is required (not null)
            if (Fare == null)
            {
                throw new InvalidDataException("Fare is a required property for AffiliateSearchResult and cannot be null");
            }
            else
            {
                this.Fare = Fare;
            }
            // to ensure "Payout" is required (not null)
            if (Payout == null)
            {
                throw new InvalidDataException("Payout is a required property for AffiliateSearchResult and cannot be null");
            }
            else
            {
                this.Payout = Payout;
            }
            // to ensure "Airline" is required (not null)
            if (Airline == null)
            {
                throw new InvalidDataException("Airline is a required property for AffiliateSearchResult and cannot be null");
            }
            else
            {
                this.Airline = Airline;
            }
            // to ensure "DeepLink" is required (not null)
            if (DeepLink == null)
            {
                throw new InvalidDataException("DeepLink is a required property for AffiliateSearchResult and cannot be null");
            }
            else
            {
                this.DeepLink = DeepLink;
            }
            this.Inbound = Inbound;
        }
        
        /// <summary>
        /// The flight from the origin to the destination
        /// </summary>
        /// <value>The flight from the origin to the destination</value>
        [DataMember(Name="outbound", EmitDefaultValue=false)]
        public FlightSearchBound Outbound { get; set; }
        /// <summary>
        /// The return flight from the destination to the origin
        /// </summary>
        /// <value>The return flight from the destination to the origin</value>
        [DataMember(Name="inbound", EmitDefaultValue=false)]
        public FlightSearchBound Inbound { get; set; }
        /// <summary>
        /// The price and fare information which applies to all itineraries in this response
        /// </summary>
        /// <value>The price and fare information which applies to all itineraries in this response</value>
        [DataMember(Name="fare", EmitDefaultValue=false)]
        public AffiliateFlightSearchPrice Fare { get; set; }
        /// <summary>
        /// Details of the amount of payout that the affiliate will received per click or if this flight is sold
        /// </summary>
        /// <value>Details of the amount of payout that the affiliate will received per click or if this flight is sold</value>
        [DataMember(Name="payout", EmitDefaultValue=false)]
        public AffiliatePayout Payout { get; set; }
        /// <summary>
        /// The 2 character alphanumeric &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/Airline_codes\&quot;&gt;IATA airline code&lt;/a&gt; of the airline that is selling this result
        /// </summary>
        /// <value>The 2 character alphanumeric &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/Airline_codes\&quot;&gt;IATA airline code&lt;/a&gt; of the airline that is selling this result</value>
        [DataMember(Name="airline", EmitDefaultValue=false)]
        public string Airline { get; set; }
        /// <summary>
        /// A link to the page from which this result can be purchased from the affiliate
        /// </summary>
        /// <value>A link to the page from which this result can be purchased from the affiliate</value>
        [DataMember(Name="deep_link", EmitDefaultValue=false)]
        public string DeepLink { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateSearchResult {\n");
            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  Fare: ").Append(Fare).Append("\n");
            sb.Append("  Payout: ").Append(Payout).Append("\n");
            sb.Append("  Airline: ").Append(Airline).Append("\n");
            sb.Append("  DeepLink: ").Append(DeepLink).Append("\n");
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
            return this.Equals(obj as AffiliateSearchResult);
        }

        /// <summary>
        /// Returns true if AffiliateSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AffiliateSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Outbound == other.Outbound ||
                    this.Outbound != null &&
                    this.Outbound.Equals(other.Outbound)
                ) && 
                (
                    this.Inbound == other.Inbound ||
                    this.Inbound != null &&
                    this.Inbound.Equals(other.Inbound)
                ) && 
                (
                    this.Fare == other.Fare ||
                    this.Fare != null &&
                    this.Fare.Equals(other.Fare)
                ) && 
                (
                    this.Payout == other.Payout ||
                    this.Payout != null &&
                    this.Payout.Equals(other.Payout)
                ) && 
                (
                    this.Airline == other.Airline ||
                    this.Airline != null &&
                    this.Airline.Equals(other.Airline)
                ) && 
                (
                    this.DeepLink == other.DeepLink ||
                    this.DeepLink != null &&
                    this.DeepLink.Equals(other.DeepLink)
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
                if (this.Outbound != null)
                    hash = hash * 59 + this.Outbound.GetHashCode();
                if (this.Inbound != null)
                    hash = hash * 59 + this.Inbound.GetHashCode();
                if (this.Fare != null)
                    hash = hash * 59 + this.Fare.GetHashCode();
                if (this.Payout != null)
                    hash = hash * 59 + this.Payout.GetHashCode();
                if (this.Airline != null)
                    hash = hash * 59 + this.Airline.GetHashCode();
                if (this.DeepLink != null)
                    hash = hash * 59 + this.DeepLink.GetHashCode();
                return hash;
            }
        }
    }

}
