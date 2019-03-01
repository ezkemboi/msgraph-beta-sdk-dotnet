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
    /// The interface IDeviceAndAppManagementRoleAssignmentRequest.
    /// </summary>
    public partial interface IDeviceAndAppManagementRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceAndAppManagementRoleAssignment using PUT.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleAssignmentToCreate">The DeviceAndAppManagementRoleAssignment to create.</param>
        /// <returns>The created DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> CreateAsync(DeviceAndAppManagementRoleAssignment deviceAndAppManagementRoleAssignmentToCreate);        /// <summary>
        /// Creates the specified DeviceAndAppManagementRoleAssignment using PUT.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleAssignmentToCreate">The DeviceAndAppManagementRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> CreateAsync(DeviceAndAppManagementRoleAssignment deviceAndAppManagementRoleAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceAndAppManagementRoleAssignment.
        /// </summary>
        /// <returns>The DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified DeviceAndAppManagementRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceAndAppManagementRoleAssignment using PATCH.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleAssignmentToUpdate">The DeviceAndAppManagementRoleAssignment to update.</param>
        /// <returns>The updated DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> UpdateAsync(DeviceAndAppManagementRoleAssignment deviceAndAppManagementRoleAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceAndAppManagementRoleAssignment using PATCH.
        /// </summary>
        /// <param name="deviceAndAppManagementRoleAssignmentToUpdate">The DeviceAndAppManagementRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceAndAppManagementRoleAssignment.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementRoleAssignment> UpdateAsync(DeviceAndAppManagementRoleAssignment deviceAndAppManagementRoleAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementRoleAssignmentRequest Expand(Expression<Func<DeviceAndAppManagementRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementRoleAssignmentRequest Select(Expression<Func<DeviceAndAppManagementRoleAssignment, object>> selectExpression);

    }
}
