// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IEducationSchoolUsersCollectionWithReferencesPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<EducationSchoolUsersCollectionWithReferencesPage>))]
    public interface IEducationSchoolUsersCollectionWithReferencesPage : ICollectionPage<EducationUser>
    {
        /// <summary>
        /// Gets the next page <see cref="IEducationSchoolUsersCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IEducationSchoolUsersCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
