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
    /// The type OnenoteSectionGroupsCollectionRequestBuilder.
    /// </summary>
    public partial class OnenoteSectionGroupsCollectionRequestBuilder : BaseRequestBuilder, IOnenoteSectionGroupsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OnenoteSectionGroupsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnenoteSectionGroupsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOnenoteSectionGroupsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOnenoteSectionGroupsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OnenoteSectionGroupsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISectionGroupRequestBuilder"/> for the specified OnenoteSectionGroup.
        /// </summary>
        /// <param name="id">The ID for the OnenoteSectionGroup.</param>
        /// <returns>The <see cref="ISectionGroupRequestBuilder"/>.</returns>
        public ISectionGroupRequestBuilder this[string id]
        {
            get
            {
                return new SectionGroupRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
