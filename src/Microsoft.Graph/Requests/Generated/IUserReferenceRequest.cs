// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityReferenceRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IUserReferenceRequest.
    /// </summary>
    public partial interface IUserReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Deletes the specified User reference.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified User reference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Puts the specified User reference.
        /// </summary>
        /// <param name="id">The User reference reference to update.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task PutAsync(string id);

        /// <summary>
        /// Puts the specified User reference.
        /// </summary>
        /// <param name="id">The User reference reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task PutAsync(string id, CancellationToken cancellationToken);
    }
}
