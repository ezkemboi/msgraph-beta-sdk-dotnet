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
    /// The type DeviceManagementConfigurationIntegerSettingValue.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementConfigurationIntegerSettingValue : DeviceManagementConfigurationSimpleSettingValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationIntegerSettingValue"/> class.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValue()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationIntegerSettingValue";
        }

        /// <summary>
        /// Gets or sets value.
        /// Value of the integer setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Value { get; set; }
    
    }
}