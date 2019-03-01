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
    /// The interface IMessageRuleRequest.
    /// </summary>
    public partial interface IMessageRuleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MessageRule using PUT.
        /// </summary>
        /// <param name="messageRuleToCreate">The MessageRule to create.</param>
        /// <returns>The created MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> CreateAsync(MessageRule messageRuleToCreate);        /// <summary>
        /// Creates the specified MessageRule using PUT.
        /// </summary>
        /// <param name="messageRuleToCreate">The MessageRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> CreateAsync(MessageRule messageRuleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MessageRule.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MessageRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MessageRule.
        /// </summary>
        /// <returns>The MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> GetAsync();

        /// <summary>
        /// Gets the specified MessageRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MessageRule using PATCH.
        /// </summary>
        /// <param name="messageRuleToUpdate">The MessageRule to update.</param>
        /// <returns>The updated MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> UpdateAsync(MessageRule messageRuleToUpdate);

        /// <summary>
        /// Updates the specified MessageRule using PATCH.
        /// </summary>
        /// <param name="messageRuleToUpdate">The MessageRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> UpdateAsync(MessageRule messageRuleToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Expand(Expression<Func<MessageRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Select(Expression<Func<MessageRule, object>> selectExpression);

    }
}
