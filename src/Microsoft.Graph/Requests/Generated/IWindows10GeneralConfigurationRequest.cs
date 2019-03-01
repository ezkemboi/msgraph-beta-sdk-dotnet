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
    /// The interface IWindows10GeneralConfigurationRequest.
    /// </summary>
    public partial interface IWindows10GeneralConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10GeneralConfiguration using PUT.
        /// </summary>
        /// <param name="windows10GeneralConfigurationToCreate">The Windows10GeneralConfiguration to create.</param>
        /// <returns>The created Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> CreateAsync(Windows10GeneralConfiguration windows10GeneralConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows10GeneralConfiguration using PUT.
        /// </summary>
        /// <param name="windows10GeneralConfigurationToCreate">The Windows10GeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> CreateAsync(Windows10GeneralConfiguration windows10GeneralConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10GeneralConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10GeneralConfiguration.
        /// </summary>
        /// <returns>The Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10GeneralConfigurationToUpdate">The Windows10GeneralConfiguration to update.</param>
        /// <returns>The updated Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> UpdateAsync(Windows10GeneralConfiguration windows10GeneralConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10GeneralConfigurationToUpdate">The Windows10GeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Windows10GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10GeneralConfiguration> UpdateAsync(Windows10GeneralConfiguration windows10GeneralConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10GeneralConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10GeneralConfigurationRequest Expand(Expression<Func<Windows10GeneralConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10GeneralConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10GeneralConfigurationRequest Select(Expression<Func<Windows10GeneralConfiguration, object>> selectExpression);

    }
}
