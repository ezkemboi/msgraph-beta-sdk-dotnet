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
    /// The interface IDeviceConfigurationDeviceOverviewRequest.
    /// </summary>
    public partial interface IDeviceConfigurationDeviceOverviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceOverview using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToCreate">The DeviceConfigurationDeviceOverview to create.</param>
        /// <returns>The created DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> CreateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToCreate);        /// <summary>
        /// Creates the specified DeviceConfigurationDeviceOverview using PUT.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToCreate">The DeviceConfigurationDeviceOverview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> CreateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <returns>The DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationDeviceOverview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview to update.</param>
        /// <returns>The updated DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> UpdateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationDeviceOverview using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationDeviceOverviewToUpdate">The DeviceConfigurationDeviceOverview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfigurationDeviceOverview.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationDeviceOverview> UpdateAsync(DeviceConfigurationDeviceOverview deviceConfigurationDeviceOverviewToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Expand(Expression<Func<DeviceConfigurationDeviceOverview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceOverviewRequest Select(Expression<Func<DeviceConfigurationDeviceOverview, object>> selectExpression);

    }
}
