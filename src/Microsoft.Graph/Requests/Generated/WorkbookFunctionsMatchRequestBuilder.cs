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
    /// The type WorkbookFunctionsMatchRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsMatchRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsMatchRequest>, IWorkbookFunctionsMatchRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsMatchRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="lookupValue">A lookupValue parameter for the OData method call.</param>
        /// <param name="lookupArray">A lookupArray parameter for the OData method call.</param>
        /// <param name="matchType">A matchType parameter for the OData method call.</param>
        public WorkbookFunctionsMatchRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken lookupValue,
            Newtonsoft.Json.Linq.JToken lookupArray,
            Newtonsoft.Json.Linq.JToken matchType)
            : base(requestUrl, client)
        {
            this.SetParameter("lookupValue", lookupValue, true);
            this.SetParameter("lookupArray", lookupArray, true);
            this.SetParameter("matchType", matchType, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsMatchRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsMatchRequest(functionUrl, this.Client, options);

            if (this.HasParameter("lookupValue"))
            {
                request.RequestBody.LookupValue = this.GetParameter<Newtonsoft.Json.Linq.JToken>("lookupValue");
            }

            if (this.HasParameter("lookupArray"))
            {
                request.RequestBody.LookupArray = this.GetParameter<Newtonsoft.Json.Linq.JToken>("lookupArray");
            }

            if (this.HasParameter("matchType"))
            {
                request.RequestBody.MatchType = this.GetParameter<Newtonsoft.Json.Linq.JToken>("matchType");
            }

            return request;
        }
    }
}
