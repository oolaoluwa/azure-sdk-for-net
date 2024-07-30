// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    public partial class UserAssignedIdentityResource : IJsonModel<UserAssignedIdentityData>
    {
        void IJsonModel<UserAssignedIdentityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<UserAssignedIdentityData>)Data).Write(writer, options);

        UserAssignedIdentityData IJsonModel<UserAssignedIdentityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<UserAssignedIdentityData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<UserAssignedIdentityData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        UserAssignedIdentityData IPersistableModel<UserAssignedIdentityData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<UserAssignedIdentityData>(data, options);

        string IPersistableModel<UserAssignedIdentityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<UserAssignedIdentityData>)Data).GetFormatFromOptions(options);
    }
}
