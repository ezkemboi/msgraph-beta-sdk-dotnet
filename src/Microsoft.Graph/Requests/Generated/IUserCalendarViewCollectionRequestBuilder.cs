// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IUserCalendarViewCollectionRequestBuilder.
    /// </summary>
    public partial interface IUserCalendarViewCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserCalendarViewCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserCalendarViewCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEventRequestBuilder"/> for the specified Event.
        /// </summary>
        /// <param name="id">The ID for the Event.</param>
        /// <returns>The <see cref="IEventRequestBuilder"/>.</returns>
        IEventRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for EventDelta.
        /// </summary>
        /// <returns>The <see cref="IEventDeltaRequestBuilder"/>.</returns>
        IEventDeltaRequestBuilder Delta();
    }
}
