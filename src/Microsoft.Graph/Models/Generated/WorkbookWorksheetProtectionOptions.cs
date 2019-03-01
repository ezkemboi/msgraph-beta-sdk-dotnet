// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WorkbookWorksheetProtectionOptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WorkbookWorksheetProtectionOptions
    {

        /// <summary>
        /// Gets or sets allowAutoFilter.
        /// Represents the worksheet protection option of allowing using auto filter feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowAutoFilter", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowAutoFilter { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteColumns.
        /// Represents the worksheet protection option of allowing deleting columns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeleteColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeleteColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteRows.
        /// Represents the worksheet protection option of allowing deleting rows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeleteRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeleteRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatCells.
        /// Represents the worksheet protection option of allowing formatting cells.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatCells", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatCells { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatColumns.
        /// Represents the worksheet protection option of allowing formatting columns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatRows.
        /// Represents the worksheet protection option of allowing formatting rows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowFormatRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowFormatRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertColumns.
        /// Represents the worksheet protection option of allowing inserting columns.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertColumns", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertHyperlinks.
        /// Represents the worksheet protection option of allowing inserting hyperlinks.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertHyperlinks", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertHyperlinks { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertRows.
        /// Represents the worksheet protection option of allowing inserting rows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowInsertRows", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowInsertRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowPivotTables.
        /// Represents the worksheet protection option of allowing using pivot table feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowPivotTables", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowPivotTables { get; set; }
    
        /// <summary>
        /// Gets or sets allowSort.
        /// Represents the worksheet protection option of allowing using sort feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowSort", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowSort { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
