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
    /// Mobile Platform should be specified when the channel is Mobile
    /// </summary>
    [DataContract(Name = "MobilePlatform")]
    public partial class MobilePlatform : IEquatable<MobilePlatform>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name = "deviceType", IsRequired = true, EmitDefaultValue = false)]
        public DeviceType DeviceType { get; set; }
        /// <summary>
        /// Gets or Sets PlatformType
        /// </summary>
        [DataMember(Name = "platformType", IsRequired = true, EmitDefaultValue = false)]
        public MobilePlatformType PlatformType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePlatform" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MobilePlatform() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePlatform" /> class.
        /// </summary>
        /// <param name="deviceName">Optional field, added to help with device detection using device atlas. This is equivalent of a.DeviceName field passed in from Mobile SDK .</param>
        /// <param name="deviceType">deviceType (required).</param>
        /// <param name="platformType">platformType (required).</param>
        /// <param name="version">If not specified - all activities with any platformVersion will be evaluated. If specified - only activities with the same platformVersion will be evaluated. .</param>
        public MobilePlatform(string deviceName = default(string), DeviceType deviceType = default(DeviceType), MobilePlatformType platformType = default(MobilePlatformType), string version = default(string))
        {
            this.DeviceType = deviceType;
            this.PlatformType = platformType;
            this.DeviceName = deviceName;
            this.Version = version;
        }

        /// <summary>
        /// Optional field, added to help with device detection using device atlas. This is equivalent of a.DeviceName field passed in from Mobile SDK
        /// </summary>
        /// <value>Optional field, added to help with device detection using device atlas. This is equivalent of a.DeviceName field passed in from Mobile SDK </value>
        [DataMember(Name = "deviceName", EmitDefaultValue = false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// If not specified - all activities with any platformVersion will be evaluated. If specified - only activities with the same platformVersion will be evaluated.
        /// </summary>
        /// <value>If not specified - all activities with any platformVersion will be evaluated. If specified - only activities with the same platformVersion will be evaluated. </value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobilePlatform {\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as MobilePlatform);
        }

        /// <summary>
        /// Returns true if MobilePlatform instances are equal
        /// </summary>
        /// <param name="input">Instance of MobilePlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobilePlatform input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) &&
                (
                    this.DeviceType == input.DeviceType ||
                    this.DeviceType.Equals(input.DeviceType)
                ) &&
                (
                    this.PlatformType == input.PlatformType ||
                    this.PlatformType.Equals(input.PlatformType)
                ) &&
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
            // Version (string) maxLength
            if(this.Version != null && this.Version.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, length must be less than 128.", new [] { "Version" });
            }

            yield break;
        }
    }

}
