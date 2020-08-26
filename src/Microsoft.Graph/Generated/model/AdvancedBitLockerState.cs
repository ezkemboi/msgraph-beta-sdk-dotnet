// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AdvancedBitLockerState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum AdvancedBitLockerState
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// No User Consent
        /// </summary>
        NoUserConsent = 1,
	
        /// <summary>
        /// Os Volume Encryption Method Mismatch
        /// </summary>
        OsVolumeEncryptionMethodMismatch = 2,
	
        /// <summary>
        /// Os Volume Tpm Required
        /// </summary>
        OsVolumeTpmRequired = 4,
	
        /// <summary>
        /// Os Volume Tpm Only Required
        /// </summary>
        OsVolumeTpmOnlyRequired = 8,
	
        /// <summary>
        /// Os Volume Tpm Pin Required
        /// </summary>
        OsVolumeTpmPinRequired = 16,
	
        /// <summary>
        /// Os Volume Tpm Startup Key Required
        /// </summary>
        OsVolumeTpmStartupKeyRequired = 32,
	
        /// <summary>
        /// Os Volume Tpm Pin Startup Key Required
        /// </summary>
        OsVolumeTpmPinStartupKeyRequired = 64,
	
        /// <summary>
        /// Os Volume Unprotected
        /// </summary>
        OsVolumeUnprotected = 128,
	
        /// <summary>
        /// Recovery Key Backup Failed
        /// </summary>
        RecoveryKeyBackupFailed = 256,
	
        /// <summary>
        /// Fixed Drive Not Encrypted
        /// </summary>
        FixedDriveNotEncrypted = 512,
	
        /// <summary>
        /// Fixed Drive Encryption Method Mismatch
        /// </summary>
        FixedDriveEncryptionMethodMismatch = 1024,
	
        /// <summary>
        /// Logged On User Non Admin
        /// </summary>
        LoggedOnUserNonAdmin = 2048,
	
        /// <summary>
        /// Windows Recovery Environment Not Configured
        /// </summary>
        WindowsRecoveryEnvironmentNotConfigured = 4096,
	
        /// <summary>
        /// Tpm Not Available
        /// </summary>
        TpmNotAvailable = 8192,
	
        /// <summary>
        /// Tpm Not Ready
        /// </summary>
        TpmNotReady = 16384,
	
        /// <summary>
        /// Network Error
        /// </summary>
        NetworkError = 32768,
	
    }
}