// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class HciSkuResource : IJsonModel<HciSkuData>
    {
        void IJsonModel<HciSkuData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HciSkuData>)Data).Write(writer, options);

        HciSkuData IJsonModel<HciSkuData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HciSkuData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HciSkuData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HciSkuData IPersistableModel<HciSkuData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HciSkuData>(data, options);

        string IPersistableModel<HciSkuData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HciSkuData>)Data).GetFormatFromOptions(options);
    }
}
