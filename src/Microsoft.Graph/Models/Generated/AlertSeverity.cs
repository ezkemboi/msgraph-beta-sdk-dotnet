// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AlertSeverity.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AlertSeverity
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// informational
        /// </summary>
        Informational = 1,
	
        /// <summary>
        /// low
        /// </summary>
        Low = 2,
	
        /// <summary>
        /// medium
        /// </summary>
        Medium = 3,
	
        /// <summary>
        /// high
        /// </summary>
        High = 4,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
