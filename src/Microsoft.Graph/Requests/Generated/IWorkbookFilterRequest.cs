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
    /// The interface IWorkbookFilterRequest.
    /// </summary>
    public partial interface IWorkbookFilterRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookFilter using PUT.
        /// </summary>
        /// <param name="workbookFilterToCreate">The WorkbookFilter to create.</param>
        /// <returns>The created WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> CreateAsync(WorkbookFilter workbookFilterToCreate);        /// <summary>
        /// Creates the specified WorkbookFilter using PUT.
        /// </summary>
        /// <param name="workbookFilterToCreate">The WorkbookFilter to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> CreateAsync(WorkbookFilter workbookFilterToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookFilter.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookFilter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookFilter.
        /// </summary>
        /// <returns>The WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookFilter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookFilter using PATCH.
        /// </summary>
        /// <param name="workbookFilterToUpdate">The WorkbookFilter to update.</param>
        /// <returns>The updated WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> UpdateAsync(WorkbookFilter workbookFilterToUpdate);

        /// <summary>
        /// Updates the specified WorkbookFilter using PATCH.
        /// </summary>
        /// <param name="workbookFilterToUpdate">The WorkbookFilter to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookFilter.</returns>
        System.Threading.Tasks.Task<WorkbookFilter> UpdateAsync(WorkbookFilter workbookFilterToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFilterRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFilterRequest Expand(Expression<Func<WorkbookFilter, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFilterRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFilterRequest Select(Expression<Func<WorkbookFilter, object>> selectExpression);

    }
}
