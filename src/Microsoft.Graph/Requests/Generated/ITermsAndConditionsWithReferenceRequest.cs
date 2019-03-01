// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITermsAndConditionsWithReferenceRequest.
    /// </summary>
    public partial interface ITermsAndConditionsWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <returns>The TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> GetAsync();

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TermsAndConditions using PUT.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <returns>The created TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate);        /// <summary>
        /// Creates the specified TermsAndConditions using PUT.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <returns>The updated TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate);

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TermsAndConditions.</returns>
        System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsWithReferenceRequest Expand(Expression<Func<TermsAndConditions, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITermsAndConditionsWithReferenceRequest Select(Expression<Func<TermsAndConditions, object>> selectExpression);

    }
}
