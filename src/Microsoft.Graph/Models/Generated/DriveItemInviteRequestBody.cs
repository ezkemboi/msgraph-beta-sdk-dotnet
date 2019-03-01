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
    /// The type DriveItemInviteRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItemInviteRequestBody
    {
    
        /// <summary>
        /// Gets or sets RequireSignIn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSignIn", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets Roles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets SendInvitation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sendInvitation", Required = Newtonsoft.Json.Required.Default)]
        public bool? SendInvitation { get; set; }
    
        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "message", Required = Newtonsoft.Json.Required.Default)]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets Recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipients", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DriveRecipient> Recipients { get; set; }
    
    }
}
