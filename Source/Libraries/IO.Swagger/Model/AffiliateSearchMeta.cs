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
    /// AffiliateSearchMeta
    /// </summary>
    [DataContract]
    public partial class AffiliateSearchMeta :  IEquatable<AffiliateSearchMeta>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AffiliateSearchMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateSearchMeta" /> class.
        /// </summary>
        /// <param name="Carriers">A map of meta information for each of the airlines involved in the response (required).</param>
        public AffiliateSearchMeta(CarrierMeta Carriers = null)
        {
            // to ensure "Carriers" is required (not null)
            if (Carriers == null)
            {
                throw new InvalidDataException("Carriers is a required property for AffiliateSearchMeta and cannot be null");
            }
            else
            {
                this.Carriers = Carriers;
            }
        }
        
        /// <summary>
        /// A map of meta information for each of the airlines involved in the response
        /// </summary>
        /// <value>A map of meta information for each of the airlines involved in the response</value>
        [DataMember(Name="carriers", EmitDefaultValue=false)]
        public CarrierMeta Carriers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliateSearchMeta {\n");
            sb.Append("  Carriers: ").Append(Carriers).Append("\n");
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
            return this.Equals(obj as AffiliateSearchMeta);
        }

        /// <summary>
        /// Returns true if AffiliateSearchMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of AffiliateSearchMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliateSearchMeta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Carriers == other.Carriers ||
                    this.Carriers != null &&
                    this.Carriers.Equals(other.Carriers)
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
                if (this.Carriers != null)
                    hash = hash * 59 + this.Carriers.GetHashCode();
                return hash;
            }
        }
    }

}
