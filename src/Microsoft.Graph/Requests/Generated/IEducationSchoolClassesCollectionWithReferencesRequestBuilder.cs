// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IEducationSchoolClassesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IEducationSchoolClassesCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IEducationSchoolClassesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IEducationSchoolClassesCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEducationClassWithReferenceRequestBuilder"/> for the specified EducationClass.
        /// </summary>
        /// <param name="id">The ID for the EducationClass.</param>
        /// <returns>The <see cref="IEducationClassWithReferenceRequestBuilder"/>.</returns>
        IEducationClassWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IEducationSchoolClassesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolClassesCollectionReferencesRequestBuilder"/>.</returns>
        IEducationSchoolClassesCollectionReferencesRequestBuilder References { get; }

    }
}
