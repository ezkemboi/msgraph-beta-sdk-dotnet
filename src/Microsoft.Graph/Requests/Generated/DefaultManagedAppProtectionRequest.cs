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
    /// The type DefaultManagedAppProtectionRequest.
    /// </summary>
    public partial class DefaultManagedAppProtectionRequest : BaseRequest, IDefaultManagedAppProtectionRequest
    {
        /// <summary>
        /// Constructs a new DefaultManagedAppProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DefaultManagedAppProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DefaultManagedAppProtection using POST.
        /// </summary>
        /// <param name="defaultManagedAppProtectionToCreate">The DefaultManagedAppProtection to create.</param>
        /// <returns>The created DefaultManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<DefaultManagedAppProtection> CreateAsync(DefaultManagedAppProtection defaultManagedAppProtectionToCreate)
        {
            return this.CreateAsync(defaultManagedAppProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DefaultManagedAppProtection using POST.
        /// </summary>
        /// <param name="defaultManagedAppProtectionToCreate">The DefaultManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DefaultManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<DefaultManagedAppProtection> CreateAsync(DefaultManagedAppProtection defaultManagedAppProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DefaultManagedAppProtection>(defaultManagedAppProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DefaultManagedAppProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DefaultManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DefaultManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DefaultManagedAppProtection.
        /// </summary>
        /// <returns>The DefaultManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<DefaultManagedAppProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DefaultManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DefaultManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<DefaultManagedAppProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DefaultManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DefaultManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="defaultManagedAppProtectionToUpdate">The DefaultManagedAppProtection to update.</param>
        /// <returns>The updated DefaultManagedAppProtection.</returns>
        public System.Threading.Tasks.Task<DefaultManagedAppProtection> UpdateAsync(DefaultManagedAppProtection defaultManagedAppProtectionToUpdate)
        {
            return this.UpdateAsync(defaultManagedAppProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DefaultManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="defaultManagedAppProtectionToUpdate">The DefaultManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DefaultManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<DefaultManagedAppProtection> UpdateAsync(DefaultManagedAppProtection defaultManagedAppProtectionToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DefaultManagedAppProtection>(defaultManagedAppProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultManagedAppProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultManagedAppProtectionRequest Expand(Expression<Func<DefaultManagedAppProtection, object>> expandExpression)
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
        public IDefaultManagedAppProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDefaultManagedAppProtectionRequest Select(Expression<Func<DefaultManagedAppProtection, object>> selectExpression)
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
        /// <param name="defaultManagedAppProtectionToInitialize">The <see cref="DefaultManagedAppProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DefaultManagedAppProtection defaultManagedAppProtectionToInitialize)
        {

            if (defaultManagedAppProtectionToInitialize != null && defaultManagedAppProtectionToInitialize.AdditionalData != null)
            {

                if (defaultManagedAppProtectionToInitialize.Apps != null && defaultManagedAppProtectionToInitialize.Apps.CurrentPage != null)
                {
                    defaultManagedAppProtectionToInitialize.Apps.AdditionalData = defaultManagedAppProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    defaultManagedAppProtectionToInitialize.AdditionalData.TryGetValue("apps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        defaultManagedAppProtectionToInitialize.Apps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
