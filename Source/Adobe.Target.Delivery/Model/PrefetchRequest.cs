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
    /// Use this object to prefetch the content for &#x60;views&#x60; and/or &#x60;pageLoad&#x60; and/or &#x60;mboxes&#x60;.   * &#x60;views&#x60; - the request to prefetch selectors grouped per view.   * &#x60;pageLoad&#x60; - the request to prefetch selectors not assigned to any view.   * &#x60;mboxes&#x60; - the request to prefetch mbox content.
    /// </summary>
    [DataContract(Name = "PrefetchRequest")]
    public partial class PrefetchRequest : IEquatable<PrefetchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrefetchRequest" /> class.
        /// </summary>
        /// <param name="views">An array of views .</param>
        /// <param name="pageLoad">pageLoad.</param>
        /// <param name="mboxes">Prefetch the content for the regional mbox..</param>
        public PrefetchRequest(List<ViewRequest> views = default(List<ViewRequest>), RequestDetails pageLoad = default(RequestDetails), List<MboxRequest> mboxes = default(List<MboxRequest>))
        {
            this.Views = views;
            this.PageLoad = pageLoad;
            this.Mboxes = mboxes;
        }

        /// <summary>
        /// An array of views
        /// </summary>
        /// <value>An array of views </value>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public List<ViewRequest> Views { get; set; }

        /// <summary>
        /// Gets or Sets PageLoad
        /// </summary>
        [DataMember(Name = "pageLoad", EmitDefaultValue = false)]
        public RequestDetails PageLoad { get; set; }

        /// <summary>
        /// Prefetch the content for the regional mbox.
        /// </summary>
        /// <value>Prefetch the content for the regional mbox.</value>
        [DataMember(Name = "mboxes", EmitDefaultValue = false)]
        public List<MboxRequest> Mboxes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrefetchRequest {\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
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
            return this.Equals(input as PrefetchRequest);
        }

        /// <summary>
        /// Returns true if PrefetchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrefetchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrefetchRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    input.Views != null &&
                    this.Views.SequenceEqual(input.Views)
                ) &&
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
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
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
