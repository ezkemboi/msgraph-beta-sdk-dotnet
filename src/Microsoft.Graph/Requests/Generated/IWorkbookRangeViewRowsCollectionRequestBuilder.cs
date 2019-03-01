// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookRangeViewRowsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeViewRowsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookRangeViewRowsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookRangeViewRowsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookRangeViewRequestBuilder"/> for the specified WorkbookRangeView.
        /// </summary>
        /// <param name="id">The ID for the WorkbookRangeView.</param>
        /// <returns>The <see cref="IWorkbookRangeViewRequestBuilder"/>.</returns>
        IWorkbookRangeViewRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookRangeViewItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeViewItemAtRequestBuilder"/>.</returns>
        IWorkbookRangeViewItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
