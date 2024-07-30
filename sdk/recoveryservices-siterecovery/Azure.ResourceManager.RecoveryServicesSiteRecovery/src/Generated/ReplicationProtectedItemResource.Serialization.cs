// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    public partial class ReplicationProtectedItemResource : IJsonModel<ReplicationProtectedItemData>
    {
        void IJsonModel<ReplicationProtectedItemData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ReplicationProtectedItemData>)Data).Write(writer, options);

        ReplicationProtectedItemData IJsonModel<ReplicationProtectedItemData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ReplicationProtectedItemData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ReplicationProtectedItemData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ReplicationProtectedItemData IPersistableModel<ReplicationProtectedItemData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ReplicationProtectedItemData>(data, options);

        string IPersistableModel<ReplicationProtectedItemData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ReplicationProtectedItemData>)Data).GetFormatFromOptions(options);
    }
}
