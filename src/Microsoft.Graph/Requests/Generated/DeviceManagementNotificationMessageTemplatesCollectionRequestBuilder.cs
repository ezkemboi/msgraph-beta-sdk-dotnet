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
    /// The type DeviceManagementNotificationMessageTemplatesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementNotificationMessageTemplatesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementNotificationMessageTemplatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementNotificationMessageTemplatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementNotificationMessageTemplatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementNotificationMessageTemplatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementNotificationMessageTemplatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementNotificationMessageTemplatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="INotificationMessageTemplateRequestBuilder"/> for the specified DeviceManagementNotificationMessageTemplate.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementNotificationMessageTemplate.</param>
        /// <returns>The <see cref="INotificationMessageTemplateRequestBuilder"/>.</returns>
        public INotificationMessageTemplateRequestBuilder this[string id]
        {
            get
            {
                return new NotificationMessageTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
