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
    /// The type WorkbookRangeMergeRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeMergeRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookRangeMergeRequest>, IWorkbookRangeMergeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeMergeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="across">A across parameter for the OData method call.</param>
        public WorkbookRangeMergeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            bool across)
            : base(requestUrl, client)
        {
            this.SetParameter("across", across, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeMergeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeMergeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("across"))
            {
                request.RequestBody.Across = this.GetParameter<bool>("across");
            }

            return request;
        }
    }
}
