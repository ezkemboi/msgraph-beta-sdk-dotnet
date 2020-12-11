// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IVirtualEndpointRequestBuilder.
    /// </summary>
    public partial interface IVirtualEndpointRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IVirtualEndpointRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IVirtualEndpointRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CloudPCs.
        /// </summary>
        /// <returns>The <see cref="IVirtualEndpointCloudPCsCollectionRequestBuilder"/>.</returns>
        IVirtualEndpointCloudPCsCollectionRequestBuilder CloudPCs { get; }

        /// <summary>
        /// Gets the request builder for DeviceImages.
        /// </summary>
        /// <returns>The <see cref="IVirtualEndpointDeviceImagesCollectionRequestBuilder"/>.</returns>
        IVirtualEndpointDeviceImagesCollectionRequestBuilder DeviceImages { get; }

        /// <summary>
        /// Gets the request builder for OnPremisesConnections.
        /// </summary>
        /// <returns>The <see cref="IVirtualEndpointOnPremisesConnectionsCollectionRequestBuilder"/>.</returns>
        IVirtualEndpointOnPremisesConnectionsCollectionRequestBuilder OnPremisesConnections { get; }

        /// <summary>
        /// Gets the request builder for ProvisioningPolicies.
        /// </summary>
        /// <returns>The <see cref="IVirtualEndpointProvisioningPoliciesCollectionRequestBuilder"/>.</returns>
        IVirtualEndpointProvisioningPoliciesCollectionRequestBuilder ProvisioningPolicies { get; }
    
        /// <summary>
        /// Gets the request builder for VirtualEndpointGetEffectivePermissions.
        /// </summary>
        /// <returns>The <see cref="IVirtualEndpointGetEffectivePermissionsRequestBuilder"/>.</returns>
        IVirtualEndpointGetEffectivePermissionsRequestBuilder GetEffectivePermissions();
    
    }
}