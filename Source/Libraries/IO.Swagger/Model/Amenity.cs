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
    /// Amenity
    /// </summary>
    [DataContract]
    public partial class Amenity :  IEquatable<Amenity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amenity" /> class.
        /// </summary>
        /// <param name="_Amenity">&lt;a href&#x3D;\&quot;hotels-api-supported-amenities-filter\&quot;&gt;The amenity code&lt;/a&gt;.</param>
        /// <param name="OtaCode">The &lt;a href&#x3D;\&quot;http://www.opentravel.org/\&quot;&gt;Open Travel Alliance&lt;/a&gt; &lt;a href&#x3D;\&quot;ota-hotel-amenity-code-table\&quot;&gt;Hotel Amenities Code&lt;/a&gt; for this amenity..</param>
        /// <param name="Description">The decoded text description for this amenity code, where available..</param>
        public Amenity(string _Amenity = null, string OtaCode = null, string Description = null)
        {
            this._Amenity = _Amenity;
            this.OtaCode = OtaCode;
            this.Description = Description;
        }
        
        /// <summary>
        /// &lt;a href&#x3D;\&quot;hotels-api-supported-amenities-filter\&quot;&gt;The amenity code&lt;/a&gt;
        /// </summary>
        /// <value>&lt;a href&#x3D;\&quot;hotels-api-supported-amenities-filter\&quot;&gt;The amenity code&lt;/a&gt;</value>
        [DataMember(Name="amenity", EmitDefaultValue=false)]
        public string _Amenity { get; set; }
        /// <summary>
        /// The &lt;a href&#x3D;\&quot;http://www.opentravel.org/\&quot;&gt;Open Travel Alliance&lt;/a&gt; &lt;a href&#x3D;\&quot;ota-hotel-amenity-code-table\&quot;&gt;Hotel Amenities Code&lt;/a&gt; for this amenity.
        /// </summary>
        /// <value>The &lt;a href&#x3D;\&quot;http://www.opentravel.org/\&quot;&gt;Open Travel Alliance&lt;/a&gt; &lt;a href&#x3D;\&quot;ota-hotel-amenity-code-table\&quot;&gt;Hotel Amenities Code&lt;/a&gt; for this amenity.</value>
        [DataMember(Name="ota_code", EmitDefaultValue=false)]
        public string OtaCode { get; set; }
        /// <summary>
        /// The decoded text description for this amenity code, where available.
        /// </summary>
        /// <value>The decoded text description for this amenity code, where available.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Amenity {\n");
            sb.Append("  _Amenity: ").Append(_Amenity).Append("\n");
            sb.Append("  OtaCode: ").Append(OtaCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as Amenity);
        }

        /// <summary>
        /// Returns true if Amenity instances are equal
        /// </summary>
        /// <param name="other">Instance of Amenity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Amenity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Amenity == other._Amenity ||
                    this._Amenity != null &&
                    this._Amenity.Equals(other._Amenity)
                ) && 
                (
                    this.OtaCode == other.OtaCode ||
                    this.OtaCode != null &&
                    this.OtaCode.Equals(other.OtaCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this._Amenity != null)
                    hash = hash * 59 + this._Amenity.GetHashCode();
                if (this.OtaCode != null)
                    hash = hash * 59 + this.OtaCode.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }
    }

}
