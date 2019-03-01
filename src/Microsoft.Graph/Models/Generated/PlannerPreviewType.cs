// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum PlannerPreviewType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PlannerPreviewType
    {
    
        /// <summary>
        /// automatic
        /// </summary>
        Automatic = 0,
	
        /// <summary>
        /// no Preview
        /// </summary>
        NoPreview = 1,
	
        /// <summary>
        /// checklist
        /// </summary>
        Checklist = 2,
	
        /// <summary>
        /// description
        /// </summary>
        Description = 3,
	
        /// <summary>
        /// reference
        /// </summary>
        Reference = 4,
	
    }
}
