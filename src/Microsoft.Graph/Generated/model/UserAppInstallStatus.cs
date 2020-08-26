// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User App Install Status.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserAppInstallStatus : Entity
    {
    
		///<summary>
		/// The UserAppInstallStatus constructor
		///</summary>
        public UserAppInstallStatus()
        {
            this.ODataType = "microsoft.graph.userAppInstallStatus";
        }
	
        /// <summary>
        /// Gets or sets user name.
        /// User name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets installed device count.
        /// Installed Device Count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed device count.
        /// Failed Device Count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed device count.
        /// Not installed device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notInstalledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotInstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets app.
        /// The navigation link to the mobile app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "app", Required = Newtonsoft.Json.Required.Default)]
        public MobileApp App { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// The install state of the app on devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IUserAppInstallStatusDeviceStatusesCollectionPage DeviceStatuses { get; set; }
    
    }
}
