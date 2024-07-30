// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class SshPublicKeyResource : IJsonModel<SshPublicKeyData>
    {
        void IJsonModel<SshPublicKeyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SshPublicKeyData>)Data).Write(writer, options);

        SshPublicKeyData IJsonModel<SshPublicKeyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SshPublicKeyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SshPublicKeyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SshPublicKeyData IPersistableModel<SshPublicKeyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SshPublicKeyData>(data, options);

        string IPersistableModel<SshPublicKeyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SshPublicKeyData>)Data).GetFormatFromOptions(options);
    }
}
