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
    /// The type WorkbookFunctionsBitrshiftRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsBitrshiftRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsBitrshiftRequest>, IWorkbookFunctionsBitrshiftRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsBitrshiftRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="shiftAmount">A shiftAmount parameter for the OData method call.</param>
        public WorkbookFunctionsBitrshiftRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken number,
            Newtonsoft.Json.Linq.JToken shiftAmount)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("shiftAmount", shiftAmount, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsBitrshiftRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsBitrshiftRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<Newtonsoft.Json.Linq.JToken>("number");
            }

            if (this.HasParameter("shiftAmount"))
            {
                request.RequestBody.ShiftAmount = this.GetParameter<Newtonsoft.Json.Linq.JToken>("shiftAmount");
            }

            return request;
        }
    }
}
