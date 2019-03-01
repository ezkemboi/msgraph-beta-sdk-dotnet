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
    /// The type Mobile Lob App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileLobApp : MobileApp
    {
    
		///<summary>
		/// The internal MobileLobApp constructor
		///</summary>
        protected internal MobileLobApp()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets committed content version.
        /// The internal committed content version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "committedContentVersion", Required = Newtonsoft.Json.Required.Default)]
        public string CommittedContentVersion { get; set; }
    
        /// <summary>
        /// Gets or sets file name.
        /// The name of the main Lob application file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileName { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The total size, including all uploaded files.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets content versions.
        /// The list of content versions for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentVersions", Required = Newtonsoft.Json.Required.Default)]
        public IMobileLobAppContentVersionsCollectionPage ContentVersions { get; set; }
    
    }
}

