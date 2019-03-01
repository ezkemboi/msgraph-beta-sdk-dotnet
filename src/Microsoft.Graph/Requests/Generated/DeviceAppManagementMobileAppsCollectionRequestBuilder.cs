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
    /// The type DeviceAppManagementMobileAppsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementMobileAppsCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementMobileAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementMobileAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementMobileAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementMobileAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementMobileAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementMobileAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMobileAppRequestBuilder"/> for the specified DeviceAppManagementMobileApp.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementMobileApp.</param>
        /// <returns>The <see cref="IMobileAppRequestBuilder"/>.</returns>
        public IMobileAppRequestBuilder this[string id]
        {
            get
            {
                return new MobileAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
