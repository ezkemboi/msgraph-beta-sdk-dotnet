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
    /// The interface IIosDerivedCredentialAuthenticationConfigurationRequest.
    /// </summary>
    public partial interface IIosDerivedCredentialAuthenticationConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosDerivedCredentialAuthenticationConfiguration using POST.
        /// </summary>
        /// <param name="iosDerivedCredentialAuthenticationConfigurationToCreate">The IosDerivedCredentialAuthenticationConfiguration to create.</param>
        /// <returns>The created IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> CreateAsync(IosDerivedCredentialAuthenticationConfiguration iosDerivedCredentialAuthenticationConfigurationToCreate);        /// <summary>
        /// Creates the specified IosDerivedCredentialAuthenticationConfiguration using POST.
        /// </summary>
        /// <param name="iosDerivedCredentialAuthenticationConfigurationToCreate">The IosDerivedCredentialAuthenticationConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> CreateAsync(IosDerivedCredentialAuthenticationConfiguration iosDerivedCredentialAuthenticationConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosDerivedCredentialAuthenticationConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosDerivedCredentialAuthenticationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosDerivedCredentialAuthenticationConfiguration.
        /// </summary>
        /// <returns>The IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosDerivedCredentialAuthenticationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosDerivedCredentialAuthenticationConfiguration using PATCH.
        /// </summary>
        /// <param name="iosDerivedCredentialAuthenticationConfigurationToUpdate">The IosDerivedCredentialAuthenticationConfiguration to update.</param>
        /// <returns>The updated IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> UpdateAsync(IosDerivedCredentialAuthenticationConfiguration iosDerivedCredentialAuthenticationConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosDerivedCredentialAuthenticationConfiguration using PATCH.
        /// </summary>
        /// <param name="iosDerivedCredentialAuthenticationConfigurationToUpdate">The IosDerivedCredentialAuthenticationConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosDerivedCredentialAuthenticationConfiguration.</returns>
        System.Threading.Tasks.Task<IosDerivedCredentialAuthenticationConfiguration> UpdateAsync(IosDerivedCredentialAuthenticationConfiguration iosDerivedCredentialAuthenticationConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosDerivedCredentialAuthenticationConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosDerivedCredentialAuthenticationConfigurationRequest Expand(Expression<Func<IosDerivedCredentialAuthenticationConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosDerivedCredentialAuthenticationConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosDerivedCredentialAuthenticationConfigurationRequest Select(Expression<Func<IosDerivedCredentialAuthenticationConfiguration, object>> selectExpression);

    }
}