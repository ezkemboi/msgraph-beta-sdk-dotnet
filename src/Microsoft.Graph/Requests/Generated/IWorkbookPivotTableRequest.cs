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
    /// The interface IWorkbookPivotTableRequest.
    /// </summary>
    public partial interface IWorkbookPivotTableRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookPivotTable using PUT.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <returns>The created WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> CreateAsync(WorkbookPivotTable workbookPivotTableToCreate);        /// <summary>
        /// Creates the specified WorkbookPivotTable using PUT.
        /// </summary>
        /// <param name="workbookPivotTableToCreate">The WorkbookPivotTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> CreateAsync(WorkbookPivotTable workbookPivotTableToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookPivotTable.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookPivotTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookPivotTable.
        /// </summary>
        /// <returns>The WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookPivotTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookPivotTable using PATCH.
        /// </summary>
        /// <param name="workbookPivotTableToUpdate">The WorkbookPivotTable to update.</param>
        /// <returns>The updated WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> UpdateAsync(WorkbookPivotTable workbookPivotTableToUpdate);

        /// <summary>
        /// Updates the specified WorkbookPivotTable using PATCH.
        /// </summary>
        /// <param name="workbookPivotTableToUpdate">The WorkbookPivotTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookPivotTable.</returns>
        System.Threading.Tasks.Task<WorkbookPivotTable> UpdateAsync(WorkbookPivotTable workbookPivotTableToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookPivotTableRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookPivotTableRequest Expand(Expression<Func<WorkbookPivotTable, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookPivotTableRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookPivotTableRequest Select(Expression<Func<WorkbookPivotTable, object>> selectExpression);

    }
}
