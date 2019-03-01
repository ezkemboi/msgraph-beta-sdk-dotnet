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
    /// The interface IWindows10SecureAssessmentConfigurationRequest.
    /// </summary>
    public partial interface IWindows10SecureAssessmentConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using PUT.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <returns>The created Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> CreateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows10SecureAssessmentConfiguration using PUT.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToCreate">The Windows10SecureAssessmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> CreateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <returns>The Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10SecureAssessmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <returns>The updated Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> UpdateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10SecureAssessmentConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10SecureAssessmentConfigurationToUpdate">The Windows10SecureAssessmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Windows10SecureAssessmentConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10SecureAssessmentConfiguration> UpdateAsync(Windows10SecureAssessmentConfiguration windows10SecureAssessmentConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Expand(Expression<Func<Windows10SecureAssessmentConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10SecureAssessmentConfigurationRequest Select(Expression<Func<Windows10SecureAssessmentConfiguration, object>> selectExpression);

    }
}
