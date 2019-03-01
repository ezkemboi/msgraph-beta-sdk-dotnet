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
    /// The type WorkbookFunctionsChiSq_Dist_RTRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsChiSq_Dist_RTRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "degFreedom", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken DegFreedom { get; set; }
    
    }
}
