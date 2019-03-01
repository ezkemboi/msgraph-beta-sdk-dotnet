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
    /// The type WorkbookWorksheetUsedRangeRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetUsedRangeRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookWorksheetUsedRangeRequest>, IWorkbookWorksheetUsedRangeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookWorksheetUsedRangeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetUsedRangeRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Constructs a new <see cref="WorkbookWorksheetUsedRangeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="valuesOnly">A valuesOnly parameter for the OData method call.</param>
        public WorkbookWorksheetUsedRangeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool valuesOnly)
            : base(requestUrl, client)
        {
            this.SetParameter("valuesOnly", valuesOnly, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookWorksheetUsedRangeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookWorksheetUsedRangeRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
