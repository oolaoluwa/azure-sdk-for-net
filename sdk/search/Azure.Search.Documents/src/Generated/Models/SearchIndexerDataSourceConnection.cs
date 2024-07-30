// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents a datasource definition, which can be used to configure an indexer. </summary>
    public partial class SearchIndexerDataSourceConnection
    {
        /// <summary> Initializes a new instance of <see cref="SearchIndexerDataSourceConnection"/>. </summary>
        /// <param name="name"> The name of the datasource. </param>
        /// <param name="description"> The description of the datasource. </param>
        /// <param name="type"> The type of the datasource. </param>
        /// <param name="credentialsInternal"> Credentials for the datasource. </param>
        /// <param name="container"> The data container for the datasource. </param>
        /// <param name="dataChangeDetectionPolicy">
        /// The data change detection policy for the datasource.
        /// Please note <see cref="Models.DataChangeDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HighWaterMarkChangeDetectionPolicy"/> and <see cref="SqlIntegratedChangeTrackingPolicy"/>.
        /// </param>
        /// <param name="dataDeletionDetectionPolicy">
        /// The data deletion detection policy for the datasource.
        /// Please note <see cref="Models.DataDeletionDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SoftDeleteColumnDeletionDetectionPolicy"/>.
        /// </param>
        /// <param name="etag"> The ETag of the data source. </param>
        /// <param name="encryptionKey"> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your datasource definition when you want full assurance that no one, not even Microsoft, can decrypt your data source definition. Once you have encrypted your data source definition, it will always remain encrypted. The search service will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your datasource definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </param>
        internal SearchIndexerDataSourceConnection(string name, string description, SearchIndexerDataSourceType type, DataSourceCredentials credentialsInternal, SearchIndexerDataContainer container, DataChangeDetectionPolicy dataChangeDetectionPolicy, DataDeletionDetectionPolicy dataDeletionDetectionPolicy, string etag, SearchResourceEncryptionKey encryptionKey)
        {
            Name = name;
            Description = description;
            Type = type;
            CredentialsInternal = credentialsInternal;
            Container = container;
            DataChangeDetectionPolicy = dataChangeDetectionPolicy;
            DataDeletionDetectionPolicy = dataDeletionDetectionPolicy;
            _etag = etag;
            EncryptionKey = encryptionKey;
        }

        /// <summary> The name of the datasource. </summary>
        public string Name { get; set; }
        /// <summary> The description of the datasource. </summary>
        public string Description { get; set; }
        /// <summary> The type of the datasource. </summary>
        public SearchIndexerDataSourceType Type { get; set; }
        /// <summary> The data container for the datasource. </summary>
        public SearchIndexerDataContainer Container { get; set; }
        /// <summary>
        /// The data change detection policy for the datasource.
        /// Please note <see cref="Models.DataChangeDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HighWaterMarkChangeDetectionPolicy"/> and <see cref="SqlIntegratedChangeTrackingPolicy"/>.
        /// </summary>
        public DataChangeDetectionPolicy DataChangeDetectionPolicy { get; set; }
        /// <summary>
        /// The data deletion detection policy for the datasource.
        /// Please note <see cref="Models.DataDeletionDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SoftDeleteColumnDeletionDetectionPolicy"/>.
        /// </summary>
        public DataDeletionDetectionPolicy DataDeletionDetectionPolicy { get; set; }
        /// <summary> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your datasource definition when you want full assurance that no one, not even Microsoft, can decrypt your data source definition. Once you have encrypted your data source definition, it will always remain encrypted. The search service will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your datasource definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </summary>
        public SearchResourceEncryptionKey EncryptionKey { get; set; }
    }
}
