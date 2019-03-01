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
    /// The type WorkbookFunctionsHyperlinkRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsHyperlinkRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsHyperlinkRequest>, IWorkbookFunctionsHyperlinkRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsHyperlinkRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="linkLocation">A linkLocation parameter for the OData method call.</param>
        /// <param name="friendlyName">A friendlyName parameter for the OData method call.</param>
        public WorkbookFunctionsHyperlinkRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken linkLocation,
            Newtonsoft.Json.Linq.JToken friendlyName)
            : base(requestUrl, client)
        {
            this.SetParameter("linkLocation", linkLocation, true);
            this.SetParameter("friendlyName", friendlyName, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsHyperlinkRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsHyperlinkRequest(functionUrl, this.Client, options);

            if (this.HasParameter("linkLocation"))
            {
                request.RequestBody.LinkLocation = this.GetParameter<Newtonsoft.Json.Linq.JToken>("linkLocation");
            }

            if (this.HasParameter("friendlyName"))
            {
                request.RequestBody.FriendlyName = this.GetParameter<Newtonsoft.Json.Linq.JToken>("friendlyName");
            }

            return request;
        }
    }
}
