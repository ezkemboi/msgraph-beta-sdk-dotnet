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
    /// The interface IDeviceEnrollmentConfigurationRequest.
    /// </summary>
    public partial interface IDeviceEnrollmentConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using PUT.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <returns>The created DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> CreateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate);        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using PUT.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> CreateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <returns>The DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <returns>The updated DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> UpdateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate);

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceEnrollmentConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> UpdateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Expand(Expression<Func<DeviceEnrollmentConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentConfigurationRequest Select(Expression<Func<DeviceEnrollmentConfiguration, object>> selectExpression);

    }
}
