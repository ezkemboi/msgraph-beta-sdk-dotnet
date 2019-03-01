// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Onenote Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnenoteOperation : Operation
    {
    
        /// <summary>
        /// Gets or sets resource location.
        /// The resource URI for the object. For example, the resource URI for a copied page or section.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceLocation", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceLocation { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The resource id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// The error returned by the operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "error", Required = Newtonsoft.Json.Required.Default)]
        public OnenoteOperationError Error { get; set; }
    
        /// <summary>
        /// Gets or sets percent complete.
        /// The operation percent complete if the operation is still in running status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "percentComplete", Required = Newtonsoft.Json.Required.Default)]
        public string PercentComplete { get; set; }
    
    }
}

