// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookFunctionsImLog10RequestBuilder.
    /// </summary>
    public partial interface IWorkbookFunctionsImLog10RequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookFunctionsImLog10Request Request(IEnumerable<Option> options = null);
    }
}
