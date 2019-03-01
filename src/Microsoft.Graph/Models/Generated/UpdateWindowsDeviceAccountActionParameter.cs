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
    /// The type UpdateWindowsDeviceAccountActionParameter.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class UpdateWindowsDeviceAccountActionParameter
    {

        /// <summary>
        /// Gets or sets deviceAccount.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceAccount", Required = Newtonsoft.Json.Required.Default)]
        public WindowsDeviceAccount DeviceAccount { get; set; }
    
        /// <summary>
        /// Gets or sets passwordRotationEnabled.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRotationEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRotationEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets calendarSyncEnabled.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? CalendarSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets deviceAccountEmail.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceAccountEmail", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceAccountEmail { get; set; }
    
        /// <summary>
        /// Gets or sets exchangeServer.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeServer", Required = Newtonsoft.Json.Required.Default)]
        public string ExchangeServer { get; set; }
    
        /// <summary>
        /// Gets or sets sessionInitiationProtocalAddress.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sessionInitiationProtocalAddress", Required = Newtonsoft.Json.Required.Default)]
        public string SessionInitiationProtocalAddress { get; set; }
    
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
