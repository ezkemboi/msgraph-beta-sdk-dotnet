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
    /// The type WorkbookFunctionsNegBinom_DistRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsNegBinom_DistRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsNegBinom_DistRequest>, IWorkbookFunctionsNegBinom_DistRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsNegBinom_DistRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="numberF">A numberF parameter for the OData method call.</param>
        /// <param name="numberS">A numberS parameter for the OData method call.</param>
        /// <param name="probabilityS">A probabilityS parameter for the OData method call.</param>
        /// <param name="cumulative">A cumulative parameter for the OData method call.</param>
        public WorkbookFunctionsNegBinom_DistRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken numberF,
            Newtonsoft.Json.Linq.JToken numberS,
            Newtonsoft.Json.Linq.JToken probabilityS,
            Newtonsoft.Json.Linq.JToken cumulative)
            : base(requestUrl, client)
        {
            this.SetParameter("numberF", numberF, true);
            this.SetParameter("numberS", numberS, true);
            this.SetParameter("probabilityS", probabilityS, true);
            this.SetParameter("cumulative", cumulative, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsNegBinom_DistRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsNegBinom_DistRequest(functionUrl, this.Client, options);

            if (this.HasParameter("numberF"))
            {
                request.RequestBody.NumberF = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numberF");
            }

            if (this.HasParameter("numberS"))
            {
                request.RequestBody.NumberS = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numberS");
            }

            if (this.HasParameter("probabilityS"))
            {
                request.RequestBody.ProbabilityS = this.GetParameter<Newtonsoft.Json.Linq.JToken>("probabilityS");
            }

            if (this.HasParameter("cumulative"))
            {
                request.RequestBody.Cumulative = this.GetParameter<Newtonsoft.Json.Linq.JToken>("cumulative");
            }

            return request;
        }
    }
}
