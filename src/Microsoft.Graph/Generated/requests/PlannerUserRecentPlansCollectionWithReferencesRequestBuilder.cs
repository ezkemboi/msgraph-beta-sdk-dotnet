// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PlannerUserRecentPlansCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class PlannerUserRecentPlansCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IPlannerUserRecentPlansCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlannerUserRecentPlansCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerUserRecentPlansCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPlannerUserRecentPlansCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPlannerUserRecentPlansCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new PlannerUserRecentPlansCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPlannerPlanWithReferenceRequestBuilder"/> for the specified PlannerUserPlannerPlan.
        /// </summary>
        /// <param name="id">The ID for the PlannerUserPlannerPlan.</param>
        /// <returns>The <see cref="IPlannerPlanWithReferenceRequestBuilder"/>.</returns>
        public IPlannerPlanWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new PlannerPlanWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IPlannerUserRecentPlansCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPlannerUserRecentPlansCollectionReferencesRequestBuilder"/>.</returns>
        public IPlannerUserRecentPlansCollectionReferencesRequestBuilder References
        {
            get
            {
                return new PlannerUserRecentPlansCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
