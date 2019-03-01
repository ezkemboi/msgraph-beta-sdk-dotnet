// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Chart Axis.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAxis : Entity
    {
    
        /// <summary>
        /// Gets or sets major unit.
        /// Represents the interval between two major tick marks. Can be set to a numeric value or an empty string.  The returned value is always a number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "majorUnit", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken MajorUnit { get; set; }
    
        /// <summary>
        /// Gets or sets maximum.
        /// Represents the maximum value on the value axis.  Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximum", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Maximum { get; set; }
    
        /// <summary>
        /// Gets or sets minimum.
        /// Represents the minimum value on the value axis. Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimum", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Minimum { get; set; }
    
        /// <summary>
        /// Gets or sets minor unit.
        /// Represents the interval between two minor tick marks. 'Can be set to a numeric value or an empty string (for automatic axis values). The returned value is always a number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minorUnit", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken MinorUnit { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of a chart object, which includes line and font formatting. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxisFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets major gridlines.
        /// Returns a gridlines object that represents the major gridlines for the specified axis. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "majorGridlines", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartGridlines MajorGridlines { get; set; }
    
        /// <summary>
        /// Gets or sets minor gridlines.
        /// Returns a Gridlines object that represents the minor gridlines for the specified axis. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minorGridlines", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartGridlines MinorGridlines { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Represents the axis title. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxisTitle Title { get; set; }
    
    }
}

