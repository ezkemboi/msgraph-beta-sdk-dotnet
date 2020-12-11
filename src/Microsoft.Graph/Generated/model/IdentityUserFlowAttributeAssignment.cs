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
    /// The type Identity User Flow Attribute Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IdentityUserFlowAttributeAssignment : Entity
    {
    
		///<summary>
		/// The IdentityUserFlowAttributeAssignment constructor
		///</summary>
        public IdentityUserFlowAttributeAssignment()
        {
            this.ODataType = "microsoft.graph.identityUserFlowAttributeAssignment";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isOptional", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsOptional { get; set; }
    
        /// <summary>
        /// Gets or sets requires verification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiresVerification", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequiresVerification { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAttributeValues", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<UserAttributeValuesItem> UserAttributeValues { get; set; }
    
        /// <summary>
        /// Gets or sets user input type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userInputType", Required = Newtonsoft.Json.Required.Default)]
        public IdentityUserFlowAttributeInputType? UserInputType { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAttribute", Required = Newtonsoft.Json.Required.Default)]
        public IdentityUserFlowAttribute UserAttribute { get; set; }
    
    }
}
