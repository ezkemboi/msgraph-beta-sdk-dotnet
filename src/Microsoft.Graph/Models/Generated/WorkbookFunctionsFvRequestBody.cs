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
    /// The type WorkbookFunctionsFvRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsFvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rate", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Nper.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nper", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Nper { get; set; }
    
        /// <summary>
        /// Gets or sets Pmt.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pmt", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Pmt { get; set; }
    
        /// <summary>
        /// Gets or sets Pv.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pv", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Pv { get; set; }
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Type { get; set; }
    
    }
}
