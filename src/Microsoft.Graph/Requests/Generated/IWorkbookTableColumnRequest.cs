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
    /// The interface IWorkbookTableColumnRequest.
    /// </summary>
    public partial interface IWorkbookTableColumnRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookTableColumn using PUT.
        /// </summary>
        /// <param name="workbookTableColumnToCreate">The WorkbookTableColumn to create.</param>
        /// <returns>The created WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> CreateAsync(WorkbookTableColumn workbookTableColumnToCreate);        /// <summary>
        /// Creates the specified WorkbookTableColumn using PUT.
        /// </summary>
        /// <param name="workbookTableColumnToCreate">The WorkbookTableColumn to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> CreateAsync(WorkbookTableColumn workbookTableColumnToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookTableColumn.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookTableColumn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookTableColumn.
        /// </summary>
        /// <returns>The WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookTableColumn.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookTableColumn using PATCH.
        /// </summary>
        /// <param name="workbookTableColumnToUpdate">The WorkbookTableColumn to update.</param>
        /// <returns>The updated WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> UpdateAsync(WorkbookTableColumn workbookTableColumnToUpdate);

        /// <summary>
        /// Updates the specified WorkbookTableColumn using PATCH.
        /// </summary>
        /// <param name="workbookTableColumnToUpdate">The WorkbookTableColumn to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookTableColumn.</returns>
        System.Threading.Tasks.Task<WorkbookTableColumn> UpdateAsync(WorkbookTableColumn workbookTableColumnToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableColumnRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableColumnRequest Expand(Expression<Func<WorkbookTableColumn, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableColumnRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableColumnRequest Select(Expression<Func<WorkbookTableColumn, object>> selectExpression);

    }
}
