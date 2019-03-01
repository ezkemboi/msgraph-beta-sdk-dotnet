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
    /// The type WorkbookFunctionsAccrIntRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsAccrIntRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsAccrIntRequest>, IWorkbookFunctionsAccrIntRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsAccrIntRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="issue">A issue parameter for the OData method call.</param>
        /// <param name="firstInterest">A firstInterest parameter for the OData method call.</param>
        /// <param name="settlement">A settlement parameter for the OData method call.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="par">A par parameter for the OData method call.</param>
        /// <param name="frequency">A frequency parameter for the OData method call.</param>
        /// <param name="basis">A basis parameter for the OData method call.</param>
        /// <param name="calcMethod">A calcMethod parameter for the OData method call.</param>
        public WorkbookFunctionsAccrIntRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken issue,
            Newtonsoft.Json.Linq.JToken firstInterest,
            Newtonsoft.Json.Linq.JToken settlement,
            Newtonsoft.Json.Linq.JToken rate,
            Newtonsoft.Json.Linq.JToken par,
            Newtonsoft.Json.Linq.JToken frequency,
            Newtonsoft.Json.Linq.JToken basis,
            Newtonsoft.Json.Linq.JToken calcMethod)
            : base(requestUrl, client)
        {
            this.SetParameter("issue", issue, true);
            this.SetParameter("firstInterest", firstInterest, true);
            this.SetParameter("settlement", settlement, true);
            this.SetParameter("rate", rate, true);
            this.SetParameter("par", par, true);
            this.SetParameter("frequency", frequency, true);
            this.SetParameter("basis", basis, true);
            this.SetParameter("calcMethod", calcMethod, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsAccrIntRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsAccrIntRequest(functionUrl, this.Client, options);

            if (this.HasParameter("issue"))
            {
                request.RequestBody.Issue = this.GetParameter<Newtonsoft.Json.Linq.JToken>("issue");
            }

            if (this.HasParameter("firstInterest"))
            {
                request.RequestBody.FirstInterest = this.GetParameter<Newtonsoft.Json.Linq.JToken>("firstInterest");
            }

            if (this.HasParameter("settlement"))
            {
                request.RequestBody.Settlement = this.GetParameter<Newtonsoft.Json.Linq.JToken>("settlement");
            }

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<Newtonsoft.Json.Linq.JToken>("rate");
            }

            if (this.HasParameter("par"))
            {
                request.RequestBody.Par = this.GetParameter<Newtonsoft.Json.Linq.JToken>("par");
            }

            if (this.HasParameter("frequency"))
            {
                request.RequestBody.Frequency = this.GetParameter<Newtonsoft.Json.Linq.JToken>("frequency");
            }

            if (this.HasParameter("basis"))
            {
                request.RequestBody.Basis = this.GetParameter<Newtonsoft.Json.Linq.JToken>("basis");
            }

            if (this.HasParameter("calcMethod"))
            {
                request.RequestBody.CalcMethod = this.GetParameter<Newtonsoft.Json.Linq.JToken>("calcMethod");
            }

            return request;
        }
    }
}
