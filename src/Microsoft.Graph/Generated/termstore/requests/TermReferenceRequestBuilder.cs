// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TermReferenceRequestBuilder.
    /// </summary>
    public partial class TermReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ITermReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new TermReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public TermReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITermReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITermReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new TermReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
