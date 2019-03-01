// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PostRequest.
    /// </summary>
    public partial class PostRequest : BaseRequest, IPostRequest
    {
        /// <summary>
        /// Constructs a new PostRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PostRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Post using POST.
        /// </summary>
        /// <param name="postToCreate">The Post to create.</param>
        /// <returns>The created Post.</returns>
        public System.Threading.Tasks.Task<Post> CreateAsync(Post postToCreate)
        {
            return this.CreateAsync(postToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Post using POST.
        /// </summary>
        /// <param name="postToCreate">The Post to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Post.</returns>
        public async System.Threading.Tasks.Task<Post> CreateAsync(Post postToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Post>(postToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Post.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Post.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Post>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Post.
        /// </summary>
        /// <returns>The Post.</returns>
        public System.Threading.Tasks.Task<Post> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Post.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Post.</returns>
        public async System.Threading.Tasks.Task<Post> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Post>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Post using PATCH.
        /// </summary>
        /// <param name="postToUpdate">The Post to update.</param>
        /// <returns>The updated Post.</returns>
        public System.Threading.Tasks.Task<Post> UpdateAsync(Post postToUpdate)
        {
            return this.UpdateAsync(postToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Post using PATCH.
        /// </summary>
        /// <param name="postToUpdate">The Post to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Post.</returns>
        public async System.Threading.Tasks.Task<Post> UpdateAsync(Post postToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Post>(postToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPostRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPostRequest Expand(Expression<Func<Post, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IPostRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPostRequest Select(Expression<Func<Post, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="postToInitialize">The <see cref="Post"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Post postToInitialize)
        {

            if (postToInitialize != null && postToInitialize.AdditionalData != null)
            {

                if (postToInitialize.Extensions != null && postToInitialize.Extensions.CurrentPage != null)
                {
                    postToInitialize.Extensions.AdditionalData = postToInitialize.AdditionalData;

                    object nextPageLink;
                    postToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        postToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (postToInitialize.Attachments != null && postToInitialize.Attachments.CurrentPage != null)
                {
                    postToInitialize.Attachments.AdditionalData = postToInitialize.AdditionalData;

                    object nextPageLink;
                    postToInitialize.AdditionalData.TryGetValue("attachments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        postToInitialize.Attachments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (postToInitialize.SingleValueExtendedProperties != null && postToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    postToInitialize.SingleValueExtendedProperties.AdditionalData = postToInitialize.AdditionalData;

                    object nextPageLink;
                    postToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        postToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (postToInitialize.MultiValueExtendedProperties != null && postToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    postToInitialize.MultiValueExtendedProperties.AdditionalData = postToInitialize.AdditionalData;

                    object nextPageLink;
                    postToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        postToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
