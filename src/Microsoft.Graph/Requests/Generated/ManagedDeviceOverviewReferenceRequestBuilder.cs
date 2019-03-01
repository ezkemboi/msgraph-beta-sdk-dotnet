// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedDeviceOverviewReferenceRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceOverviewReferenceRequestBuilder : BaseRequestBuilder, IManagedDeviceOverviewReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedDeviceOverviewReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceOverviewReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedDeviceOverviewReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedDeviceOverviewReferenceRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceOverviewReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
