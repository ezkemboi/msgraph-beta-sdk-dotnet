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
    /// The type PlannerPlanBucketsCollectionRequestBuilder.
    /// </summary>
    public partial class PlannerPlanBucketsCollectionRequestBuilder : BaseRequestBuilder, IPlannerPlanBucketsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PlannerPlanBucketsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerPlanBucketsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPlannerPlanBucketsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPlannerPlanBucketsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PlannerPlanBucketsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPlannerBucketRequestBuilder"/> for the specified PlannerPlanPlannerBucket.
        /// </summary>
        /// <param name="id">The ID for the PlannerPlanPlannerBucket.</param>
        /// <returns>The <see cref="IPlannerBucketRequestBuilder"/>.</returns>
        public IPlannerBucketRequestBuilder this[string id]
        {
            get
            {
                return new PlannerBucketRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
