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
    /// The type WorkbookFunctionsExactRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsExactRequestBody
    {
    
        /// <summary>
        /// Gets or sets Text1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text1", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Text1 { get; set; }
    
        /// <summary>
        /// Gets or sets Text2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text2", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Text2 { get; set; }
    
    }
}
