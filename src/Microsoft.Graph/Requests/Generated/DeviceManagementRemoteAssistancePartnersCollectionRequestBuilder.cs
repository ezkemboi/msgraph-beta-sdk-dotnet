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
    /// The type DeviceManagementRemoteAssistancePartnersCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementRemoteAssistancePartnersCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementRemoteAssistancePartnersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementRemoteAssistancePartnersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementRemoteAssistancePartnersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementRemoteAssistancePartnersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementRemoteAssistancePartnersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementRemoteAssistancePartnersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRemoteAssistancePartnerRequestBuilder"/> for the specified DeviceManagementRemoteAssistancePartner.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementRemoteAssistancePartner.</param>
        /// <returns>The <see cref="IRemoteAssistancePartnerRequestBuilder"/>.</returns>
        public IRemoteAssistancePartnerRequestBuilder this[string id]
        {
            get
            {
                return new RemoteAssistancePartnerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
