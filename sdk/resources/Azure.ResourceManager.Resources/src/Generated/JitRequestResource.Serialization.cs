// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class JitRequestResource : IJsonModel<JitRequestData>
    {
        void IJsonModel<JitRequestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<JitRequestData>)Data).Write(writer, options);

        JitRequestData IJsonModel<JitRequestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<JitRequestData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<JitRequestData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        JitRequestData IPersistableModel<JitRequestData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<JitRequestData>(data, options);

        string IPersistableModel<JitRequestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<JitRequestData>)Data).GetFormatFromOptions(options);
    }
}
