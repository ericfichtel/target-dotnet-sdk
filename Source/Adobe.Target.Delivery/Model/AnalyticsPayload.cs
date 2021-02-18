// <auto-generated/>
/*
 * Copyright 2021 Adobe. All rights reserved.
 * This file is licensed to you under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
 * OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adobe.Target.Delivery.Client.OpenAPIDateConverter;

namespace Adobe.Target.Delivery.Model
{
    /// <summary>
    /// Analytics payload for client side integration that should be sent to Analytics after content has been applied. 
    /// </summary>
    [DataContract(Name = "AnalyticsPayload")]
    public partial class AnalyticsPayload : IEquatable<AnalyticsPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsPayload" /> class.
        /// </summary>
        /// <param name="pe">Indicates to Adobe Analytics that the payload is an Adobe Target type.</param>
        /// <param name="tnta">Contains Target metadata that describes the activity and experience.</param>
        public AnalyticsPayload(string pe = default(string), string tnta = default(string))
        {
            this.Pe = pe;
            this.Tnta = tnta;
        }

        /// <summary>
        /// Indicates to Adobe Analytics that the payload is an Adobe Target type
        /// </summary>
        /// <value>Indicates to Adobe Analytics that the payload is an Adobe Target type</value>
        [DataMember(Name = "pe", EmitDefaultValue = false)]
        public string Pe { get; set; }

        /// <summary>
        /// Contains Target metadata that describes the activity and experience
        /// </summary>
        /// <value>Contains Target metadata that describes the activity and experience</value>
        [DataMember(Name = "tnta", EmitDefaultValue = false)]
        public string Tnta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsPayload {\n");
            sb.Append("  Pe: ").Append(Pe).Append("\n");
            sb.Append("  Tnta: ").Append(Tnta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalyticsPayload);
        }

        /// <summary>
        /// Returns true if AnalyticsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pe == input.Pe ||
                    (this.Pe != null &&
                    this.Pe.Equals(input.Pe))
                ) && 
                (
                    this.Tnta == input.Tnta ||
                    (this.Tnta != null &&
                    this.Tnta.Equals(input.Tnta))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Pe != null)
                    hashCode = hashCode * 59 + this.Pe.GetHashCode();
                if (this.Tnta != null)
                    hashCode = hashCode * 59 + this.Tnta.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
