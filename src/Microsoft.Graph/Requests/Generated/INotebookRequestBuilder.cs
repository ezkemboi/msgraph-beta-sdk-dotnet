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
    /// The interface INotebookRequestBuilder.
    /// </summary>
    public partial interface INotebookRequestBuilder : IOnenoteEntityHierarchyModelRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new INotebookRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new INotebookRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Sections.
        /// </summary>
        /// <returns>The <see cref="INotebookSectionsCollectionRequestBuilder"/>.</returns>
        INotebookSectionsCollectionRequestBuilder Sections { get; }

        /// <summary>
        /// Gets the request builder for SectionGroups.
        /// </summary>
        /// <returns>The <see cref="INotebookSectionGroupsCollectionRequestBuilder"/>.</returns>
        INotebookSectionGroupsCollectionRequestBuilder SectionGroups { get; }
    
        /// <summary>
        /// Gets the request builder for NotebookCopyNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookCopyNotebookRequestBuilder"/>.</returns>
        INotebookCopyNotebookRequestBuilder CopyNotebook(
            string groupId = null,
            string renameAs = null,
            string notebookFolder = null,
            string siteCollectionId = null,
            string siteId = null);
    
    }
}
