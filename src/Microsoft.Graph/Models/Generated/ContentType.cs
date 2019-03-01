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
    /// The type Content Type.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ContentType : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The descriptive text for the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// The name of the group this content type belongs to. Helps organize related content types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "group", Required = Newtonsoft.Json.Required.Default)]
        public string Group { get; set; }
    
        /// <summary>
        /// Gets or sets hidden.
        /// Indicates whether the content type is hidden in the list's 'New' menu.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? Hidden { get; set; }
    
        /// <summary>
        /// Gets or sets inherited from.
        /// If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inheritedFrom", Required = Newtonsoft.Json.Required.Default)]
        public ItemReference InheritedFrom { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the content type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets order.
        /// Specifies the order in which the content type appears in the selection UI.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order", Required = Newtonsoft.Json.Required.Default)]
        public ContentTypeOrder Order { get; set; }
    
        /// <summary>
        /// Gets or sets parent id.
        /// The unique identifier of the content type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentId { get; set; }
    
        /// <summary>
        /// Gets or sets read only.
        /// If true, the content type cannot be modified unless this value is first set to false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "readOnly", Required = Newtonsoft.Json.Required.Default)]
        public bool? ReadOnly { get; set; }
    
        /// <summary>
        /// Gets or sets sealed.
        /// If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sealed", Required = Newtonsoft.Json.Required.Default)]
        public bool? Sealed { get; set; }
    
        /// <summary>
        /// Gets or sets column links.
        /// The collection of columns that are required by this content type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnLinks", Required = Newtonsoft.Json.Required.Default)]
        public IContentTypeColumnLinksCollectionPage ColumnLinks { get; set; }
    
    }
}

