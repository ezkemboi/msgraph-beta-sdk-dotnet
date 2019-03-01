// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsUpdateActiveHoursInstall.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsUpdateActiveHoursInstall : WindowsUpdateInstallScheduleType
    {
        public WindowsUpdateActiveHoursInstall()
        {
            this.ODataType = "microsoft.graph.windowsUpdateActiveHoursInstall";
        }
        /// <summary>
        /// Gets or sets activeHoursStart.
        /// Active Hours Start
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursStart", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursStart { get; set; }
    
        /// <summary>
        /// Gets or sets activeHoursEnd.
        /// Active Hours End
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeHoursEnd", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay ActiveHoursEnd { get; set; }
    
    }
}
