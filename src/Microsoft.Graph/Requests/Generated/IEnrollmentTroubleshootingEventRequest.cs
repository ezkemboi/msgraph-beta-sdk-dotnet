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
    /// The interface IEnrollmentTroubleshootingEventRequest.
    /// </summary>
    public partial interface IEnrollmentTroubleshootingEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EnrollmentTroubleshootingEvent using PUT.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToCreate">The EnrollmentTroubleshootingEvent to create.</param>
        /// <returns>The created EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> CreateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToCreate);        /// <summary>
        /// Creates the specified EnrollmentTroubleshootingEvent using PUT.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToCreate">The EnrollmentTroubleshootingEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> CreateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <returns>The EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> GetAsync();

        /// <summary>
        /// Gets the specified EnrollmentTroubleshootingEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent to update.</param>
        /// <returns>The updated EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> UpdateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate);

        /// <summary>
        /// Updates the specified EnrollmentTroubleshootingEvent using PATCH.
        /// </summary>
        /// <param name="enrollmentTroubleshootingEventToUpdate">The EnrollmentTroubleshootingEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EnrollmentTroubleshootingEvent.</returns>
        System.Threading.Tasks.Task<EnrollmentTroubleshootingEvent> UpdateAsync(EnrollmentTroubleshootingEvent enrollmentTroubleshootingEventToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Expand(Expression<Func<EnrollmentTroubleshootingEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEnrollmentTroubleshootingEventRequest Select(Expression<Func<EnrollmentTroubleshootingEvent, object>> selectExpression);

    }
}
