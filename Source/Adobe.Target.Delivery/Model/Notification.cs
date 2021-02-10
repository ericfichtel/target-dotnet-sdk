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
    /// Notification object is used to sent notificaitons regarding what prefetched content was displayed (for views, pageLoad or regional mboxes), which views, pages and mboxes were visited (triggered), and which elements were clicked. Notification request detail will be validated and in case there are validation errors with any token or timestamp the entire request will be invalidated, so there are no cases of inconsistent data, caused by a partially processed notification. that may happen with a partially processed notification. This is different from the approach in the batch mbox v2 API. Mboxes and views are mutually exclusive.
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public MetricType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Notification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="parameters">Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. .</param>
        /// <param name="profileParameters">Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. .</param>
        /// <param name="order">order.</param>
        /// <param name="product">product.</param>
        /// <param name="id">Notification id will be returned in response and will indicate that the notification was processed successfully.  (required).</param>
        /// <param name="impressionId">Impression id is used to stitch (link) the current notification with a previous notification or execute request. In case they both of them match, the second and other subsequent requests will not generate a new impression to the activity, experience etc. .</param>
        /// <param name="type">type (required).</param>
        /// <param name="timestamp">Timestamp of the notification, in milliseconds elapsed since UNIX epoch. (required).</param>
        /// <param name="tokens">A list of tokens for displayed content or clicked selectors, based on the type of notification..</param>
        /// <param name="mbox">mbox.</param>
        /// <param name="view">view.</param>
        /// <param name="pageLoad">pageLoad.</param>
        public Notification(Address address = default(Address), Dictionary<string, string> parameters = default(Dictionary<string, string>), Dictionary<string, string> profileParameters = default(Dictionary<string, string>), Order order = default(Order), Product product = default(Product), string id = default(string), string impressionId = default(string), MetricType type = default(MetricType), long timestamp = default(long), List<string> tokens = default(List<string>), NotificationMbox mbox = default(NotificationMbox), NotificationView view = default(NotificationView), NotificationPageLoad pageLoad = default(NotificationPageLoad))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Notification and cannot be null");
            this.Type = type;
            this.Timestamp = timestamp;
            this.Address = address;
            this.Parameters = parameters;
            this.ProfileParameters = profileParameters;
            this.Order = order;
            this.Product = product;
            this.ImpressionId = impressionId;
            this.Tokens = tokens;
            this.Mbox = mbox;
            this.View = view;
            this.PageLoad = pageLoad;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }

        /// <summary>
        /// Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000.
        /// </summary>
        /// <value>Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. </value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000.
        /// </summary>
        /// <value>Parameters map. Same object is reused for mbox or profile parameters with slight validation differences. Following names are not allowed for mbox parameters: &#39;orderId&#39;, &#39;orderTotal&#39;, productPurchasedIds&#39; Validation (for both mbox and profile parameters):   * Max 50 parameters limit.   * Parameter name should not be blank.   * Parameter name max length 128.   * Parameter name should not start with &#39;profile.&#39;   * Parameter value length max 5000. </value>
        [DataMember(Name = "profileParameters", EmitDefaultValue = false)]
        public Dictionary<string, string> ProfileParameters { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public Order Order { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public Product Product { get; set; }

        /// <summary>
        /// Notification id will be returned in response and will indicate that the notification was processed successfully.
        /// </summary>
        /// <value>Notification id will be returned in response and will indicate that the notification was processed successfully. </value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Impression id is used to stitch (link) the current notification with a previous notification or execute request. In case they both of them match, the second and other subsequent requests will not generate a new impression to the activity, experience etc.
        /// </summary>
        /// <value>Impression id is used to stitch (link) the current notification with a previous notification or execute request. In case they both of them match, the second and other subsequent requests will not generate a new impression to the activity, experience etc. </value>
        [DataMember(Name = "impressionId", EmitDefaultValue = false)]
        public string ImpressionId { get; set; }

        /// <summary>
        /// Timestamp of the notification, in milliseconds elapsed since UNIX epoch.
        /// </summary>
        /// <value>Timestamp of the notification, in milliseconds elapsed since UNIX epoch.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// A list of tokens for displayed content or clicked selectors, based on the type of notification.
        /// </summary>
        /// <value>A list of tokens for displayed content or clicked selectors, based on the type of notification.</value>
        [DataMember(Name = "tokens", EmitDefaultValue = false)]
        public List<string> Tokens { get; set; }

        /// <summary>
        /// Gets or Sets Mbox
        /// </summary>
        [DataMember(Name = "mbox", EmitDefaultValue = false)]
        public NotificationMbox Mbox { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name = "view", EmitDefaultValue = false)]
        public NotificationView View { get; set; }

        /// <summary>
        /// Gets or Sets PageLoad
        /// </summary>
        [DataMember(Name = "pageLoad", EmitDefaultValue = false)]
        public NotificationPageLoad PageLoad { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ProfileParameters: ").Append(ProfileParameters).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImpressionId: ").Append(ImpressionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  Mbox: ").Append(Mbox).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  PageLoad: ").Append(PageLoad).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) &&
                (
                    this.ProfileParameters == input.ProfileParameters ||
                    this.ProfileParameters != null &&
                    input.ProfileParameters != null &&
                    this.ProfileParameters.SequenceEqual(input.ProfileParameters)
                ) &&
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) &&
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.ImpressionId == input.ImpressionId ||
                    (this.ImpressionId != null &&
                    this.ImpressionId.Equals(input.ImpressionId))
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) &&
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) &&
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    input.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) &&
                (
                    this.Mbox == input.Mbox ||
                    (this.Mbox != null &&
                    this.Mbox.Equals(input.Mbox))
                ) &&
                (
                    this.View == input.View ||
                    (this.View != null &&
                    this.View.Equals(input.View))
                ) &&
                (
                    this.PageLoad == input.PageLoad ||
                    (this.PageLoad != null &&
                    this.PageLoad.Equals(input.PageLoad))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.ProfileParameters != null)
                    hashCode = hashCode * 59 + this.ProfileParameters.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImpressionId != null)
                    hashCode = hashCode * 59 + this.ImpressionId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
                if (this.Mbox != null)
                    hashCode = hashCode * 59 + this.Mbox.GetHashCode();
                if (this.View != null)
                    hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.PageLoad != null)
                    hashCode = hashCode * 59 + this.PageLoad.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 200.", new [] { "Id" });
            }

            // ImpressionId (string) maxLength
            if(this.ImpressionId != null && this.ImpressionId.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImpressionId, length must be less than 128.", new [] { "ImpressionId" });
            }

            yield break;
        }
    }

}
