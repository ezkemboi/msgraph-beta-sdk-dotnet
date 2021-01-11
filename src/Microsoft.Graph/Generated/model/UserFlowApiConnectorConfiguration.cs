// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UserFlowApiConnectorConfiguration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserFlowApiConnectorConfiguration>))]
    public partial class UserFlowApiConnectorConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFlowApiConnectorConfiguration"/> class.
        /// </summary>
        public UserFlowApiConnectorConfiguration()
        {
            this.ODataType = "microsoft.graph.userFlowApiConnectorConfiguration";
        }

        /// <summary>
        /// Gets or sets postAttributeCollection.
        /// </summary>
        [JsonPropertyName("postAttributeCollection")]
        public IdentityApiConnector PostAttributeCollection { get; set; }
    
        /// <summary>
        /// Gets or sets postFederationSignup.
        /// </summary>
        [JsonPropertyName("postFederationSignup")]
        public IdentityApiConnector PostFederationSignup { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}