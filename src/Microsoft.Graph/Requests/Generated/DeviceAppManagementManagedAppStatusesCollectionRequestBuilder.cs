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
    /// The type DeviceAppManagementManagedAppStatusesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementManagedAppStatusesCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementManagedAppStatusesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementManagedAppStatusesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedAppStatusesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementManagedAppStatusesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementManagedAppStatusesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedAppStatusRequestBuilder"/> for the specified DeviceAppManagementManagedAppStatus.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementManagedAppStatus.</param>
        /// <returns>The <see cref="IManagedAppStatusRequestBuilder"/>.</returns>
        public IManagedAppStatusRequestBuilder this[string id]
        {
            get
            {
                return new ManagedAppStatusRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
