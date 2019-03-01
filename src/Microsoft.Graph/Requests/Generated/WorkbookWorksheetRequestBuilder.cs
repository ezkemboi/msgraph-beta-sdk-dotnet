// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookWorksheetRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetRequestBuilder : EntityRequestBuilder, IWorkbookWorksheetRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookWorksheetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookWorksheetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookWorksheetRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Charts.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetChartsCollectionRequestBuilder"/>.</returns>
        public IWorkbookWorksheetChartsCollectionRequestBuilder Charts
        {
            get
            {
                return new WorkbookWorksheetChartsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("charts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Names.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetNamesCollectionRequestBuilder"/>.</returns>
        public IWorkbookWorksheetNamesCollectionRequestBuilder Names
        {
            get
            {
                return new WorkbookWorksheetNamesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("names"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PivotTables.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetPivotTablesCollectionRequestBuilder"/>.</returns>
        public IWorkbookWorksheetPivotTablesCollectionRequestBuilder PivotTables
        {
            get
            {
                return new WorkbookWorksheetPivotTablesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("pivotTables"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Protection.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetProtectionRequestBuilder"/>.</returns>
        public IWorkbookWorksheetProtectionRequestBuilder Protection
        {
            get
            {
                return new WorkbookWorksheetProtectionRequestBuilder(this.AppendSegmentToRequestUrl("protection"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tables.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetTablesCollectionRequestBuilder"/>.</returns>
        public IWorkbookWorksheetTablesCollectionRequestBuilder Tables
        {
            get
            {
                return new WorkbookWorksheetTablesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tables"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookWorksheetCell.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetCellRequestBuilder"/>.</returns>
        public IWorkbookWorksheetCellRequestBuilder Cell(
            Int32 row,
            Int32 column)
        {
            return new WorkbookWorksheetCellRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cell"),
                this.Client,
                row,
                column);
        }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRangeRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRangeRequestBuilder Range()
        {
            return new WorkbookWorksheetRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRangeRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRangeRequestBuilder Range(
            string address = null)
        {
            return new WorkbookWorksheetRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.range"),
                this.Client,
                address);
        }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetUsedRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetUsedRangeRequestBuilder"/>.</returns>
        public IWorkbookWorksheetUsedRangeRequestBuilder UsedRange()
        {
            return new WorkbookWorksheetUsedRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.usedRange"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WorkbookWorksheetUsedRange.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetUsedRangeRequestBuilder"/>.</returns>
        public IWorkbookWorksheetUsedRangeRequestBuilder UsedRange(
            bool valuesOnly)
        {
            return new WorkbookWorksheetUsedRangeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.usedRange"),
                this.Client,
                valuesOnly);
        }
    
    }
}
