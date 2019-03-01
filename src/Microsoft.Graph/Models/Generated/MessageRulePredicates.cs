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
    /// The type MessageRulePredicates.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MessageRulePredicates
    {

        /// <summary>
        /// Gets or sets categories.
        /// Represents the categories that an incoming message should be labeled with in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categories", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Categories { get; set; }
    
        /// <summary>
        /// Gets or sets subjectContains.
        /// Represents the strings that appear in the subject of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SubjectContains { get; set; }
    
        /// <summary>
        /// Gets or sets bodyContains.
        /// Represents the strings that should appear in the body of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BodyContains { get; set; }
    
        /// <summary>
        /// Gets or sets bodyOrSubjectContains.
        /// Represents the strings that should appear in the body or subject of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyOrSubjectContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BodyOrSubjectContains { get; set; }
    
        /// <summary>
        /// Gets or sets senderContains.
        /// Represents the strings that appear in the from property of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "senderContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SenderContains { get; set; }
    
        /// <summary>
        /// Gets or sets recipientContains.
        /// Represents the strings that appear in either the toRecipients or ccRecipients properties of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipientContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RecipientContains { get; set; }
    
        /// <summary>
        /// Gets or sets headerContains.
        /// Represents the strings that appear in the headers of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "headerContains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> HeaderContains { get; set; }
    
        /// <summary>
        /// Gets or sets messageActionFlag.
        /// Represents the flag-for-action value that appears on an incoming message in order for the condition or exception to apply. The possible values are: any, call, doNotForward, followUp, fyi, forward, noResponseNecessary, read, reply, replyToAll, review.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messageActionFlag", Required = Newtonsoft.Json.Required.Default)]
        public MessageActionFlag? MessageActionFlag { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance that is stamped on an incoming message in order for the condition or exception to apply: low, normal, high.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public Importance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity.
        /// Represents the sensitivity level that must be stamped on an incoming message in order for the condition or exception to apply. The possible values are: normal, personal, private, confidential.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitivity", Required = Newtonsoft.Json.Required.Default)]
        public Sensitivity? Sensitivity { get; set; }
    
        /// <summary>
        /// Gets or sets fromAddresses.
        /// Represents the specific sender email addresses of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fromAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Recipient> FromAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets sentToAddresses.
        /// Represents the email addresses that an incoming message must have been sent to in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentToAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Recipient> SentToAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets sentToMe.
        /// Indicates whether the owner of the mailbox must be in the toRecipients property of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentToMe", Required = Newtonsoft.Json.Required.Default)]
        public bool? SentToMe { get; set; }
    
        /// <summary>
        /// Gets or sets sentOnlyToMe.
        /// Indicates whether the owner of the mailbox must be the only recipient in an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentOnlyToMe", Required = Newtonsoft.Json.Required.Default)]
        public bool? SentOnlyToMe { get; set; }
    
        /// <summary>
        /// Gets or sets sentCcMe.
        /// Indicates whether the owner of the mailbox must be in the ccRecipients property of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentCcMe", Required = Newtonsoft.Json.Required.Default)]
        public bool? SentCcMe { get; set; }
    
        /// <summary>
        /// Gets or sets sentToOrCcMe.
        /// Indicates whether the owner of the mailbox must be in either a toRecipients or ccRecipients property of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sentToOrCcMe", Required = Newtonsoft.Json.Required.Default)]
        public bool? SentToOrCcMe { get; set; }
    
        /// <summary>
        /// Gets or sets notSentToMe.
        /// Indicates whether the owner of the mailbox must not be a recipient of an incoming message in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notSentToMe", Required = Newtonsoft.Json.Required.Default)]
        public bool? NotSentToMe { get; set; }
    
        /// <summary>
        /// Gets or sets hasAttachments.
        /// Indicates whether an incoming message must have attachments in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets isApprovalRequest.
        /// Indicates whether an incoming message must be an approval request in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isApprovalRequest", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsApprovalRequest { get; set; }
    
        /// <summary>
        /// Gets or sets isAutomaticForward.
        /// Indicates whether an incoming message must be automatically forwarded in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAutomaticForward", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAutomaticForward { get; set; }
    
        /// <summary>
        /// Gets or sets isAutomaticReply.
        /// Indicates whether an incoming message must be an auto reply in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAutomaticReply", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAutomaticReply { get; set; }
    
        /// <summary>
        /// Gets or sets isEncrypted.
        /// Indicates whether an incoming message must be encrypted in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEncrypted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets isMeetingRequest.
        /// Indicates whether an incoming message must be a meeting request in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMeetingRequest", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMeetingRequest { get; set; }
    
        /// <summary>
        /// Gets or sets isMeetingResponse.
        /// Indicates whether an incoming message must be a meeting response in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMeetingResponse", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMeetingResponse { get; set; }
    
        /// <summary>
        /// Gets or sets isNonDeliveryReport.
        /// Indicates whether an incoming message must be a non-delivery report in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isNonDeliveryReport", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsNonDeliveryReport { get; set; }
    
        /// <summary>
        /// Gets or sets isPermissionControlled.
        /// Indicates whether an incoming message must be permission controlled (RMS-protected) in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isPermissionControlled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsPermissionControlled { get; set; }
    
        /// <summary>
        /// Gets or sets isReadReceipt.
        /// Indicates whether an incoming message must be a read receipt in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReadReceipt", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsReadReceipt { get; set; }
    
        /// <summary>
        /// Gets or sets isSigned.
        /// Indicates whether an incoming message must be S/MIME-signed in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSigned", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSigned { get; set; }
    
        /// <summary>
        /// Gets or sets isVoicemail.
        /// Indicates whether an incoming message must be a voice mail in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isVoicemail", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsVoicemail { get; set; }
    
        /// <summary>
        /// Gets or sets withinSizeRange.
        /// Represents the minimum and maximum sizes (in kilobytes) that an incoming message must fall in between in order for the condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "withinSizeRange", Required = Newtonsoft.Json.Required.Default)]
        public SizeRange WithinSizeRange { get; set; }
    
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
