// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookTablesCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookTablesCollectionRequestBuilder : BaseRequestBuilder, IWorkbookTablesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookTablesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookTablesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookTablesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookTablesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookTablesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookTableRequestBuilder"/> for the specified WorkbookWorkbookTable.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorkbookTable.</param>
        /// <returns>The <see cref="IWorkbookTableRequestBuilder"/>.</returns>
        public IWorkbookTableRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookTableRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableAddRequestBuilder"/>.</returns>
        public IWorkbookTableAddRequestBuilder Add(
            bool hasHeaders,
            string address = null)
        {
            return new WorkbookTableAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                hasHeaders,
                address);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableItemAtRequestBuilder"/>.</returns>
        public IWorkbookTableItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookTableItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookTableCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableCountRequestBuilder"/>.</returns>
        public IWorkbookTableCountRequestBuilder Count()
        {
            return new WorkbookTableCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    }
}
