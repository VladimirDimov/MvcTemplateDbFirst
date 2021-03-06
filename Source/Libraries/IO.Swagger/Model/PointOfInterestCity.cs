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
    /// PointOfInterestCity
    /// </summary>
    [DataContract]
    public partial class PointOfInterestCity :  IEquatable<PointOfInterestCity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointOfInterestCity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PointOfInterestCity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PointOfInterestCity" /> class.
        /// </summary>
        /// <param name="Name">The name of the location that was searched for (required).</param>
        /// <param name="GeonameId">The Geonames ID of the location that was searched for.</param>
        /// <param name="Location">Location (required).</param>
        /// <param name="TotalPointsOfInterest">The total number of points_of_interest that YapQ has indexed for this city (required).</param>
        public PointOfInterestCity(string Name = null, string GeonameId = null, Geolocation Location = null, int? TotalPointsOfInterest = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PointOfInterestCity and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for PointOfInterestCity and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "TotalPointsOfInterest" is required (not null)
            if (TotalPointsOfInterest == null)
            {
                throw new InvalidDataException("TotalPointsOfInterest is a required property for PointOfInterestCity and cannot be null");
            }
            else
            {
                this.TotalPointsOfInterest = TotalPointsOfInterest;
            }
            this.GeonameId = GeonameId;
        }
        
        /// <summary>
        /// The name of the location that was searched for
        /// </summary>
        /// <value>The name of the location that was searched for</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The Geonames ID of the location that was searched for
        /// </summary>
        /// <value>The Geonames ID of the location that was searched for</value>
        [DataMember(Name="geoname_id", EmitDefaultValue=false)]
        public string GeonameId { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Geolocation Location { get; set; }
        /// <summary>
        /// The total number of points_of_interest that YapQ has indexed for this city
        /// </summary>
        /// <value>The total number of points_of_interest that YapQ has indexed for this city</value>
        [DataMember(Name="total_points_of_interest", EmitDefaultValue=false)]
        public int? TotalPointsOfInterest { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PointOfInterestCity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TotalPointsOfInterest: ").Append(TotalPointsOfInterest).Append("\n");
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
            return this.Equals(obj as PointOfInterestCity);
        }

        /// <summary>
        /// Returns true if PointOfInterestCity instances are equal
        /// </summary>
        /// <param name="other">Instance of PointOfInterestCity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PointOfInterestCity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.GeonameId == other.GeonameId ||
                    this.GeonameId != null &&
                    this.GeonameId.Equals(other.GeonameId)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.TotalPointsOfInterest == other.TotalPointsOfInterest ||
                    this.TotalPointsOfInterest != null &&
                    this.TotalPointsOfInterest.Equals(other.TotalPointsOfInterest)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.GeonameId != null)
                    hash = hash * 59 + this.GeonameId.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.TotalPointsOfInterest != null)
                    hash = hash * 59 + this.TotalPointsOfInterest.GetHashCode();
                return hash;
            }
        }
    }

}
