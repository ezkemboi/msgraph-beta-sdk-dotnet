// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DirectoryObjectGetByIdsRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DirectoryObjectGetByIdsRequestBody
    {
    
        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ids", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Ids { get; set; }
    
        /// <summary>
        /// Gets or sets Types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "types", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Types { get; set; }
    
    }
}
