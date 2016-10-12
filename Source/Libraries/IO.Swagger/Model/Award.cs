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
    /// Award
    /// </summary>
    [DataContract]
    public partial class Award :  IEquatable<Award>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Award" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Award() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Award" /> class.
        /// </summary>
        /// <param name="Provider">The organization that issued the award. For example&amp;colon;. Local Star Rating, AAA. (required).</param>
        /// <param name="Rating">The level of the award that was awarded on the provider&#39;s scale. For example&amp;colon; 4 or RECOMMENDED. (required).</param>
        public Award(string Provider = null, string Rating = null)
        {
            // to ensure "Provider" is required (not null)
            if (Provider == null)
            {
                throw new InvalidDataException("Provider is a required property for Award and cannot be null");
            }
            else
            {
                this.Provider = Provider;
            }
            // to ensure "Rating" is required (not null)
            if (Rating == null)
            {
                throw new InvalidDataException("Rating is a required property for Award and cannot be null");
            }
            else
            {
                this.Rating = Rating;
            }
        }
        
        /// <summary>
        /// The organization that issued the award. For example&amp;colon;. Local Star Rating, AAA.
        /// </summary>
        /// <value>The organization that issued the award. For example&amp;colon;. Local Star Rating, AAA.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
        /// <summary>
        /// The level of the award that was awarded on the provider&#39;s scale. For example&amp;colon; 4 or RECOMMENDED.
        /// </summary>
        /// <value>The level of the award that was awarded on the provider&#39;s scale. For example&amp;colon; 4 or RECOMMENDED.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public string Rating { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Award {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(obj as Award);
        }

        /// <summary>
        /// Returns true if Award instances are equal
        /// </summary>
        /// <param name="other">Instance of Award to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Award other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) && 
                (
                    this.Rating == other.Rating ||
                    this.Rating != null &&
                    this.Rating.Equals(other.Rating)
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
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.Rating != null)
                    hash = hash * 59 + this.Rating.GetHashCode();
                return hash;
            }
        }
    }

}
