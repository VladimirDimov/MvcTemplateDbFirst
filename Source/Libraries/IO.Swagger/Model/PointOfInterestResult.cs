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
    /// PointOfInterestResult
    /// </summary>
    [DataContract]
    public partial class PointOfInterestResult :  IEquatable<PointOfInterestResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PointOfInterestResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PointOfInterestResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PointOfInterestResult" /> class.
        /// </summary>
        /// <param name="Title">Display name of a given point of interest (required).</param>
        /// <param name="MainImage">A link to an image of the given location (required).</param>
        /// <param name="Location">Location (required).</param>
        /// <param name="Grades">Grades.</param>
        /// <param name="Categories">Array of descriptions indicating what type of point of interest this is. You can filter the results to include only certain categories of point of interest using the category input parameter. (required).</param>
        /// <param name="Details">Details.</param>
        /// <param name="ContextualImages">Images taken at this point of interest. Note that these images might have nothing to do with the point itself, particularly if you have enabled the social_media parameter.</param>
        /// <param name="GeonameId">The GeonamesID of this point of interest, if available.</param>
        /// <param name="WalkTime">Time in minutes that it takes to walk from the searched coordinates to this Point of Interest.</param>
        public PointOfInterestResult(string Title = null, string MainImage = null, Geolocation Location = null, PointOfInterestResultGrades Grades = null, List<string> Categories = null, PointOfInterestDetails Details = null, List<ImageSize> ContextualImages = null, int? GeonameId = null, decimal? WalkTime = null)
        {
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for PointOfInterestResult and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "MainImage" is required (not null)
            if (MainImage == null)
            {
                throw new InvalidDataException("MainImage is a required property for PointOfInterestResult and cannot be null");
            }
            else
            {
                this.MainImage = MainImage;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for PointOfInterestResult and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "Categories" is required (not null)
            if (Categories == null)
            {
                throw new InvalidDataException("Categories is a required property for PointOfInterestResult and cannot be null");
            }
            else
            {
                this.Categories = Categories;
            }
            this.Grades = Grades;
            this.Details = Details;
            this.ContextualImages = ContextualImages;
            this.GeonameId = GeonameId;
            this.WalkTime = WalkTime;
        }
        
        /// <summary>
        /// Display name of a given point of interest
        /// </summary>
        /// <value>Display name of a given point of interest</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// A link to an image of the given location
        /// </summary>
        /// <value>A link to an image of the given location</value>
        [DataMember(Name="main_image", EmitDefaultValue=false)]
        public string MainImage { get; set; }
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public Geolocation Location { get; set; }
        /// <summary>
        /// Gets or Sets Grades
        /// </summary>
        [DataMember(Name="grades", EmitDefaultValue=false)]
        public PointOfInterestResultGrades Grades { get; set; }
        /// <summary>
        /// Array of descriptions indicating what type of point of interest this is. You can filter the results to include only certain categories of point of interest using the category input parameter.
        /// </summary>
        /// <value>Array of descriptions indicating what type of point of interest this is. You can filter the results to include only certain categories of point of interest using the category input parameter.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public PointOfInterestDetails Details { get; set; }
        /// <summary>
        /// Images taken at this point of interest. Note that these images might have nothing to do with the point itself, particularly if you have enabled the social_media parameter
        /// </summary>
        /// <value>Images taken at this point of interest. Note that these images might have nothing to do with the point itself, particularly if you have enabled the social_media parameter</value>
        [DataMember(Name="contextual_images", EmitDefaultValue=false)]
        public List<ImageSize> ContextualImages { get; set; }
        /// <summary>
        /// The GeonamesID of this point of interest, if available
        /// </summary>
        /// <value>The GeonamesID of this point of interest, if available</value>
        [DataMember(Name="geoname_id", EmitDefaultValue=false)]
        public int? GeonameId { get; set; }
        /// <summary>
        /// Time in minutes that it takes to walk from the searched coordinates to this Point of Interest
        /// </summary>
        /// <value>Time in minutes that it takes to walk from the searched coordinates to this Point of Interest</value>
        [DataMember(Name="walk_time", EmitDefaultValue=false)]
        public decimal? WalkTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PointOfInterestResult {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MainImage: ").Append(MainImage).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ContextualImages: ").Append(ContextualImages).Append("\n");
            sb.Append("  GeonameId: ").Append(GeonameId).Append("\n");
            sb.Append("  WalkTime: ").Append(WalkTime).Append("\n");
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
            return this.Equals(obj as PointOfInterestResult);
        }

        /// <summary>
        /// Returns true if PointOfInterestResult instances are equal
        /// </summary>
        /// <param name="other">Instance of PointOfInterestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PointOfInterestResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.MainImage == other.MainImage ||
                    this.MainImage != null &&
                    this.MainImage.Equals(other.MainImage)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Grades == other.Grades ||
                    this.Grades != null &&
                    this.Grades.Equals(other.Grades)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.ContextualImages == other.ContextualImages ||
                    this.ContextualImages != null &&
                    this.ContextualImages.SequenceEqual(other.ContextualImages)
                ) && 
                (
                    this.GeonameId == other.GeonameId ||
                    this.GeonameId != null &&
                    this.GeonameId.Equals(other.GeonameId)
                ) && 
                (
                    this.WalkTime == other.WalkTime ||
                    this.WalkTime != null &&
                    this.WalkTime.Equals(other.WalkTime)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.MainImage != null)
                    hash = hash * 59 + this.MainImage.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Grades != null)
                    hash = hash * 59 + this.Grades.GetHashCode();
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.ContextualImages != null)
                    hash = hash * 59 + this.ContextualImages.GetHashCode();
                if (this.GeonameId != null)
                    hash = hash * 59 + this.GeonameId.GetHashCode();
                if (this.WalkTime != null)
                    hash = hash * 59 + this.WalkTime.GetHashCode();
                return hash;
            }
        }
    }

}
