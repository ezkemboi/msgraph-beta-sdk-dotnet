// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EdgeSearchEngine.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EdgeSearchEngine : EdgeSearchEngineBase
    {
        public EdgeSearchEngine()
        {
            this.ODataType = "microsoft.graph.edgeSearchEngine";
        }
        /// <summary>
        /// Gets or sets edgeSearchEngineType.
        /// Allows IT admins to set a predefined default search engine for MDM-Controlled devices. Possible values are: default, bing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "edgeSearchEngineType", Required = Newtonsoft.Json.Required.Default)]
        public EdgeSearchEngineType? EdgeSearchEngineType { get; set; }
    
    }
}
