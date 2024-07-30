// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Storage
{
    public partial class BlobServiceResource : IJsonModel<BlobServiceData>
    {
        void IJsonModel<BlobServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BlobServiceData>)Data).Write(writer, options);

        BlobServiceData IJsonModel<BlobServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BlobServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<BlobServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        BlobServiceData IPersistableModel<BlobServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BlobServiceData>(data, options);

        string IPersistableModel<BlobServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BlobServiceData>)Data).GetFormatFromOptions(options);
    }
}
