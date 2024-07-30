// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicTypeResource : IJsonModel<TopicTypeData>
    {
        void IJsonModel<TopicTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TopicTypeData>)Data).Write(writer, options);

        TopicTypeData IJsonModel<TopicTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TopicTypeData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TopicTypeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TopicTypeData IPersistableModel<TopicTypeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TopicTypeData>(data, options);

        string IPersistableModel<TopicTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TopicTypeData>)Data).GetFormatFromOptions(options);
    }
}
