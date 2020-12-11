// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceCustomAttributeShellScriptUserRunStatesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptUserStateRequestBuilder"/> for the specified DeviceManagementScriptUserState.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementScriptUserState.</param>
        /// <returns>The <see cref="IDeviceManagementScriptUserStateRequestBuilder"/>.</returns>
        IDeviceManagementScriptUserStateRequestBuilder this[string id] { get; }

        
    }
}