// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type UserExperienceAnalyticsInsight.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class UserExperienceAnalyticsInsight
    {

        /// <summary>
        /// Gets or sets userExperienceAnalyticsMetricId.
        /// The unique identifier of the user experience analytics insight.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userExperienceAnalyticsMetricId", Required = Newtonsoft.Json.Required.Default)]
        public string UserExperienceAnalyticsMetricId { get; set; }
    
        /// <summary>
        /// Gets or sets insightId.
        /// The unique identifier of the user experience analytics insight.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "insightId", Required = Newtonsoft.Json.Required.Default)]
        public string InsightId { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The value of the user experience analytics insight.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<UserExperienceAnalyticsInsightValue> Value { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}