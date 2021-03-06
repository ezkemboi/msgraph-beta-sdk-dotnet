// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TeamsAppDefinitionWithReferenceRequestBuilder.
    /// </summary>
    public partial class TeamsAppDefinitionWithReferenceRequestBuilder : BaseRequestBuilder, ITeamsAppDefinitionWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new TeamsAppDefinitionWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamsAppDefinitionWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamsAppDefinitionWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamsAppDefinitionWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new TeamsAppDefinitionWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the teamsAppDefinition.
        /// </summary>
        /// <returns>The <see cref="ITeamsAppDefinitionReferenceRequestBuilder"/>.</returns>
        public ITeamsAppDefinitionReferenceRequestBuilder Reference
        {
            get
            {
                return new TeamsAppDefinitionReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
