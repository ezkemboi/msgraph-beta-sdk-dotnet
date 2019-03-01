// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceRequestBuilder.
    /// </summary>
    public partial interface IDeviceRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for MemberOf.
        /// </summary>
        /// <returns>The <see cref="IDeviceMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IDeviceMemberOfCollectionWithReferencesRequestBuilder MemberOf { get; }

        /// <summary>
        /// Gets the request builder for RegisteredOwners.
        /// </summary>
        /// <returns>The <see cref="IDeviceRegisteredOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IDeviceRegisteredOwnersCollectionWithReferencesRequestBuilder RegisteredOwners { get; }

        /// <summary>
        /// Gets the request builder for RegisteredUsers.
        /// </summary>
        /// <returns>The <see cref="IDeviceRegisteredUsersCollectionWithReferencesRequestBuilder"/>.</returns>
        IDeviceRegisteredUsersCollectionWithReferencesRequestBuilder RegisteredUsers { get; }

        /// <summary>
        /// Gets the request builder for TransitiveMemberOf.
        /// </summary>
        /// <returns>The <see cref="IDeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder"/>.</returns>
        IDeviceTransitiveMemberOfCollectionWithReferencesRequestBuilder TransitiveMemberOf { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IDeviceExtensionsCollectionRequestBuilder"/>.</returns>
        IDeviceExtensionsCollectionRequestBuilder Extensions { get; }
    
    }
}
