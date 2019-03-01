// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ActivityDomain.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ActivityDomain
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// work
        /// </summary>
        Work = 1,
	
        /// <summary>
        /// personal
        /// </summary>
        Personal = 2,
	
        /// <summary>
        /// unrestricted
        /// </summary>
        Unrestricted = 3,
	
    }
}
