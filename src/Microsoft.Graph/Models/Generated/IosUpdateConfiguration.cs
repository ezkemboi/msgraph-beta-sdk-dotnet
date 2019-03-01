// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Ios Update Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosUpdateConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets active hours start.
        /// Active Hours Start (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursStart", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursStart { get; set; }
    
        /// <summary>
        /// Gets or sets active hours end.
        /// Active Hours End (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursEnd", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursEnd { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled install days.
        /// Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduledInstallDays", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DayOfWeek> ScheduledInstallDays { get; set; }
    
        /// <summary>
        /// Gets or sets utc time offset in minutes.
        /// UTC Time Offset indicated in minutes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "utcTimeOffsetInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UtcTimeOffsetInMinutes { get; set; }
    
    }
}

