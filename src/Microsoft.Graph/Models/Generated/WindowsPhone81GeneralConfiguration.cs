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
    /// The type Windows Phone81General Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsPhone81GeneralConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets apply only to windows phone81.
        /// Value indicating whether this policy only applies to Windows Phone 8.1. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyOnlyToWindowsPhone81", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplyOnlyToWindowsPhone81 { get; set; }
    
        /// <summary>
        /// Gets or sets apps block copy paste.
        /// Indicates whether or not to block copy paste.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsBlockCopyPaste", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsBlockCopyPaste { get; set; }
    
        /// <summary>
        /// Gets or sets bluetooth blocked.
        /// Indicates whether or not to block bluetooth.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bluetoothBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? BluetoothBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// Indicates whether or not to block camera.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block wifi tethering.
        /// Indicates whether or not to block Wi-Fi tethering. Has no impact if Wi-Fi is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockWifiTethering", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockWifiTethering { get; set; }
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppsList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// List that is in the AppComplianceList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppListType", Required = Newtonsoft.Json.Required.Default)]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostic data block submission.
        /// Indicates whether or not to block diagnostic data submission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticDataBlockSubmission", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticDataBlockSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets email block adding accounts.
        /// Indicates whether or not to block custom email accounts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailBlockAddingAccounts", Required = Newtonsoft.Json.Required.Default)]
        public bool? EmailBlockAddingAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets location services blocked.
        /// Indicates whether or not to block location services.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locationServicesBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? LocationServicesBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft account blocked.
        /// Indicates whether or not to block using a Microsoft Account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microsoftAccountBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? MicrosoftAccountBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets nfc blocked.
        /// Indicates whether or not to block Near-Field Communication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nfcBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? NfcBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Indicates whether or not to block syncing the calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum length of passwords.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Minutes of inactivity before screen timeout.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// Number of character sets a password must contain.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 0 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Number of sign in failures allowed before factory reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Password type that is required. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Indicates whether or not to require a password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether or not to block screenshots.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets storage block removable storage.
        /// Indicates whether or not to block removable storage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageBlockRemovableStorage", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageBlockRemovableStorage { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Indicates whether or not to require encryption.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets web browser blocked.
        /// Indicates whether or not to block the web browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webBrowserBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WebBrowserBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets wifi blocked.
        /// Indicates whether or not to block Wi-Fi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block automatic connect hotspots.
        /// Indicates whether or not to block automatically connecting to Wi-Fi hotspots. Has no impact if Wi-Fi is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockAutomaticConnectHotspots", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockAutomaticConnectHotspots { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block hotspot reporting.
        /// Indicates whether or not to block Wi-Fi hotspot reporting. Has no impact if Wi-Fi is blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockHotspotReporting", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockHotspotReporting { get; set; }
    
        /// <summary>
        /// Gets or sets windows store blocked.
        /// Indicates whether or not to block the Windows Store.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsStoreBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? WindowsStoreBlocked { get; set; }
    
    }
}

