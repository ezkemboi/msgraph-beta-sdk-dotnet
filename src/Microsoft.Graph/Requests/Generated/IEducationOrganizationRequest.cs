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
    /// The interface IEducationOrganizationRequest.
    /// </summary>
    public partial interface IEducationOrganizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationOrganization using PUT.
        /// </summary>
        /// <param name="educationOrganizationToCreate">The EducationOrganization to create.</param>
        /// <returns>The created EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> CreateAsync(EducationOrganization educationOrganizationToCreate);        /// <summary>
        /// Creates the specified EducationOrganization using PUT.
        /// </summary>
        /// <param name="educationOrganizationToCreate">The EducationOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> CreateAsync(EducationOrganization educationOrganizationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EducationOrganization.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EducationOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationOrganization.
        /// </summary>
        /// <returns>The EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> GetAsync();

        /// <summary>
        /// Gets the specified EducationOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationOrganization using PATCH.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization to update.</param>
        /// <returns>The updated EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> UpdateAsync(EducationOrganization educationOrganizationToUpdate);

        /// <summary>
        /// Updates the specified EducationOrganization using PATCH.
        /// </summary>
        /// <param name="educationOrganizationToUpdate">The EducationOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EducationOrganization.</returns>
        System.Threading.Tasks.Task<EducationOrganization> UpdateAsync(EducationOrganization educationOrganizationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Expand(Expression<Func<EducationOrganization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationOrganizationRequest Select(Expression<Func<EducationOrganization, object>> selectExpression);

    }
}
