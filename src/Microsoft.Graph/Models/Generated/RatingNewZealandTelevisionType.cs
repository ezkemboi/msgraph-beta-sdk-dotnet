// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RatingNewZealandTelevisionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RatingNewZealandTelevisionType
    {
    
        /// <summary>
        /// all Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// all Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// general
        /// </summary>
        General = 2,
	
        /// <summary>
        /// parental Guidance
        /// </summary>
        ParentalGuidance = 3,
	
        /// <summary>
        /// adults
        /// </summary>
        Adults = 4,
	
    }
}
