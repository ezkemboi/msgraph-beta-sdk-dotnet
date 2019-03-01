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
    /// The interface IMailFolderMessagesCollectionRequestBuilder.
    /// </summary>
    public partial interface IMailFolderMessagesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMailFolderMessagesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMailFolderMessagesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMessageRequestBuilder"/> for the specified Message.
        /// </summary>
        /// <param name="id">The ID for the Message.</param>
        /// <returns>The <see cref="IMessageRequestBuilder"/>.</returns>
        IMessageRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for MessageDelta.
        /// </summary>
        /// <returns>The <see cref="IMessageDeltaRequestBuilder"/>.</returns>
        IMessageDeltaRequestBuilder Delta();
    }
}
