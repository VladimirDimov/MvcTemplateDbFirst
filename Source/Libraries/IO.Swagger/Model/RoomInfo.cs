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
    /// More detailed structured information about the room.
    /// </summary>
    [DataContract]
    public partial class RoomInfo :  IEquatable<RoomInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomInfo" /> class.
        /// </summary>
        /// <param name="BedType">The type of bed or beds in the room, such as Double, or King. (required).</param>
        /// <param name="NumberOfBeds">The number of beds in the room. May be an integer or a free-text dessciption, as provided by the hotel (required).</param>
        /// <param name="RoomType">Free-text indicating the type of room - such Smoking, No Smoking, Suite, etc.. (required).</param>
        public RoomInfo(string BedType = null, string NumberOfBeds = null, string RoomType = null)
        {
            // to ensure "BedType" is required (not null)
            if (BedType == null)
            {
                throw new InvalidDataException("BedType is a required property for RoomInfo and cannot be null");
            }
            else
            {
                this.BedType = BedType;
            }
            // to ensure "NumberOfBeds" is required (not null)
            if (NumberOfBeds == null)
            {
                throw new InvalidDataException("NumberOfBeds is a required property for RoomInfo and cannot be null");
            }
            else
            {
                this.NumberOfBeds = NumberOfBeds;
            }
            // to ensure "RoomType" is required (not null)
            if (RoomType == null)
            {
                throw new InvalidDataException("RoomType is a required property for RoomInfo and cannot be null");
            }
            else
            {
                this.RoomType = RoomType;
            }
        }
        
        /// <summary>
        /// The type of bed or beds in the room, such as Double, or King.
        /// </summary>
        /// <value>The type of bed or beds in the room, such as Double, or King.</value>
        [DataMember(Name="bed_type", EmitDefaultValue=false)]
        public string BedType { get; set; }
        /// <summary>
        /// The number of beds in the room. May be an integer or a free-text dessciption, as provided by the hotel
        /// </summary>
        /// <value>The number of beds in the room. May be an integer or a free-text dessciption, as provided by the hotel</value>
        [DataMember(Name="number_of_beds", EmitDefaultValue=false)]
        public string NumberOfBeds { get; set; }
        /// <summary>
        /// Free-text indicating the type of room - such Smoking, No Smoking, Suite, etc..
        /// </summary>
        /// <value>Free-text indicating the type of room - such Smoking, No Smoking, Suite, etc..</value>
        [DataMember(Name="room_type", EmitDefaultValue=false)]
        public string RoomType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomInfo {\n");
            sb.Append("  BedType: ").Append(BedType).Append("\n");
            sb.Append("  NumberOfBeds: ").Append(NumberOfBeds).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
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
            return this.Equals(obj as RoomInfo);
        }

        /// <summary>
        /// Returns true if RoomInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BedType == other.BedType ||
                    this.BedType != null &&
                    this.BedType.Equals(other.BedType)
                ) && 
                (
                    this.NumberOfBeds == other.NumberOfBeds ||
                    this.NumberOfBeds != null &&
                    this.NumberOfBeds.Equals(other.NumberOfBeds)
                ) && 
                (
                    this.RoomType == other.RoomType ||
                    this.RoomType != null &&
                    this.RoomType.Equals(other.RoomType)
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
                if (this.BedType != null)
                    hash = hash * 59 + this.BedType.GetHashCode();
                if (this.NumberOfBeds != null)
                    hash = hash * 59 + this.NumberOfBeds.GetHashCode();
                if (this.RoomType != null)
                    hash = hash * 59 + this.RoomType.GetHashCode();
                return hash;
            }
        }
    }

}
