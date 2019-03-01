// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupMembersWithLicenseErrorsCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class GroupMembersWithLicenseErrorsCollectionReferencesRequestBuilder : BaseRequestBuilder, IGroupMembersWithLicenseErrorsCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupMembersWithLicenseErrorsCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupMembersWithLicenseErrorsCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupMembersWithLicenseErrorsCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupMembersWithLicenseErrorsCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new GroupMembersWithLicenseErrorsCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
