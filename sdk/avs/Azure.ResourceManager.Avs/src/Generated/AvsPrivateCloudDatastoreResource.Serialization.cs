// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs
{
    public partial class AvsPrivateCloudDatastoreResource : IJsonModel<AvsPrivateCloudDatastoreData>
    {
        void IJsonModel<AvsPrivateCloudDatastoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AvsPrivateCloudDatastoreData>)Data).Write(writer, options);

        AvsPrivateCloudDatastoreData IJsonModel<AvsPrivateCloudDatastoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AvsPrivateCloudDatastoreData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AvsPrivateCloudDatastoreData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AvsPrivateCloudDatastoreData IPersistableModel<AvsPrivateCloudDatastoreData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AvsPrivateCloudDatastoreData>(data, options);

        string IPersistableModel<AvsPrivateCloudDatastoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AvsPrivateCloudDatastoreData>)Data).GetFormatFromOptions(options);
    }
}
