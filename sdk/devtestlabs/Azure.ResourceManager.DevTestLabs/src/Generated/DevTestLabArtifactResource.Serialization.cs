// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabArtifactResource : IJsonModel<DevTestLabArtifactData>
    {
        void IJsonModel<DevTestLabArtifactData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabArtifactData>)Data).Write(writer, options);

        DevTestLabArtifactData IJsonModel<DevTestLabArtifactData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabArtifactData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevTestLabArtifactData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DevTestLabArtifactData IPersistableModel<DevTestLabArtifactData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevTestLabArtifactData>(data, options);

        string IPersistableModel<DevTestLabArtifactData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevTestLabArtifactData>)Data).GetFormatFromOptions(options);
    }
}
