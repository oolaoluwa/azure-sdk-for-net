// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> AzureBackup RecoveryPointTime Based Restore Request. </summary>
    public partial class BackupRecoveryTimeBasedRestoreContent : BackupRestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="BackupRecoveryTimeBasedRestoreContent"/>. </summary>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <param name="recoverOn"> The recovery time in ISO 8601 format example - 2020-08-14T17:30:00.0000000Z. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreTargetInfo"/> is null. </exception>
        public BackupRecoveryTimeBasedRestoreContent(RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType, DateTimeOffset recoverOn) : base(restoreTargetInfo, sourceDataStoreType)
        {
            Argument.AssertNotNull(restoreTargetInfo, nameof(restoreTargetInfo));

            RecoverOn = recoverOn;
            ObjectType = "AzureBackupRecoveryTimeBasedRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="BackupRecoveryTimeBasedRestoreContent"/>. </summary>
        /// <param name="objectType"></param>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <param name="sourceResourceId"> Fully qualified Azure Resource Manager ID of the datasource which is being recovered. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="identityDetails">
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoverOn"> The recovery time in ISO 8601 format example - 2020-08-14T17:30:00.0000000Z. </param>
        internal BackupRecoveryTimeBasedRestoreContent(string objectType, RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType, ResourceIdentifier sourceResourceId, IList<string> resourceGuardOperationRequests, DataProtectionIdentityDetails identityDetails, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset recoverOn) : base(objectType, restoreTargetInfo, sourceDataStoreType, sourceResourceId, resourceGuardOperationRequests, identityDetails, serializedAdditionalRawData)
        {
            RecoverOn = recoverOn;
            ObjectType = objectType ?? "AzureBackupRecoveryTimeBasedRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="BackupRecoveryTimeBasedRestoreContent"/> for deserialization. </summary>
        internal BackupRecoveryTimeBasedRestoreContent()
        {
        }

        /// <summary> The recovery time in ISO 8601 format example - 2020-08-14T17:30:00.0000000Z. </summary>
        public DateTimeOffset RecoverOn { get; }
    }
}
