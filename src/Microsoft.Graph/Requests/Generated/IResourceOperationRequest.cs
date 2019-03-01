// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IResourceOperationRequest.
    /// </summary>
    public partial interface IResourceOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ResourceOperation using PUT.
        /// </summary>
        /// <param name="resourceOperationToCreate">The ResourceOperation to create.</param>
        /// <returns>The created ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> CreateAsync(ResourceOperation resourceOperationToCreate);        /// <summary>
        /// Creates the specified ResourceOperation using PUT.
        /// </summary>
        /// <param name="resourceOperationToCreate">The ResourceOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> CreateAsync(ResourceOperation resourceOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ResourceOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ResourceOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ResourceOperation.
        /// </summary>
        /// <returns>The ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> GetAsync();

        /// <summary>
        /// Gets the specified ResourceOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ResourceOperation using PATCH.
        /// </summary>
        /// <param name="resourceOperationToUpdate">The ResourceOperation to update.</param>
        /// <returns>The updated ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> UpdateAsync(ResourceOperation resourceOperationToUpdate);

        /// <summary>
        /// Updates the specified ResourceOperation using PATCH.
        /// </summary>
        /// <param name="resourceOperationToUpdate">The ResourceOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ResourceOperation.</returns>
        System.Threading.Tasks.Task<ResourceOperation> UpdateAsync(ResourceOperation resourceOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IResourceOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IResourceOperationRequest Expand(Expression<Func<ResourceOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IResourceOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IResourceOperationRequest Select(Expression<Func<ResourceOperation, object>> selectExpression);

    }
}
