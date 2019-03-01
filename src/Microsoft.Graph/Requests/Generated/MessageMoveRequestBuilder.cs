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
    /// The type MessageMoveRequestBuilder.
    /// </summary>
    public partial class MessageMoveRequestBuilder : BaseActionMethodRequestBuilder<IMessageMoveRequest>, IMessageMoveRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="MessageMoveRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="DestinationId">A DestinationId parameter for the OData method call.</param>
        public MessageMoveRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string DestinationId)
            : base(requestUrl, client)
        {
            this.SetParameter("destinationId", DestinationId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IMessageMoveRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new MessageMoveRequest(functionUrl, this.Client, options);

            if (this.HasParameter("destinationId"))
            {
                request.RequestBody.DestinationId = this.GetParameter<string>("destinationId");
            }

            return request;
        }
    }
}
