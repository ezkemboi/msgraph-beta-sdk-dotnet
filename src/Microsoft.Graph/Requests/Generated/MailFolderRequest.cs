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
    /// The type MailFolderRequest.
    /// </summary>
    public partial class MailFolderRequest : BaseRequest, IMailFolderRequest
    {
        /// <summary>
        /// Constructs a new MailFolderRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MailFolderRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MailFolder using POST.
        /// </summary>
        /// <param name="mailFolderToCreate">The MailFolder to create.</param>
        /// <returns>The created MailFolder.</returns>
        public System.Threading.Tasks.Task<MailFolder> CreateAsync(MailFolder mailFolderToCreate)
        {
            return this.CreateAsync(mailFolderToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MailFolder using POST.
        /// </summary>
        /// <param name="mailFolderToCreate">The MailFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailFolder.</returns>
        public async System.Threading.Tasks.Task<MailFolder> CreateAsync(MailFolder mailFolderToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MailFolder>(mailFolderToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MailFolder.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MailFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MailFolder>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MailFolder.
        /// </summary>
        /// <returns>The MailFolder.</returns>
        public System.Threading.Tasks.Task<MailFolder> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MailFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailFolder.</returns>
        public async System.Threading.Tasks.Task<MailFolder> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MailFolder>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MailFolder using PATCH.
        /// </summary>
        /// <param name="mailFolderToUpdate">The MailFolder to update.</param>
        /// <returns>The updated MailFolder.</returns>
        public System.Threading.Tasks.Task<MailFolder> UpdateAsync(MailFolder mailFolderToUpdate)
        {
            return this.UpdateAsync(mailFolderToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MailFolder using PATCH.
        /// </summary>
        /// <param name="mailFolderToUpdate">The MailFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MailFolder.</returns>
        public async System.Threading.Tasks.Task<MailFolder> UpdateAsync(MailFolder mailFolderToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MailFolder>(mailFolderToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMailFolderRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMailFolderRequest Expand(Expression<Func<MailFolder, object>> expandExpression)
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
        public IMailFolderRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMailFolderRequest Select(Expression<Func<MailFolder, object>> selectExpression)
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
        /// <param name="mailFolderToInitialize">The <see cref="MailFolder"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MailFolder mailFolderToInitialize)
        {

            if (mailFolderToInitialize != null && mailFolderToInitialize.AdditionalData != null)
            {

                if (mailFolderToInitialize.Messages != null && mailFolderToInitialize.Messages.CurrentPage != null)
                {
                    mailFolderToInitialize.Messages.AdditionalData = mailFolderToInitialize.AdditionalData;

                    object nextPageLink;
                    mailFolderToInitialize.AdditionalData.TryGetValue("messages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mailFolderToInitialize.Messages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (mailFolderToInitialize.MessageRules != null && mailFolderToInitialize.MessageRules.CurrentPage != null)
                {
                    mailFolderToInitialize.MessageRules.AdditionalData = mailFolderToInitialize.AdditionalData;

                    object nextPageLink;
                    mailFolderToInitialize.AdditionalData.TryGetValue("messageRules@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mailFolderToInitialize.MessageRules.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (mailFolderToInitialize.ChildFolders != null && mailFolderToInitialize.ChildFolders.CurrentPage != null)
                {
                    mailFolderToInitialize.ChildFolders.AdditionalData = mailFolderToInitialize.AdditionalData;

                    object nextPageLink;
                    mailFolderToInitialize.AdditionalData.TryGetValue("childFolders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mailFolderToInitialize.ChildFolders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (mailFolderToInitialize.SingleValueExtendedProperties != null && mailFolderToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    mailFolderToInitialize.SingleValueExtendedProperties.AdditionalData = mailFolderToInitialize.AdditionalData;

                    object nextPageLink;
                    mailFolderToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mailFolderToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (mailFolderToInitialize.MultiValueExtendedProperties != null && mailFolderToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    mailFolderToInitialize.MultiValueExtendedProperties.AdditionalData = mailFolderToInitialize.AdditionalData;

                    object nextPageLink;
                    mailFolderToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mailFolderToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
