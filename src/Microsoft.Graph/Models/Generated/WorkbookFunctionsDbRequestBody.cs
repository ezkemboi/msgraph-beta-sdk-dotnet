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
    /// The type WorkbookFunctionsDbRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsDbRequestBody
    {
    
        /// <summary>
        /// Gets or sets Cost.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cost", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Cost { get; set; }
    
        /// <summary>
        /// Gets or sets Salvage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salvage", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Salvage { get; set; }
    
        /// <summary>
        /// Gets or sets Life.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "life", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Life { get; set; }
    
        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Period { get; set; }
    
        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "month", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Month { get; set; }
    
    }
}
