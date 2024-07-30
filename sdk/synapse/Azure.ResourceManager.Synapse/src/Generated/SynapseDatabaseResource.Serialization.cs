// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseDatabaseResource : IJsonModel<SynapseDatabaseData>
    {
        void IJsonModel<SynapseDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDatabaseData>)Data).Write(writer, options);

        SynapseDatabaseData IJsonModel<SynapseDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDatabaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseDatabaseData IPersistableModel<SynapseDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseDatabaseData>(data, options);

        string IPersistableModel<SynapseDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseDatabaseData>)Data).GetFormatFromOptions(options);
    }
}
