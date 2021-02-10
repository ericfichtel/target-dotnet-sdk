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
    /// Page load response. Contains the result of prefetching or executing a request that will retrieve content for all selectors not associated with a particular view.
    /// </summary>
    [DataContract(Name = "PageLoadResponse")]
    public partial class PageLoadResponse : IEquatable<PageLoadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageLoadResponse" /> class.
        /// </summary>
        /// <param name="options">List of options that should be applied. Note: options that have been set on selectors assigned to views will not be included here. .</param>
        /// <param name="metrics">Click track metrics. Note that click metrics for selectors set with views will not be included here. In case the same activity is serving content for selectors both assinged to a view and selectors without any views, and having click track metrics that are not assotiated with any view within the activity, then:   * in case of a prefetch only request, these metrics (tokens) will be set in the Prefetch response&#39;s metrics.   * in case of an execute only request, the metrics will be set in the page load response&#39;s metrics.   * in case of a request, with both, execute and prefetch, metrics will be set in the page load response&#39;s     metrics only. .</param>
        /// <param name="analytics">analytics.</param>
        /// <param name="state">View state token that must be sent back with display notification for the view. May only be present for prefetch requests. .</param>
        /// <param name="trace">The object containing all trace data for the request, only present if the trace token was provided in the request. .</param>
        public PageLoadResponse(List<Option> options = default(List<Option>), List<Metric> metrics = default(List<Metric>), AnalyticsResponse analytics = default(AnalyticsResponse), string state = default(string), Dictionary<string, Object> trace = default(Dictionary<string, Object>))
        {
            this.Options = options;
            this.Metrics = metrics;
            this.Analytics = analytics;
            this.State = state;
            this.Trace = trace;
        }

        /// <summary>
        /// List of options that should be applied. Note: options that have been set on selectors assigned to views will not be included here.
        /// </summary>
        /// <value>List of options that should be applied. Note: options that have been set on selectors assigned to views will not be included here. </value>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<Option> Options { get; set; }

        /// <summary>
        /// Click track metrics. Note that click metrics for selectors set with views will not be included here. In case the same activity is serving content for selectors both assinged to a view and selectors without any views, and having click track metrics that are not assotiated with any view within the activity, then:   * in case of a prefetch only request, these metrics (tokens) will be set in the Prefetch response&#39;s metrics.   * in case of an execute only request, the metrics will be set in the page load response&#39;s metrics.   * in case of a request, with both, execute and prefetch, metrics will be set in the page load response&#39;s     metrics only.
        /// </summary>
        /// <value>Click track metrics. Note that click metrics for selectors set with views will not be included here. In case the same activity is serving content for selectors both assinged to a view and selectors without any views, and having click track metrics that are not assotiated with any view within the activity, then:   * in case of a prefetch only request, these metrics (tokens) will be set in the Prefetch response&#39;s metrics.   * in case of an execute only request, the metrics will be set in the page load response&#39;s metrics.   * in case of a request, with both, execute and prefetch, metrics will be set in the page load response&#39;s     metrics only. </value>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public List<Metric> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Analytics
        /// </summary>
        [DataMember(Name = "analytics", EmitDefaultValue = false)]
        public AnalyticsResponse Analytics { get; set; }

        /// <summary>
        /// View state token that must be sent back with display notification for the view. May only be present for prefetch requests.
        /// </summary>
        /// <value>View state token that must be sent back with display notification for the view. May only be present for prefetch requests. </value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The object containing all trace data for the request, only present if the trace token was provided in the request.
        /// </summary>
        /// <value>The object containing all trace data for the request, only present if the trace token was provided in the request. </value>
        [DataMember(Name = "trace", EmitDefaultValue = false)]
        public Dictionary<string, Object> Trace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageLoadResponse {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Analytics: ").Append(Analytics).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Trace: ").Append(Trace).Append("\n");
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
            return this.Equals(input as PageLoadResponse);
        }

        /// <summary>
        /// Returns true if PageLoadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PageLoadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageLoadResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) &&
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) &&
                (
                    this.Analytics == input.Analytics ||
                    (this.Analytics != null &&
                    this.Analytics.Equals(input.Analytics))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Trace == input.Trace ||
                    this.Trace != null &&
                    input.Trace != null &&
                    this.Trace.SequenceEqual(input.Trace)
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.Analytics != null)
                    hashCode = hashCode * 59 + this.Analytics.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Trace != null)
                    hashCode = hashCode * 59 + this.Trace.GetHashCode();
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
