// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum SharedPCAccountDeletionPolicyType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SharedPCAccountDeletionPolicyType
    {
    
        /// <summary>
        /// immediate
        /// </summary>
        Immediate = 0,
	
        /// <summary>
        /// disk Space Threshold
        /// </summary>
        DiskSpaceThreshold = 1,
	
        /// <summary>
        /// disk Space Threshold Or Inactive Threshold
        /// </summary>
        DiskSpaceThresholdOrInactiveThreshold = 2,
	
    }
}
