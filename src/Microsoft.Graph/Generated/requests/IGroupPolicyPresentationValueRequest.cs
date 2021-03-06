// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGroupPolicyPresentationValueRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationValueRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationValue using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToCreate">The GroupPolicyPresentationValue to create.</param>
        /// <returns>The created GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> CreateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationValue using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToCreate">The GroupPolicyPresentationValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> CreateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <returns>The GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue to update.</param>
        /// <returns>The updated GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> UpdateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueToUpdate">The GroupPolicyPresentationValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationValue.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValue> UpdateAsync(GroupPolicyPresentationValue groupPolicyPresentationValueToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Expand(Expression<Func<GroupPolicyPresentationValue, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueRequest Select(Expression<Func<GroupPolicyPresentationValue, object>> selectExpression);

    }
}
