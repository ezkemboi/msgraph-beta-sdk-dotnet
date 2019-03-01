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
    /// The type DeviceManagementDeviceConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationRequestBuilder"/> for the specified DeviceManagementDeviceConfiguration.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceConfiguration.</param>
        /// <returns>The <see cref="IDeviceConfigurationRequestBuilder"/>.</returns>
        public IDeviceConfigurationRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
