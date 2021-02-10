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
    /// Defines OptionType
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum OptionType
    {
        /// <summary>
        /// Enum Html for value: html
        /// </summary>
        [EnumMember(Value = "html")]
        Html = 1,

        /// <summary>
        /// Enum Json for value: json
        /// </summary>
        [EnumMember(Value = "json")]
        Json = 2,

        /// <summary>
        /// Enum Redirect for value: redirect
        /// </summary>
        [EnumMember(Value = "redirect")]
        Redirect = 3,

        /// <summary>
        /// Enum Dynamic for value: dynamic
        /// </summary>
        [EnumMember(Value = "dynamic")]
        Dynamic = 4,

        /// <summary>
        /// Enum Actions for value: actions
        /// </summary>
        [EnumMember(Value = "actions")]
        Actions = 5

    }

}
