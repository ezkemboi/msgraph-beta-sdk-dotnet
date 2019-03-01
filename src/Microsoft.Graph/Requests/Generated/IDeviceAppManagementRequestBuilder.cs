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
    /// The interface IDeviceAppManagementRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceAppManagementRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceAppManagementRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for MobileApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppsCollectionRequestBuilder MobileApps { get; }

        /// <summary>
        /// Gets the request builder for MobileAppCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder MobileAppCategories { get; }

        /// <summary>
        /// Gets the request builder for MobileAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMobileAppConfigurationsCollectionRequestBuilder MobileAppConfigurations { get; }

        /// <summary>
        /// Gets the request builder for VppTokens.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementVppTokensCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementVppTokensCollectionRequestBuilder VppTokens { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppPoliciesCollectionRequestBuilder ManagedAppPolicies { get; }

        /// <summary>
        /// Gets the request builder for IosManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder IosManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for AndroidManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder AndroidManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for DefaultManagedAppProtections.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder DefaultManagedAppProtections { get; }

        /// <summary>
        /// Gets the request builder for TargetedManagedAppConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder TargetedManagedAppConfigurations { get; }

        /// <summary>
        /// Gets the request builder for MdmWindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementMdmWindowsInformationProtectionPoliciesCollectionRequestBuilder MdmWindowsInformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionPolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementWindowsInformationProtectionPoliciesCollectionRequestBuilder WindowsInformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppRegistrations.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppRegistrationsCollectionRequestBuilder ManagedAppRegistrations { get; }

        /// <summary>
        /// Gets the request builder for ManagedAppStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedAppStatusesCollectionRequestBuilder ManagedAppStatuses { get; }

        /// <summary>
        /// Gets the request builder for ManagedEBooks.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementManagedEBooksCollectionRequestBuilder"/>.</returns>
        IDeviceAppManagementManagedEBooksCollectionRequestBuilder ManagedEBooks { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceAppManagementSyncMicrosoftStoreForBusinessApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder"/>.</returns>
        IDeviceAppManagementSyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps();
    
    }
}
