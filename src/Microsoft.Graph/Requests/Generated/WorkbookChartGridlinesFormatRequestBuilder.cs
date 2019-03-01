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
    /// The type WorkbookChartGridlinesFormatRequestBuilder.
    /// </summary>
    public partial class WorkbookChartGridlinesFormatRequestBuilder : EntityRequestBuilder, IWorkbookChartGridlinesFormatRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartGridlinesFormatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartGridlinesFormatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartGridlinesFormatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartGridlinesFormatRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartGridlinesFormatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Line.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartLineFormatRequestBuilder"/>.</returns>
        public IWorkbookChartLineFormatRequestBuilder Line
        {
            get
            {
                return new WorkbookChartLineFormatRequestBuilder(this.AppendSegmentToRequestUrl("line"), this.Client);
            }
        }
    
    }
}
