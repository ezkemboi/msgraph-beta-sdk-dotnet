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
    /// The interface IAuthenticationContextClassReferenceRequest.
    /// </summary>
    public partial interface IAuthenticationContextClassReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationContextClassReference using POST.
        /// </summary>
        /// <param name="authenticationContextClassReferenceToCreate">The AuthenticationContextClassReference to create.</param>
        /// <returns>The created AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> CreateAsync(AuthenticationContextClassReference authenticationContextClassReferenceToCreate);        /// <summary>
        /// Creates the specified AuthenticationContextClassReference using POST.
        /// </summary>
        /// <param name="authenticationContextClassReferenceToCreate">The AuthenticationContextClassReference to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> CreateAsync(AuthenticationContextClassReference authenticationContextClassReferenceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AuthenticationContextClassReference.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AuthenticationContextClassReference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AuthenticationContextClassReference.
        /// </summary>
        /// <returns>The AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> GetAsync();

        /// <summary>
        /// Gets the specified AuthenticationContextClassReference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AuthenticationContextClassReference using PATCH.
        /// </summary>
        /// <param name="authenticationContextClassReferenceToUpdate">The AuthenticationContextClassReference to update.</param>
        /// <returns>The updated AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> UpdateAsync(AuthenticationContextClassReference authenticationContextClassReferenceToUpdate);

        /// <summary>
        /// Updates the specified AuthenticationContextClassReference using PATCH.
        /// </summary>
        /// <param name="authenticationContextClassReferenceToUpdate">The AuthenticationContextClassReference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationContextClassReference.</returns>
        System.Threading.Tasks.Task<AuthenticationContextClassReference> UpdateAsync(AuthenticationContextClassReference authenticationContextClassReferenceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationContextClassReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationContextClassReferenceRequest Expand(Expression<Func<AuthenticationContextClassReference, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationContextClassReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationContextClassReferenceRequest Select(Expression<Func<AuthenticationContextClassReference, object>> selectExpression);

    }
}