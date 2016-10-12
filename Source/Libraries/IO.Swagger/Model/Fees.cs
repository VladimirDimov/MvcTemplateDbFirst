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
    /// Fees
    /// </summary>
    [DataContract]
    public partial class Fees :  IEquatable<Fees>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fees" /> class.
        /// </summary>
        /// <param name="ServiceFees">The cost of any required service fees in addition to the total price.</param>
        /// <param name="CreditcardFees">The cost of any fees for common credit cards, such as Visa or Mastercard, in addition to the total price.</param>
        public Fees(string ServiceFees = null, string CreditcardFees = null)
        {
            this.ServiceFees = ServiceFees;
            this.CreditcardFees = CreditcardFees;
        }
        
        /// <summary>
        /// The cost of any required service fees in addition to the total price
        /// </summary>
        /// <value>The cost of any required service fees in addition to the total price</value>
        [DataMember(Name="service_fees", EmitDefaultValue=false)]
        public string ServiceFees { get; set; }
        /// <summary>
        /// The cost of any fees for common credit cards, such as Visa or Mastercard, in addition to the total price
        /// </summary>
        /// <value>The cost of any fees for common credit cards, such as Visa or Mastercard, in addition to the total price</value>
        [DataMember(Name="creditcard_fees", EmitDefaultValue=false)]
        public string CreditcardFees { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fees {\n");
            sb.Append("  ServiceFees: ").Append(ServiceFees).Append("\n");
            sb.Append("  CreditcardFees: ").Append(CreditcardFees).Append("\n");
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
            return this.Equals(obj as Fees);
        }

        /// <summary>
        /// Returns true if Fees instances are equal
        /// </summary>
        /// <param name="other">Instance of Fees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fees other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceFees == other.ServiceFees ||
                    this.ServiceFees != null &&
                    this.ServiceFees.Equals(other.ServiceFees)
                ) && 
                (
                    this.CreditcardFees == other.CreditcardFees ||
                    this.CreditcardFees != null &&
                    this.CreditcardFees.Equals(other.CreditcardFees)
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
                if (this.ServiceFees != null)
                    hash = hash * 59 + this.ServiceFees.GetHashCode();
                if (this.CreditcardFees != null)
                    hash = hash * 59 + this.CreditcardFees.GetHashCode();
                return hash;
            }
        }
    }

}
