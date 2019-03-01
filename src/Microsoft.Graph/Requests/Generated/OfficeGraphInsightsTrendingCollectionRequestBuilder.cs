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
    /// The type OfficeGraphInsightsTrendingCollectionRequestBuilder.
    /// </summary>
    public partial class OfficeGraphInsightsTrendingCollectionRequestBuilder : BaseRequestBuilder, IOfficeGraphInsightsTrendingCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OfficeGraphInsightsTrendingCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OfficeGraphInsightsTrendingCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOfficeGraphInsightsTrendingCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOfficeGraphInsightsTrendingCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OfficeGraphInsightsTrendingCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITrendingRequestBuilder"/> for the specified OfficeGraphInsightsTrending.
        /// </summary>
        /// <param name="id">The ID for the OfficeGraphInsightsTrending.</param>
        /// <returns>The <see cref="ITrendingRequestBuilder"/>.</returns>
        public ITrendingRequestBuilder this[string id]
        {
            get
            {
                return new TrendingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
