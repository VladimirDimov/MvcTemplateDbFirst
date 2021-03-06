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
    /// FlightTrafficSearchResponse
    /// </summary>
    [DataContract]
    public partial class FlightTrafficSearchResponse :  IEquatable<FlightTrafficSearchResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightTrafficSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlightTrafficSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightTrafficSearchResponse" /> class.
        /// </summary>
        /// <param name="Period">The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY (required).</param>
        /// <param name="Origin">&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (required).</param>
        /// <param name="Results">Results (required).</param>
        public FlightTrafficSearchResponse(string Period = null, string Origin = null, List<FlightTrafficSearchResult> Results = null)
        {
            // to ensure "Period" is required (not null)
            if (Period == null)
            {
                throw new InvalidDataException("Period is a required property for FlightTrafficSearchResponse and cannot be null");
            }
            else
            {
                this.Period = Period;
            }
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for FlightTrafficSearchResponse and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            // to ensure "Results" is required (not null)
            if (Results == null)
            {
                throw new InvalidDataException("Results is a required property for FlightTrafficSearchResponse and cannot be null");
            }
            else
            {
                this.Results = Results;
            }
        }
        
        /// <summary>
        /// The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY
        /// </summary>
        /// <value>The date period, in &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date format YYYY-MM or YYYY</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }
        /// <summary>
        /// &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;
        /// </summary>
        /// <value>&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt;</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<FlightTrafficSearchResult> Results { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightTrafficSearchResponse {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as FlightTrafficSearchResponse);
        }

        /// <summary>
        /// Returns true if FlightTrafficSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FlightTrafficSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightTrafficSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                return hash;
            }
        }
    }

}
