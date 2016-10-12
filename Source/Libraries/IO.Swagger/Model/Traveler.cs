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
    /// Traveler
    /// </summary>
    [DataContract]
    public partial class Traveler :  IEquatable<Traveler>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Traveler" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Traveler() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Traveler" /> class.
        /// </summary>
        /// <param name="Id">Uniquely identifies this traveler in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record. (required).</param>
        /// <param name="LastName">The last name of the passenger, as entered by the agent, in upper-case. May include suffixes. For example&amp;colon; THACKSTON, KING III, LU. (required).</param>
        /// <param name="FirstName">The first name of the passenger, as entered by the agent, in upper-case. May include middle names, initials or prefixes. The total combined length of the first name and last name must be between 2 and 57 characters. For example&amp;colon; ALEXANDRA, JOSE-ANTONIO MR, ELAINE T DR. (required).</param>
        /// <param name="TravelerType">Enumeration of the type of traveler. May be ADULT or CHILD. (required).</param>
        /// <param name="Infant">Details on any infant that may be sharing this seat with this traveler. Absence of this key indicates that no infant is traveling with this passenger. An empty object at this key indicated an anonymous infant is traveling with the passenger..</param>
        /// <param name="DateOfBirth">An &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date indicating the birth date of the traveler, as provided by the agent. For example&amp;colon; 1972-02-19..</param>
        /// <param name="Contacts">Details on how to contact this traveler. At least one traveler in a travel-record will have a contact element..</param>
        /// <param name="FrequentTravelerCards">Information regarding loyalty cards that the traveler would like to use to accrue benefits as part of this travel record. Where possible, the system will attempt to validate that the frequent traveler card is eligible for use in the context of this travel record..</param>
        public Traveler(string Id = null, string LastName = null, string FirstName = null, string TravelerType = null, Infant Infant = null, DateTime? DateOfBirth = null, List<Contact> Contacts = null, List<FrequentTravelerCard> FrequentTravelerCards = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Traveler and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Traveler and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Traveler and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "TravelerType" is required (not null)
            if (TravelerType == null)
            {
                throw new InvalidDataException("TravelerType is a required property for Traveler and cannot be null");
            }
            else
            {
                this.TravelerType = TravelerType;
            }
            this.Infant = Infant;
            this.DateOfBirth = DateOfBirth;
            this.Contacts = Contacts;
            this.FrequentTravelerCards = FrequentTravelerCards;
        }
        
        /// <summary>
        /// Uniquely identifies this traveler in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record.
        /// </summary>
        /// <value>Uniquely identifies this traveler in this travel record. This ID is persistent, and remains the same for the lifetime of the travel record.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The last name of the passenger, as entered by the agent, in upper-case. May include suffixes. For example&amp;colon; THACKSTON, KING III, LU.
        /// </summary>
        /// <value>The last name of the passenger, as entered by the agent, in upper-case. May include suffixes. For example&amp;colon; THACKSTON, KING III, LU.</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// The first name of the passenger, as entered by the agent, in upper-case. May include middle names, initials or prefixes. The total combined length of the first name and last name must be between 2 and 57 characters. For example&amp;colon; ALEXANDRA, JOSE-ANTONIO MR, ELAINE T DR.
        /// </summary>
        /// <value>The first name of the passenger, as entered by the agent, in upper-case. May include middle names, initials or prefixes. The total combined length of the first name and last name must be between 2 and 57 characters. For example&amp;colon; ALEXANDRA, JOSE-ANTONIO MR, ELAINE T DR.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Enumeration of the type of traveler. May be ADULT or CHILD.
        /// </summary>
        /// <value>Enumeration of the type of traveler. May be ADULT or CHILD.</value>
        [DataMember(Name="traveler_type", EmitDefaultValue=false)]
        public string TravelerType { get; set; }
        /// <summary>
        /// Details on any infant that may be sharing this seat with this traveler. Absence of this key indicates that no infant is traveling with this passenger. An empty object at this key indicated an anonymous infant is traveling with the passenger.
        /// </summary>
        /// <value>Details on any infant that may be sharing this seat with this traveler. Absence of this key indicates that no infant is traveling with this passenger. An empty object at this key indicated an anonymous infant is traveling with the passenger.</value>
        [DataMember(Name="infant", EmitDefaultValue=false)]
        public Infant Infant { get; set; }
        /// <summary>
        /// An &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date indicating the birth date of the traveler, as provided by the agent. For example&amp;colon; 1972-02-19.
        /// </summary>
        /// <value>An &lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_8601\&quot;&gt;ISO 8601&lt;/a&gt; date indicating the birth date of the traveler, as provided by the agent. For example&amp;colon; 1972-02-19.</value>
        [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Details on how to contact this traveler. At least one traveler in a travel-record will have a contact element.
        /// </summary>
        /// <value>Details on how to contact this traveler. At least one traveler in a travel-record will have a contact element.</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<Contact> Contacts { get; set; }
        /// <summary>
        /// Information regarding loyalty cards that the traveler would like to use to accrue benefits as part of this travel record. Where possible, the system will attempt to validate that the frequent traveler card is eligible for use in the context of this travel record.
        /// </summary>
        /// <value>Information regarding loyalty cards that the traveler would like to use to accrue benefits as part of this travel record. Where possible, the system will attempt to validate that the frequent traveler card is eligible for use in the context of this travel record.</value>
        [DataMember(Name="frequent_traveler_cards", EmitDefaultValue=false)]
        public List<FrequentTravelerCard> FrequentTravelerCards { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Traveler {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  TravelerType: ").Append(TravelerType).Append("\n");
            sb.Append("  Infant: ").Append(Infant).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  FrequentTravelerCards: ").Append(FrequentTravelerCards).Append("\n");
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
            return this.Equals(obj as Traveler);
        }

        /// <summary>
        /// Returns true if Traveler instances are equal
        /// </summary>
        /// <param name="other">Instance of Traveler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Traveler other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.TravelerType == other.TravelerType ||
                    this.TravelerType != null &&
                    this.TravelerType.Equals(other.TravelerType)
                ) && 
                (
                    this.Infant == other.Infant ||
                    this.Infant != null &&
                    this.Infant.Equals(other.Infant)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.Contacts == other.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(other.Contacts)
                ) && 
                (
                    this.FrequentTravelerCards == other.FrequentTravelerCards ||
                    this.FrequentTravelerCards != null &&
                    this.FrequentTravelerCards.SequenceEqual(other.FrequentTravelerCards)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.TravelerType != null)
                    hash = hash * 59 + this.TravelerType.GetHashCode();
                if (this.Infant != null)
                    hash = hash * 59 + this.Infant.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.Contacts != null)
                    hash = hash * 59 + this.Contacts.GetHashCode();
                if (this.FrequentTravelerCards != null)
                    hash = hash * 59 + this.FrequentTravelerCards.GetHashCode();
                return hash;
            }
        }
    }

}
