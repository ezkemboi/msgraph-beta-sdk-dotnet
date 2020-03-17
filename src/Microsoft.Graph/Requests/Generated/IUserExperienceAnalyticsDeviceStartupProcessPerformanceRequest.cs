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
    /// The interface IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcessPerformance using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessPerformanceToCreate">The UserExperienceAnalyticsDeviceStartupProcessPerformance to create.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> CreateAsync(UserExperienceAnalyticsDeviceStartupProcessPerformance userExperienceAnalyticsDeviceStartupProcessPerformanceToCreate);        /// <summary>
        /// Creates the specified UserExperienceAnalyticsDeviceStartupProcessPerformance using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessPerformanceToCreate">The UserExperienceAnalyticsDeviceStartupProcessPerformance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> CreateAsync(UserExperienceAnalyticsDeviceStartupProcessPerformance userExperienceAnalyticsDeviceStartupProcessPerformanceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcessPerformance.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsDeviceStartupProcessPerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcessPerformance.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsDeviceStartupProcessPerformance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcessPerformance using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessPerformanceToUpdate">The UserExperienceAnalyticsDeviceStartupProcessPerformance to update.</param>
        /// <returns>The updated UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> UpdateAsync(UserExperienceAnalyticsDeviceStartupProcessPerformance userExperienceAnalyticsDeviceStartupProcessPerformanceToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsDeviceStartupProcessPerformance using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsDeviceStartupProcessPerformanceToUpdate">The UserExperienceAnalyticsDeviceStartupProcessPerformance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsDeviceStartupProcessPerformance.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsDeviceStartupProcessPerformance> UpdateAsync(UserExperienceAnalyticsDeviceStartupProcessPerformance userExperienceAnalyticsDeviceStartupProcessPerformanceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest Expand(Expression<Func<UserExperienceAnalyticsDeviceStartupProcessPerformance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequest Select(Expression<Func<UserExperienceAnalyticsDeviceStartupProcessPerformance, object>> selectExpression);

    }
}