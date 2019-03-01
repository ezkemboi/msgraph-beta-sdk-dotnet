// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookFunctionsMaxRequest.
    /// </summary>
    public partial interface IWorkbookFunctionsMaxRequest : IBaseRequest
    {

        /// <summary>
        /// Gets the request body.
        /// </summary>
        WorkbookFunctionsMaxRequestBody RequestBody { get; }


        /// <summary>
        /// Issues the POST request.
        /// </summary>
        System.Threading.Tasks.Task<WorkbookFunctionResult> PostAsync();

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookFunctionResult> PostAsync(
            CancellationToken cancellationToken);
        





        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFunctionsMaxRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFunctionsMaxRequest Select(string value);
    }
}
