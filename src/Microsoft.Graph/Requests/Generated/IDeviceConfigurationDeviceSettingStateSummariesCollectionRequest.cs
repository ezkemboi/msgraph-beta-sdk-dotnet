// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest.
    /// </summary>
    public partial interface IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified SettingStateDeviceSummary to the collection via POST.
        /// </summary>
        /// <param name="settingStateDeviceSummary">The SettingStateDeviceSummary to add.</param>
        /// <returns>The created SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> AddAsync(SettingStateDeviceSummary settingStateDeviceSummary);

        /// <summary>
        /// Adds the specified SettingStateDeviceSummary to the collection via POST.
        /// </summary>
        /// <param name="settingStateDeviceSummary">The SettingStateDeviceSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SettingStateDeviceSummary.</returns>
        System.Threading.Tasks.Task<SettingStateDeviceSummary> AddAsync(SettingStateDeviceSummary settingStateDeviceSummary, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceConfigurationDeviceSettingStateSummariesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceConfigurationDeviceSettingStateSummariesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Expand(Expression<Func<SettingStateDeviceSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Select(Expression<Func<SettingStateDeviceSummary, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationDeviceSettingStateSummariesCollectionRequest OrderBy(string value);
    }
}
