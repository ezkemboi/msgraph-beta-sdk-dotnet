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
    /// The type SharedPCAccountManagerPolicy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SharedPCAccountManagerPolicy
    {

        /// <summary>
        /// Gets or sets accountDeletionPolicy.
        /// Configures when accounts are deleted. Possible values are: immediate, diskSpaceThreshold, diskSpaceThresholdOrInactiveThreshold.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountDeletionPolicy", Required = Newtonsoft.Json.Required.Default)]
        public SharedPCAccountDeletionPolicyType? AccountDeletionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets cacheAccountsAboveDiskFreePercentage.
        /// Sets the percentage of available disk space a PC should have before it stops deleting cached shared PC accounts. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cacheAccountsAboveDiskFreePercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CacheAccountsAboveDiskFreePercentage { get; set; }
    
        /// <summary>
        /// Gets or sets inactiveThresholdDays.
        /// Specifies when the accounts will start being deleted when they have not been logged on during the specified period, given as number of days. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inactiveThresholdDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InactiveThresholdDays { get; set; }
    
        /// <summary>
        /// Gets or sets removeAccountsBelowDiskFreePercentage.
        /// Sets the percentage of disk space remaining on a PC before cached accounts will be deleted to free disk space. Accounts that have been inactive the longest will be deleted first. Only applies when AccountDeletionPolicy is DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "removeAccountsBelowDiskFreePercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemoveAccountsBelowDiskFreePercentage { get; set; }
    
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
