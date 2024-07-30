// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedApplicationResource : IJsonModel<ServiceFabricManagedApplicationData>
    {
        void IJsonModel<ServiceFabricManagedApplicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricManagedApplicationData>)Data).Write(writer, options);

        ServiceFabricManagedApplicationData IJsonModel<ServiceFabricManagedApplicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricManagedApplicationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceFabricManagedApplicationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServiceFabricManagedApplicationData IPersistableModel<ServiceFabricManagedApplicationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceFabricManagedApplicationData>(data, options);

        string IPersistableModel<ServiceFabricManagedApplicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceFabricManagedApplicationData>)Data).GetFormatFromOptions(options);
    }
}
