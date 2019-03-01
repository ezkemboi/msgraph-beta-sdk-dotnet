// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WebBrowserCookieSettings.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WebBrowserCookieSettings
    {
    
        /// <summary>
        /// browser Default
        /// </summary>
        BrowserDefault = 0,
	
        /// <summary>
        /// block Always
        /// </summary>
        BlockAlways = 1,
	
        /// <summary>
        /// allow Current Web Site
        /// </summary>
        AllowCurrentWebSite = 2,
	
        /// <summary>
        /// allow From Websites Visited
        /// </summary>
        AllowFromWebsitesVisited = 3,
	
        /// <summary>
        /// allow Always
        /// </summary>
        AllowAlways = 4,
	
    }
}
