// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupLifecyclePolicyRequestBuilder.
    /// </summary>
    public partial class GroupLifecyclePolicyRequestBuilder : EntityRequestBuilder, IGroupLifecyclePolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupLifecyclePolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupLifecyclePolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupLifecyclePolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupLifecyclePolicyRequest Request(IEnumerable<Option> options)
        {
            return new GroupLifecyclePolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for GroupLifecyclePolicyAddGroup.
        /// </summary>
        /// <returns>The <see cref="IGroupLifecyclePolicyAddGroupRequestBuilder"/>.</returns>
        public IGroupLifecyclePolicyAddGroupRequestBuilder AddGroup(
            string groupId)
        {
            return new GroupLifecyclePolicyAddGroupRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addGroup"),
                this.Client,
                groupId);
        }

        /// <summary>
        /// Gets the request builder for GroupLifecyclePolicyRemoveGroup.
        /// </summary>
        /// <returns>The <see cref="IGroupLifecyclePolicyRemoveGroupRequestBuilder"/>.</returns>
        public IGroupLifecyclePolicyRemoveGroupRequestBuilder RemoveGroup(
            string groupId)
        {
            return new GroupLifecyclePolicyRemoveGroupRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.removeGroup"),
                this.Client,
                groupId);
        }
    
    }
}
