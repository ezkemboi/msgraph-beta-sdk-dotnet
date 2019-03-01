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
    /// The interface IDeviceComplianceDeviceStatusRequest.
    /// </summary>
    public partial interface IDeviceComplianceDeviceStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using PUT.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <returns>The created DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> CreateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate);        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using PUT.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> CreateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <returns>The DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> GetAsync();

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <returns>The updated DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> UpdateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate);

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceComplianceDeviceStatus.</returns>
        System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> UpdateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceStatusRequest Expand(Expression<Func<DeviceComplianceDeviceStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceDeviceStatusRequest Select(Expression<Func<DeviceComplianceDeviceStatus, object>> selectExpression);

    }
}
