// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MdmAuthority.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MdmAuthority
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// intune
        /// </summary>
        Intune = 1,
	
        /// <summary>
        /// sccm
        /// </summary>
        Sccm = 2,
	
        /// <summary>
        /// office365
        /// </summary>
        Office365 = 3,
	
    }
}
