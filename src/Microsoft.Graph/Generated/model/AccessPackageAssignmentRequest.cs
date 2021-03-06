// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Access Package Assignment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessPackageAssignmentRequestObject : Entity
    {
    
		///<summary>
		/// The AccessPackageAssignmentRequest constructor
		///</summary>
        public AccessPackageAssignmentRequestObject()
        {
            this.ODataType = "microsoft.graph.accessPackageAssignmentRequest";
        }
	
        /// <summary>
        /// Gets or sets answers.
        /// Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "answers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AccessPackageAnswer> Answers { get; set; }
    
        /// <summary>
        /// Gets or sets completed date.
        /// The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CompletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets is validation only.
        /// True if the request is not to be processed for assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isValidationOnly", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsValidationOnly { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// The requestor's supplied justification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justification", Required = Newtonsoft.Json.Required.Default)]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets request state.
        /// One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, Submitted or Scheduled. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestState", Required = Newtonsoft.Json.Required.Default)]
        public string RequestState { get; set; }
    
        /// <summary>
        /// Gets or sets request status.
        /// More information on the request processing status. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestStatus", Required = Newtonsoft.Json.Required.Default)]
        public string RequestStatus { get; set; }
    
        /// <summary>
        /// Gets or sets request type.
        /// One of UserAdd, UserRemove, AdminAdd, AdminRemove or SystemRemove. A request from the user themselves would have requestType of UserAdd or UserRemove. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestType", Required = Newtonsoft.Json.Required.Default)]
        public string RequestType { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// The range of dates that access is to be assigned to the requestor. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schedule", Required = Newtonsoft.Json.Required.Default)]
        public RequestSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets access package.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackage", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackage AccessPackage { get; set; }
    
        /// <summary>
        /// Gets or sets access package assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackageAssignment", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackageAssignment AccessPackageAssignment { get; set; }
    
        /// <summary>
        /// Gets or sets requestor.
        /// The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestor", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackageSubject Requestor { get; set; }
    
    }
}

