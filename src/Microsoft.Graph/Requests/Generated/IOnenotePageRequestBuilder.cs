// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOnenotePageRequestBuilder.
    /// </summary>
    public partial interface IOnenotePageRequestBuilder : IOnenoteEntitySchemaObjectModelRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOnenotePageRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOnenotePageRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ParentSection.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionRequestBuilder"/>.</returns>
        IOnenoteSectionRequestBuilder ParentSection { get; }

        /// <summary>
        /// Gets the request builder for ParentNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        INotebookRequestBuilder ParentNotebook { get; }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IOnenotePageContentRequestBuilder"/>.</returns>
        IOnenotePageContentRequestBuilder Content { get; }
    
        /// <summary>
        /// Gets the request builder for OnenotePageOnenotePatchContent.
        /// </summary>
        /// <returns>The <see cref="IOnenotePageOnenotePatchContentRequestBuilder"/>.</returns>
        IOnenotePageOnenotePatchContentRequestBuilder OnenotePatchContent(
            IEnumerable<OnenotePatchContentCommand> commands = null);

        /// <summary>
        /// Gets the request builder for OnenotePageCopyToSection.
        /// </summary>
        /// <returns>The <see cref="IOnenotePageCopyToSectionRequestBuilder"/>.</returns>
        IOnenotePageCopyToSectionRequestBuilder CopyToSection(
            string id = null,
            string groupId = null,
            string siteCollectionId = null,
            string siteId = null);

        /// <summary>
        /// Gets the request builder for OnenotePagePreview.
        /// </summary>
        /// <returns>The <see cref="IOnenotePagePreviewRequestBuilder"/>.</returns>
        IOnenotePagePreviewRequestBuilder Preview();
    
    }
}
