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
    /// AirportAutocompleteResponse
    /// </summary>
    [DataContract]
    public partial class AirportAutocompleteResponse :  IEquatable<AirportAutocompleteResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AirportAutocompleteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirportAutocompleteResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirportAutocompleteResponse" /> class.
        /// </summary>
        /// <param name="Value">The 3 letter IATA location code of the given city or airport. You can use this as an input parameter for a flight low-fare or inspiration search. (required).</param>
        /// <param name="Label">The name of this airport, in UTF-8 format, prefixed with the name of the city if it is not already incorporated in the name of the airport, and appended with the location&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (as in value), enclosed in square brackets. (required).</param>
        public AirportAutocompleteResponse(string Value = null, string Label = null)
        {
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for AirportAutocompleteResponse and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for AirportAutocompleteResponse and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
        }
        
        /// <summary>
        /// The 3 letter IATA location code of the given city or airport. You can use this as an input parameter for a flight low-fare or inspiration search.
        /// </summary>
        /// <value>The 3 letter IATA location code of the given city or airport. You can use this as an input parameter for a flight low-fare or inspiration search.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// The name of this airport, in UTF-8 format, prefixed with the name of the city if it is not already incorporated in the name of the airport, and appended with the location&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (as in value), enclosed in square brackets.
        /// </summary>
        /// <value>The name of this airport, in UTF-8 format, prefixed with the name of the city if it is not already incorporated in the name of the airport, and appended with the location&#39;s &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/International_Air_Transport_Association_airport_code\&quot;&gt;IATA code&lt;/a&gt; (as in value), enclosed in square brackets.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirportAutocompleteResponse {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(obj as AirportAutocompleteResponse);
        }

        /// <summary>
        /// Returns true if AirportAutocompleteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AirportAutocompleteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirportAutocompleteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                return hash;
            }
        }
    }

}