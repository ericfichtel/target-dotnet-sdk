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
    /// The execute part of the request that will be evaluated on the server side immediately. Impressions will be incremented for the matching activities. 
    /// </summary>
    [DataContract(Name = "ExecuteRequest")]
    public partial class ExecuteRequest : IEquatable<ExecuteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequest" /> class.
        /// </summary>
        /// <param name="pageLoad">pageLoad.</param>
        /// <param name="mboxes">An array of mboxes other than global mbox..</param>
        public ExecuteRequest(RequestDetails pageLoad = default(RequestDetails), List<MboxRequest> mboxes = default(List<MboxRequest>))
        {
            this.PageLoad = pageLoad;
            this.Mboxes = mboxes;
        }

        /// <summary>
        /// Gets or Sets PageLoad
        /// </summary>
        [DataMember(Name = "pageLoad", EmitDefaultValue = false)]
        public RequestDetails PageLoad { get; set; }

        /// <summary>
        /// An array of mboxes other than global mbox.
        /// </summary>
        /// <value>An array of mboxes other than global mbox.</value>
        [DataMember(Name = "mboxes", EmitDefaultValue = false)]
        public List<MboxRequest> Mboxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteRequest {\n");
            sb.Append("  PageLoad: ").Append(PageLoad).Append("\n");
            sb.Append("  Mboxes: ").Append(Mboxes).Append("\n");
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
            return this.Equals(input as ExecuteRequest);
        }

        /// <summary>
        /// Returns true if ExecuteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecuteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecuteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageLoad == input.PageLoad ||
                    (this.PageLoad != null &&
                    this.PageLoad.Equals(input.PageLoad))
                ) && 
                (
                    this.Mboxes == input.Mboxes ||
                    this.Mboxes != null &&
                    input.Mboxes != null &&
                    this.Mboxes.SequenceEqual(input.Mboxes)
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
                if (this.PageLoad != null)
                    hashCode = hashCode * 59 + this.PageLoad.GetHashCode();
                if (this.Mboxes != null)
                    hashCode = hashCode * 59 + this.Mboxes.GetHashCode();
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
