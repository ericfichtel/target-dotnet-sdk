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
    /// The content from the activitiesc is returned via the option objects.
    /// </summary>
    [DataContract(Name = "Option")]
    public partial class Option : IEquatable<Option>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OptionType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Option" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="content">Content that should be applied/displayed/replaced etc, based on the option type. Content can be one of:   * html   * redirect link   * link for a dynamic offer   * raw json   * one or more actions (json - from offers with templates and visual offers) Actions format is specific for delivery API. .</param>
        /// <param name="eventToken">Will be present only in response of a prefetch request. After the content is displayed the event token should be sent via notifications to the edge server so that visit/visitor/impression events could be logged. .</param>
        /// <param name="responseTokens">List of the response tokens and their values for the given option. Response tokens can be defined via the /v1/responsetokens API. The values for the tokens are computed for every option returned by a activity and represented as a dictionary:   * Key - the response token name.   * Value - the response token value. The value is usually a string, but it can be a list of string in case of   &#39;category affinity&#39; response token. .</param>
        public Option(OptionType? type = default(OptionType?), Object content = default(Object), string eventToken = default(string), Dictionary<string, Object> responseTokens = default(Dictionary<string, Object>))
        {
            this.Type = type;
            this.Content = content;
            this.EventToken = eventToken;
            this.ResponseTokens = responseTokens;
        }

        /// <summary>
        /// Content that should be applied/displayed/replaced etc, based on the option type. Content can be one of:   * html   * redirect link   * link for a dynamic offer   * raw json   * one or more actions (json - from offers with templates and visual offers) Actions format is specific for delivery API.
        /// </summary>
        /// <value>Content that should be applied/displayed/replaced etc, based on the option type. Content can be one of:   * html   * redirect link   * link for a dynamic offer   * raw json   * one or more actions (json - from offers with templates and visual offers) Actions format is specific for delivery API. </value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public Object Content { get; set; }

        /// <summary>
        /// Will be present only in response of a prefetch request. After the content is displayed the event token should be sent via notifications to the edge server so that visit/visitor/impression events could be logged.
        /// </summary>
        /// <value>Will be present only in response of a prefetch request. After the content is displayed the event token should be sent via notifications to the edge server so that visit/visitor/impression events could be logged. </value>
        [DataMember(Name = "eventToken", EmitDefaultValue = false)]
        public string EventToken { get; set; }

        /// <summary>
        /// List of the response tokens and their values for the given option. Response tokens can be defined via the /v1/responsetokens API. The values for the tokens are computed for every option returned by a activity and represented as a dictionary:   * Key - the response token name.   * Value - the response token value. The value is usually a string, but it can be a list of string in case of   &#39;category affinity&#39; response token.
        /// </summary>
        /// <value>List of the response tokens and their values for the given option. Response tokens can be defined via the /v1/responsetokens API. The values for the tokens are computed for every option returned by a activity and represented as a dictionary:   * Key - the response token name.   * Value - the response token value. The value is usually a string, but it can be a list of string in case of   &#39;category affinity&#39; response token. </value>
        [DataMember(Name = "responseTokens", EmitDefaultValue = false)]
        public Dictionary<string, Object> ResponseTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Option {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  EventToken: ").Append(EventToken).Append("\n");
            sb.Append("  ResponseTokens: ").Append(ResponseTokens).Append("\n");
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
            return this.Equals(input as Option);
        }

        /// <summary>
        /// Returns true if Option instances are equal
        /// </summary>
        /// <param name="input">Instance of Option to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Option input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) &&
                (
                    this.EventToken == input.EventToken ||
                    (this.EventToken != null &&
                    this.EventToken.Equals(input.EventToken))
                ) &&
                (
                    this.ResponseTokens == input.ResponseTokens ||
                    this.ResponseTokens != null &&
                    input.ResponseTokens != null &&
                    this.ResponseTokens.SequenceEqual(input.ResponseTokens)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.EventToken != null)
                    hashCode = hashCode * 59 + this.EventToken.GetHashCode();
                if (this.ResponseTokens != null)
                    hashCode = hashCode * 59 + this.ResponseTokens.GetHashCode();
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
