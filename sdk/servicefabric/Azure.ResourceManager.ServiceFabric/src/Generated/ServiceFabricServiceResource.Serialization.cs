// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricServiceResource : IJsonModel<ServiceFabricServiceData>
    {
        void IJsonModel<ServiceFabricServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricServiceData>)Data).Write(writer, options);

        ServiceFabricServiceData IJsonModel<ServiceFabricServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceFabricServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServiceFabricServiceData IPersistableModel<ServiceFabricServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceFabricServiceData>(data, options);

        string IPersistableModel<ServiceFabricServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceFabricServiceData>)Data).GetFormatFromOptions(options);
    }
}
