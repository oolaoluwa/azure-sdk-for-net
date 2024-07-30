// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Storage
{
    public partial class StorageQueueResource : IJsonModel<StorageQueueData>
    {
        void IJsonModel<StorageQueueData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StorageQueueData>)Data).Write(writer, options);

        StorageQueueData IJsonModel<StorageQueueData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StorageQueueData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StorageQueueData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        StorageQueueData IPersistableModel<StorageQueueData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StorageQueueData>(data, options);

        string IPersistableModel<StorageQueueData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StorageQueueData>)Data).GetFormatFromOptions(options);
    }
}
