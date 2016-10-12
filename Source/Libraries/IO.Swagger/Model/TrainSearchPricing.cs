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
    /// TrainSearchPricing
    /// </summary>
    [DataContract]
    public partial class TrainSearchPricing :  IEquatable<TrainSearchPricing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainSearchPricing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrainSearchPricing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainSearchPricing" /> class.
        /// </summary>
        /// <param name="ServiceClass">A standard enumeration of the type of seat, bed or service the passenger can expect. (required).</param>
        /// <param name="BookingCode">A code the identifies the type of booking class being used. (required).</param>
        /// <param name="Accomodation">A standard enumeration of the mode in which the passenger is accommodated. For example&amp;colon; SEAT, BERTH, CABIN, CARGO, UNKNOWN. (required).</param>
        /// <param name="TotalPrice">The total cost of this service. (required).</param>
        /// <param name="Rate">A rate identifying type of charge being levied for this service, and the restrictions that apply. (required).</param>
        public TrainSearchPricing(string ServiceClass = null, string BookingCode = null, string Accomodation = null, Amount TotalPrice = null, RestrictedRate Rate = null)
        {
            // to ensure "ServiceClass" is required (not null)
            if (ServiceClass == null)
            {
                throw new InvalidDataException("ServiceClass is a required property for TrainSearchPricing and cannot be null");
            }
            else
            {
                this.ServiceClass = ServiceClass;
            }
            // to ensure "BookingCode" is required (not null)
            if (BookingCode == null)
            {
                throw new InvalidDataException("BookingCode is a required property for TrainSearchPricing and cannot be null");
            }
            else
            {
                this.BookingCode = BookingCode;
            }
            // to ensure "Accomodation" is required (not null)
            if (Accomodation == null)
            {
                throw new InvalidDataException("Accomodation is a required property for TrainSearchPricing and cannot be null");
            }
            else
            {
                this.Accomodation = Accomodation;
            }
            // to ensure "TotalPrice" is required (not null)
            if (TotalPrice == null)
            {
                throw new InvalidDataException("TotalPrice is a required property for TrainSearchPricing and cannot be null");
            }
            else
            {
                this.TotalPrice = TotalPrice;
            }
            // to ensure "Rate" is required (not null)
            if (Rate == null)
            {
                throw new InvalidDataException("Rate is a required property for TrainSearchPricing and cannot be null");
            }
            else
            {
                this.Rate = Rate;
            }
        }
        
        /// <summary>
        /// A standard enumeration of the type of seat, bed or service the passenger can expect.
        /// </summary>
        /// <value>A standard enumeration of the type of seat, bed or service the passenger can expect.</value>
        [DataMember(Name="service_class", EmitDefaultValue=false)]
        public string ServiceClass { get; set; }
        /// <summary>
        /// A code the identifies the type of booking class being used.
        /// </summary>
        /// <value>A code the identifies the type of booking class being used.</value>
        [DataMember(Name="booking_code", EmitDefaultValue=false)]
        public string BookingCode { get; set; }
        /// <summary>
        /// A standard enumeration of the mode in which the passenger is accommodated. For example&amp;colon; SEAT, BERTH, CABIN, CARGO, UNKNOWN.
        /// </summary>
        /// <value>A standard enumeration of the mode in which the passenger is accommodated. For example&amp;colon; SEAT, BERTH, CABIN, CARGO, UNKNOWN.</value>
        [DataMember(Name="accomodation", EmitDefaultValue=false)]
        public string Accomodation { get; set; }
        /// <summary>
        /// The total cost of this service.
        /// </summary>
        /// <value>The total cost of this service.</value>
        [DataMember(Name="total_price", EmitDefaultValue=false)]
        public Amount TotalPrice { get; set; }
        /// <summary>
        /// A rate identifying type of charge being levied for this service, and the restrictions that apply.
        /// </summary>
        /// <value>A rate identifying type of charge being levied for this service, and the restrictions that apply.</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public RestrictedRate Rate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainSearchPricing {\n");
            sb.Append("  ServiceClass: ").Append(ServiceClass).Append("\n");
            sb.Append("  BookingCode: ").Append(BookingCode).Append("\n");
            sb.Append("  Accomodation: ").Append(Accomodation).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(obj as TrainSearchPricing);
        }

        /// <summary>
        /// Returns true if TrainSearchPricing instances are equal
        /// </summary>
        /// <param name="other">Instance of TrainSearchPricing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrainSearchPricing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceClass == other.ServiceClass ||
                    this.ServiceClass != null &&
                    this.ServiceClass.Equals(other.ServiceClass)
                ) && 
                (
                    this.BookingCode == other.BookingCode ||
                    this.BookingCode != null &&
                    this.BookingCode.Equals(other.BookingCode)
                ) && 
                (
                    this.Accomodation == other.Accomodation ||
                    this.Accomodation != null &&
                    this.Accomodation.Equals(other.Accomodation)
                ) && 
                (
                    this.TotalPrice == other.TotalPrice ||
                    this.TotalPrice != null &&
                    this.TotalPrice.Equals(other.TotalPrice)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
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
                if (this.ServiceClass != null)
                    hash = hash * 59 + this.ServiceClass.GetHashCode();
                if (this.BookingCode != null)
                    hash = hash * 59 + this.BookingCode.GetHashCode();
                if (this.Accomodation != null)
                    hash = hash * 59 + this.Accomodation.GetHashCode();
                if (this.TotalPrice != null)
                    hash = hash * 59 + this.TotalPrice.GetHashCode();
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                return hash;
            }
        }
    }

}
