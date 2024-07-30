// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseAdvancedThreatProtectionResource : IJsonModel<ManagedDatabaseAdvancedThreatProtectionData>
    {
        void IJsonModel<ManagedDatabaseAdvancedThreatProtectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedDatabaseAdvancedThreatProtectionData>)Data).Write(writer, options);

        ManagedDatabaseAdvancedThreatProtectionData IJsonModel<ManagedDatabaseAdvancedThreatProtectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedDatabaseAdvancedThreatProtectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedDatabaseAdvancedThreatProtectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedDatabaseAdvancedThreatProtectionData IPersistableModel<ManagedDatabaseAdvancedThreatProtectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedDatabaseAdvancedThreatProtectionData>(data, options);

        string IPersistableModel<ManagedDatabaseAdvancedThreatProtectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedDatabaseAdvancedThreatProtectionData>)Data).GetFormatFromOptions(options);
    }
}
