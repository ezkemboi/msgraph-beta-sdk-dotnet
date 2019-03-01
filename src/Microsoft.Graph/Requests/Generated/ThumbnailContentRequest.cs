// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\StreamRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ThumbnailContentRequest.
    /// </summary>
    public partial class ThumbnailContentRequest : BaseRequest, IThumbnailContentRequest
    {
        /// <summary>
        /// Constructs a new ThumbnailContentRequest.
        /// <param name="requestUrl">The request URL.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query option name value pairs for the request.</param>
        /// </summary>
        public ThumbnailContentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <returns>The stream.</returns>
        public System.Threading.Tasks.Task<Stream> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        public System.Threading.Tasks.Task<Stream> GetAsync(CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            this.Method = "GET";
            return this.SendStreamRequestAsync(null, cancellationToken, completionOption);
        }
    
        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <returns>The object returned by the PUT call.</returns>
        public System.Threading.Tasks.Task<T> PutAsync<T>(Stream content) where T : Thumbnail
        {
            return this.PutAsync<T>(content, CancellationToken.None);
        }

        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The object returned by the PUT call.</returns>
        public System.Threading.Tasks.Task<T> PutAsync<T>(Stream content, CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead) where T : Thumbnail
        {
            this.ContentType = "application/octet-stream";
            this.Method = "PUT";
            return this.SendAsync<T>(content, cancellationToken, completionOption);
        }
    
    }
}
