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
    /// Fare
    /// </summary>
    [DataContract]
    public partial class Fare :  IEquatable<Fare>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fare" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Fare() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fare" /> class.
        /// </summary>
        /// <param name="TotalFare">The total price, including taxes per-passenger, for this passenger type, for this itinerary. Always a string, formatted correctly for the given currency (required).</param>
        /// <param name="Tax">The tax applied per-passenger, for this passenger type, for this itinerary. Some of this tax may be refundable in the event of cancellation. (required).</param>
        public Fare(string TotalFare = null, string Tax = null)
        {
            // to ensure "TotalFare" is required (not null)
            if (TotalFare == null)
            {
                throw new InvalidDataException("TotalFare is a required property for Fare and cannot be null");
            }
            else
            {
                this.TotalFare = TotalFare;
            }
            // to ensure "Tax" is required (not null)
            if (Tax == null)
            {
                throw new InvalidDataException("Tax is a required property for Fare and cannot be null");
            }
            else
            {
                this.Tax = Tax;
            }
        }
        
        /// <summary>
        /// The total price, including taxes per-passenger, for this passenger type, for this itinerary. Always a string, formatted correctly for the given currency
        /// </summary>
        /// <value>The total price, including taxes per-passenger, for this passenger type, for this itinerary. Always a string, formatted correctly for the given currency</value>
        [DataMember(Name="total_fare", EmitDefaultValue=false)]
        public string TotalFare { get; set; }
        /// <summary>
        /// The tax applied per-passenger, for this passenger type, for this itinerary. Some of this tax may be refundable in the event of cancellation.
        /// </summary>
        /// <value>The tax applied per-passenger, for this passenger type, for this itinerary. Some of this tax may be refundable in the event of cancellation.</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public string Tax { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fare {\n");
            sb.Append("  TotalFare: ").Append(TotalFare).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
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
            return this.Equals(obj as Fare);
        }

        /// <summary>
        /// Returns true if Fare instances are equal
        /// </summary>
        /// <param name="other">Instance of Fare to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fare other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalFare == other.TotalFare ||
                    this.TotalFare != null &&
                    this.TotalFare.Equals(other.TotalFare)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
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
                if (this.TotalFare != null)
                    hash = hash * 59 + this.TotalFare.GetHashCode();
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                return hash;
            }
        }
    }

}