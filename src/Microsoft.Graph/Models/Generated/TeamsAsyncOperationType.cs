// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum TeamsAsyncOperationType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TeamsAsyncOperationType
    {
    
        /// <summary>
        /// invalid
        /// </summary>
        Invalid = 0,
	
        /// <summary>
        /// clone Team
        /// </summary>
        CloneTeam = 1,
	
        /// <summary>
        /// archive Team
        /// </summary>
        ArchiveTeam = 2,
	
        /// <summary>
        /// unarchive Team
        /// </summary>
        UnarchiveTeam = 3,
	
        /// <summary>
        /// create Team
        /// </summary>
        CreateTeam = 4,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
