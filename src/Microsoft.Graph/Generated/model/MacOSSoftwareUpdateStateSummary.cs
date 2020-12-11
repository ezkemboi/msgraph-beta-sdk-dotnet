// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mac OSSoftware Update State Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSSoftwareUpdateStateSummary : Entity
    {
    
		///<summary>
		/// The MacOSSoftwareUpdateStateSummary constructor
		///</summary>
        public MacOSSoftwareUpdateStateSummary()
        {
            this.ODataType = "microsoft.graph.macOSSoftwareUpdateStateSummary";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Human readable name of the software update
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Last date time the report for this device and product key was updated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Product key of the software update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productKey", Required = Newtonsoft.Json.Required.Default)]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// State of the software update
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public MacOSSoftwareUpdateState? State { get; set; }
    
        /// <summary>
        /// Gets or sets update category.
        /// Software update category
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateCategory", Required = Newtonsoft.Json.Required.Default)]
        public MacOSSoftwareUpdateCategory? UpdateCategory { get; set; }
    
        /// <summary>
        /// Gets or sets update version.
        /// Version of the software update
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updateVersion", Required = Newtonsoft.Json.Required.Default)]
        public string UpdateVersion { get; set; }
    
    }
}
