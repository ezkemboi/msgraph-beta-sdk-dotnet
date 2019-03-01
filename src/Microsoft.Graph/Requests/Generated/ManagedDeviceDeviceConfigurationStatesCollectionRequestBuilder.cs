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
    /// The type ManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder : BaseRequestBuilder, IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedDeviceDeviceConfigurationStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedDeviceDeviceConfigurationStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceDeviceConfigurationStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationStateRequestBuilder"/> for the specified ManagedDeviceDeviceConfigurationState.
        /// </summary>
        /// <param name="id">The ID for the ManagedDeviceDeviceConfigurationState.</param>
        /// <returns>The <see cref="IDeviceConfigurationStateRequestBuilder"/>.</returns>
        public IDeviceConfigurationStateRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
