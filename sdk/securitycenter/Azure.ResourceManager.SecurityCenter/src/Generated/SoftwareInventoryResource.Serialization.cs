// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SoftwareInventoryResource : IJsonModel<SoftwareInventoryData>
    {
        void IJsonModel<SoftwareInventoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SoftwareInventoryData>)Data).Write(writer, options);

        SoftwareInventoryData IJsonModel<SoftwareInventoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SoftwareInventoryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SoftwareInventoryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SoftwareInventoryData IPersistableModel<SoftwareInventoryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SoftwareInventoryData>(data, options);

        string IPersistableModel<SoftwareInventoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SoftwareInventoryData>)Data).GetFormatFromOptions(options);
    }
}
