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
    /// The interface IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAndroidManagedAppProtectionRequestBuilder"/> for the specified AndroidManagedAppProtection.
        /// </summary>
        /// <param name="id">The ID for the AndroidManagedAppProtection.</param>
        /// <returns>The <see cref="IAndroidManagedAppProtectionRequestBuilder"/>.</returns>
        IAndroidManagedAppProtectionRequestBuilder this[string id] { get; }

        
    }
}
