// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IExactMatchDataStoreRequest.
    /// </summary>
    public partial interface IExactMatchDataStoreRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExactMatchDataStore using POST.
        /// </summary>
        /// <param name="exactMatchDataStoreToCreate">The ExactMatchDataStore to create.</param>
        /// <returns>The created ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> CreateAsync(ExactMatchDataStore exactMatchDataStoreToCreate);        /// <summary>
        /// Creates the specified ExactMatchDataStore using POST.
        /// </summary>
        /// <param name="exactMatchDataStoreToCreate">The ExactMatchDataStore to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> CreateAsync(ExactMatchDataStore exactMatchDataStoreToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ExactMatchDataStore.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ExactMatchDataStore.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ExactMatchDataStore.
        /// </summary>
        /// <returns>The ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> GetAsync();

        /// <summary>
        /// Gets the specified ExactMatchDataStore.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ExactMatchDataStore using PATCH.
        /// </summary>
        /// <param name="exactMatchDataStoreToUpdate">The ExactMatchDataStore to update.</param>
        /// <returns>The updated ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> UpdateAsync(ExactMatchDataStore exactMatchDataStoreToUpdate);

        /// <summary>
        /// Updates the specified ExactMatchDataStore using PATCH.
        /// </summary>
        /// <param name="exactMatchDataStoreToUpdate">The ExactMatchDataStore to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExactMatchDataStore.</returns>
        System.Threading.Tasks.Task<ExactMatchDataStore> UpdateAsync(ExactMatchDataStore exactMatchDataStoreToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchDataStoreRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchDataStoreRequest Expand(Expression<Func<ExactMatchDataStore, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchDataStoreRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExactMatchDataStoreRequest Select(Expression<Func<ExactMatchDataStore, object>> selectExpression);

    }
}