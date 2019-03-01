// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceConfigurationUserStatusRequestBuilder.
    /// </summary>
    public partial class DeviceConfigurationUserStatusRequestBuilder : EntityRequestBuilder, IDeviceConfigurationUserStatusRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceConfigurationUserStatusRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceConfigurationUserStatusRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationUserStatusRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationUserStatusRequest Request(IEnumerable<Option> options)
        {
            return new DeviceConfigurationUserStatusRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
