// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EventType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EventType
    {
    
        /// <summary>
        /// single Instance
        /// </summary>
        SingleInstance = 0,
	
        /// <summary>
        /// occurrence
        /// </summary>
        Occurrence = 1,
	
        /// <summary>
        /// exception
        /// </summary>
        Exception = 2,
	
        /// <summary>
        /// series Master
        /// </summary>
        SeriesMaster = 3,
	
    }
}
