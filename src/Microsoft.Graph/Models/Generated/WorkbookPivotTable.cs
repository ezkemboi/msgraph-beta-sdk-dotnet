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
    /// The type Workbook Pivot Table.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookPivotTable : Entity
    {
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the PivotTable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// The worksheet containing the current PivotTable. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "worksheet", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

