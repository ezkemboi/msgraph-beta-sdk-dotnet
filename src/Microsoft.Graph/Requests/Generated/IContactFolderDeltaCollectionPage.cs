// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IMethodCollectionPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IContactFolderDeltaCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<ContactFolderDeltaCollectionPage>))]
    public interface IContactFolderDeltaCollectionPage : ICollectionPage<ContactFolder>
    {
        /// <summary>
        /// Gets the next page <see cref="IContactFolderDeltaRequest"/> instance.
        /// </summary>
        IContactFolderDeltaRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
