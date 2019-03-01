// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookWorksheetCellRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetCellRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookWorksheetCellRequest>, IWorkbookWorksheetCellRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookWorksheetCellRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="row">A row parameter for the OData method call.</param>
        /// <param name="column">A column parameter for the OData method call.</param>
        public WorkbookWorksheetCellRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 row,
            Int32 column)
            : base(requestUrl, client)
        {
            this.SetParameter("row", row, false);
            this.SetParameter("column", column, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookWorksheetCellRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookWorksheetCellRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
