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
    /// The type IosGeneralDeviceConfigurationRequestBuilder.
    /// </summary>
    public partial class IosGeneralDeviceConfigurationRequestBuilder : DeviceConfigurationRequestBuilder, IIosGeneralDeviceConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new IosGeneralDeviceConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IosGeneralDeviceConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IIosGeneralDeviceConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IIosGeneralDeviceConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new IosGeneralDeviceConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
