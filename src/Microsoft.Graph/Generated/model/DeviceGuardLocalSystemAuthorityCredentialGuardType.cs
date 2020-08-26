// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceGuardLocalSystemAuthorityCredentialGuardType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Enable With UEFILock
        /// </summary>
        EnableWithUEFILock = 1,
	
        /// <summary>
        /// Enable Without UEFILock
        /// </summary>
        EnableWithoutUEFILock = 2,
	
        /// <summary>
        /// Disable
        /// </summary>
        Disable = 3,
	
    }
}