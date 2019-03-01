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
    /// The type WorkbookFunctionsDproductRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsDproductRequestBody
    {
    
        /// <summary>
        /// Gets or sets Database.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "database", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Database { get; set; }
    
        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "field", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Field { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Criteria { get; set; }
    
    }
}
