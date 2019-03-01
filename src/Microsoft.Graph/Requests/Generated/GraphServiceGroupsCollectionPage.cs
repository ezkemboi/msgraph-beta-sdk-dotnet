// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;

    /// <summary>
    /// The type GraphServiceGroupsCollectionPage.
    /// </summary>
    public partial class GraphServiceGroupsCollectionPage : CollectionPage<Group>, IGraphServiceGroupsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceGroupsCollectionRequest"/> instance.
        /// </summary>
        public IGraphServiceGroupsCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new GraphServiceGroupsCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
