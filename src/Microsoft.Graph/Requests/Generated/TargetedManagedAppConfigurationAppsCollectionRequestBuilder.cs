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
    /// The type TargetedManagedAppConfigurationAppsCollectionRequestBuilder.
    /// </summary>
    public partial class TargetedManagedAppConfigurationAppsCollectionRequestBuilder : BaseRequestBuilder, ITargetedManagedAppConfigurationAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TargetedManagedAppConfigurationAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TargetedManagedAppConfigurationAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITargetedManagedAppConfigurationAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITargetedManagedAppConfigurationAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TargetedManagedAppConfigurationAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedMobileAppRequestBuilder"/> for the specified TargetedManagedAppConfigurationManagedMobileApp.
        /// </summary>
        /// <param name="id">The ID for the TargetedManagedAppConfigurationManagedMobileApp.</param>
        /// <returns>The <see cref="IManagedMobileAppRequestBuilder"/>.</returns>
        public IManagedMobileAppRequestBuilder this[string id]
        {
            get
            {
                return new ManagedMobileAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
