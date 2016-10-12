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
    /// AffiliatePayout
    /// </summary>
    [DataContract]
    public partial class AffiliatePayout :  IEquatable<AffiliatePayout>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliatePayout" /> class.
        /// </summary>
        /// <param name="CPC">See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked.</param>
        /// <param name="CPA">See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link.</param>
        /// <param name="CPS">See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link.</param>
        public AffiliatePayout(Amount CPC = null, Amount CPA = null, Amount CPS = null)
        {
            this.CPC = CPC;
            this.CPA = CPA;
            this.CPS = CPS;
        }
        
        /// <summary>
        /// See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Pay_per_click for commission earned when the provided deep link is clicked</value>
        [DataMember(Name="CPC", EmitDefaultValue=false)]
        public Amount CPC { get; set; }
        /// <summary>
        /// See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Cost_per_action for commission earned for a given action from the provided deep link</value>
        [DataMember(Name="CPA", EmitDefaultValue=false)]
        public Amount CPA { get; set; }
        /// <summary>
        /// See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link
        /// </summary>
        /// <value>See https://en.wikipedia.org/wiki/Pay_per_sale for commission earned as a result of a booking made from the provided deep link</value>
        [DataMember(Name="CPS", EmitDefaultValue=false)]
        public Amount CPS { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffiliatePayout {\n");
            sb.Append("  CPC: ").Append(CPC).Append("\n");
            sb.Append("  CPA: ").Append(CPA).Append("\n");
            sb.Append("  CPS: ").Append(CPS).Append("\n");
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
            return this.Equals(obj as AffiliatePayout);
        }

        /// <summary>
        /// Returns true if AffiliatePayout instances are equal
        /// </summary>
        /// <param name="other">Instance of AffiliatePayout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AffiliatePayout other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CPC == other.CPC ||
                    this.CPC != null &&
                    this.CPC.Equals(other.CPC)
                ) && 
                (
                    this.CPA == other.CPA ||
                    this.CPA != null &&
                    this.CPA.Equals(other.CPA)
                ) && 
                (
                    this.CPS == other.CPS ||
                    this.CPS != null &&
                    this.CPS.Equals(other.CPS)
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
                if (this.CPC != null)
                    hash = hash * 59 + this.CPC.GetHashCode();
                if (this.CPA != null)
                    hash = hash * 59 + this.CPA.GetHashCode();
                if (this.CPS != null)
                    hash = hash * 59 + this.CPS.GetHashCode();
                return hash;
            }
        }
    }

}
