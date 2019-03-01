// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IDeviceManagementDetectedAppsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<DeviceManagementDetectedAppsCollectionPage>))]
    public interface IDeviceManagementDetectedAppsCollectionPage : ICollectionPage<DetectedApp>
    {
        /// <summary>
        /// Gets the next page <see cref="IDeviceManagementDetectedAppsCollectionRequest"/> instance.
        /// </summary>
        IDeviceManagementDetectedAppsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
