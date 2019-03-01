// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationClassTeachersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class EducationClassTeachersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IEducationClassTeachersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationClassTeachersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationClassTeachersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationClassTeachersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationClassTeachersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new EducationClassTeachersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationUserWithReferenceRequestBuilder"/> for the specified EducationClassEducationUser.
        /// </summary>
        /// <param name="id">The ID for the EducationClassEducationUser.</param>
        /// <returns>The <see cref="IEducationUserWithReferenceRequestBuilder"/>.</returns>
        public IEducationUserWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new EducationUserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IEducationClassTeachersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationClassTeachersCollectionReferencesRequestBuilder"/>.</returns>
        public IEducationClassTeachersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new EducationClassTeachersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
