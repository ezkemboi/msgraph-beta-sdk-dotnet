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
    /// The interface IWorkbookRangeFormatRequest.
    /// </summary>
    public partial interface IWorkbookRangeFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeFormat using PUT.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <returns>The created WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> CreateAsync(WorkbookRangeFormat workbookRangeFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookRangeFormat using PUT.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> CreateAsync(WorkbookRangeFormat workbookRangeFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookRangeFormat.
        /// </summary>
        /// <returns>The WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookRangeFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <returns>The updated WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> UpdateAsync(WorkbookRangeFormat workbookRangeFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookRangeFormat.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFormat> UpdateAsync(WorkbookRangeFormat workbookRangeFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFormatRequest Expand(Expression<Func<WorkbookRangeFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFormatRequest Select(Expression<Func<WorkbookRangeFormat, object>> selectExpression);

    }
}
