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
    /// The interface IIosVppEBookRequest.
    /// </summary>
    public partial interface IIosVppEBookRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVppEBook using PUT.
        /// </summary>
        /// <param name="iosVppEBookToCreate">The IosVppEBook to create.</param>
        /// <returns>The created IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> CreateAsync(IosVppEBook iosVppEBookToCreate);        /// <summary>
        /// Creates the specified IosVppEBook using PUT.
        /// </summary>
        /// <param name="iosVppEBookToCreate">The IosVppEBook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> CreateAsync(IosVppEBook iosVppEBookToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppEBook.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosVppEBook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVppEBook.
        /// </summary>
        /// <returns>The IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> GetAsync();

        /// <summary>
        /// Gets the specified IosVppEBook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVppEBook using PATCH.
        /// </summary>
        /// <param name="iosVppEBookToUpdate">The IosVppEBook to update.</param>
        /// <returns>The updated IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> UpdateAsync(IosVppEBook iosVppEBookToUpdate);

        /// <summary>
        /// Updates the specified IosVppEBook using PATCH.
        /// </summary>
        /// <param name="iosVppEBookToUpdate">The IosVppEBook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosVppEBook.</returns>
        System.Threading.Tasks.Task<IosVppEBook> UpdateAsync(IosVppEBook iosVppEBookToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookRequest Expand(Expression<Func<IosVppEBook, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookRequest Select(Expression<Func<IosVppEBook, object>> selectExpression);

    }
}
