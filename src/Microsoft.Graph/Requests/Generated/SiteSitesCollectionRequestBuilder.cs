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
    /// The type SiteSitesCollectionRequestBuilder.
    /// </summary>
    public partial class SiteSitesCollectionRequestBuilder : BaseRequestBuilder, ISiteSitesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SiteSitesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SiteSitesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISiteSitesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISiteSitesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SiteSitesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISiteRequestBuilder"/> for the specified SiteSite.
        /// </summary>
        /// <param name="id">The ID for the SiteSite.</param>
        /// <returns>The <see cref="ISiteRequestBuilder"/>.</returns>
        public ISiteRequestBuilder this[string id]
        {
            get
            {
                return new SiteRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
