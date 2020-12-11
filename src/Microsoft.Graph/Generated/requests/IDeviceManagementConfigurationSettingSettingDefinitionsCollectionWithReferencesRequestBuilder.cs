// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementConfigurationSettingSettingDefinitionsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementConfigurationSettingSettingDefinitionsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementConfigurationSettingSettingDefinitionsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementConfigurationSettingSettingDefinitionsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementConfigurationSettingDefinitionWithReferenceRequestBuilder"/> for the specified DeviceManagementConfigurationSettingDefinition.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementConfigurationSettingDefinition.</param>
        /// <returns>The <see cref="IDeviceManagementConfigurationSettingDefinitionWithReferenceRequestBuilder"/>.</returns>
        IDeviceManagementConfigurationSettingDefinitionWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IDeviceManagementConfigurationSettingSettingDefinitionsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementConfigurationSettingSettingDefinitionsCollectionReferencesRequestBuilder"/>.</returns>
        IDeviceManagementConfigurationSettingSettingDefinitionsCollectionReferencesRequestBuilder References { get; }

    }
}