// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph.Beta
{
    /// <summary>
    /// The type DirectoryObjectGetByIdsCollectionPage.
    /// </summary>
    public partial class DirectoryObjectGetByIdsCollectionPage : CollectionPage<DirectoryObject>, IDirectoryObjectGetByIdsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IDirectoryObjectGetByIdsRequest"/> instance.
        /// </summary>
        public IDirectoryObjectGetByIdsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new DirectoryObjectGetByIdsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
