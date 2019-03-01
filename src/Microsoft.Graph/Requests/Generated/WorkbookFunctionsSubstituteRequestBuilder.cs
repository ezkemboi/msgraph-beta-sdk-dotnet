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
    /// The type WorkbookFunctionsSubstituteRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsSubstituteRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsSubstituteRequest>, IWorkbookFunctionsSubstituteRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsSubstituteRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="text">A text parameter for the OData method call.</param>
        /// <param name="oldText">A oldText parameter for the OData method call.</param>
        /// <param name="newText">A newText parameter for the OData method call.</param>
        /// <param name="instanceNum">A instanceNum parameter for the OData method call.</param>
        public WorkbookFunctionsSubstituteRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken text,
            Newtonsoft.Json.Linq.JToken oldText,
            Newtonsoft.Json.Linq.JToken newText,
            Newtonsoft.Json.Linq.JToken instanceNum)
            : base(requestUrl, client)
        {
            this.SetParameter("text", text, true);
            this.SetParameter("oldText", oldText, true);
            this.SetParameter("newText", newText, true);
            this.SetParameter("instanceNum", instanceNum, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsSubstituteRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsSubstituteRequest(functionUrl, this.Client, options);

            if (this.HasParameter("text"))
            {
                request.RequestBody.Text = this.GetParameter<Newtonsoft.Json.Linq.JToken>("text");
            }

            if (this.HasParameter("oldText"))
            {
                request.RequestBody.OldText = this.GetParameter<Newtonsoft.Json.Linq.JToken>("oldText");
            }

            if (this.HasParameter("newText"))
            {
                request.RequestBody.NewText = this.GetParameter<Newtonsoft.Json.Linq.JToken>("newText");
            }

            if (this.HasParameter("instanceNum"))
            {
                request.RequestBody.InstanceNum = this.GetParameter<Newtonsoft.Json.Linq.JToken>("instanceNum");
            }

            return request;
        }
    }
}
