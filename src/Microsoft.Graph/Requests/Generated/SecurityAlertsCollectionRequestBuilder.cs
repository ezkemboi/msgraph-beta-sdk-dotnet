// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SecurityAlertsCollectionRequestBuilder.
    /// </summary>
    public partial class SecurityAlertsCollectionRequestBuilder : BaseRequestBuilder, ISecurityAlertsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SecurityAlertsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityAlertsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISecurityAlertsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISecurityAlertsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SecurityAlertsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAlertRequestBuilder"/> for the specified SecurityAlert.
        /// </summary>
        /// <param name="id">The ID for the SecurityAlert.</param>
        /// <returns>The <see cref="IAlertRequestBuilder"/>.</returns>
        public IAlertRequestBuilder this[string id]
        {
            get
            {
                return new AlertRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
