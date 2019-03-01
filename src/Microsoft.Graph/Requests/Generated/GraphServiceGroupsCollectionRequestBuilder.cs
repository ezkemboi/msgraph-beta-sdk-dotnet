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
    /// The type GraphServiceGroupsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceGroupsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceGroupsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceGroupsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceGroupsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceGroupsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceGroupsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceGroupsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGroupRequestBuilder"/> for the specified GraphServiceGroup.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceGroup.</param>
        /// <returns>The <see cref="IGroupRequestBuilder"/>.</returns>
        public IGroupRequestBuilder this[string id]
        {
            get
            {
                return new GroupRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for GroupDelta.
        /// </summary>
        /// <returns>The <see cref="IGroupDeltaRequestBuilder"/>.</returns>
        public IGroupDeltaRequestBuilder Delta()
        {
            return new GroupDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
