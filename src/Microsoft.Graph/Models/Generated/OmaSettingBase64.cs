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
    /// The type OmaSettingBase64.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OmaSettingBase64 : OmaSetting
    {
        public OmaSettingBase64()
        {
            this.ODataType = "microsoft.graph.omaSettingBase64";
        }
        /// <summary>
        /// Gets or sets fileName.
        /// File name associated with the Value property (.cer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Value. (Base64 encoded string)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public string Value { get; set; }
    
    }
}
