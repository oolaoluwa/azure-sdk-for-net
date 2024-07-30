// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class PrivateDnsZoneGroupResource : IJsonModel<PrivateDnsZoneGroupData>
    {
        void IJsonModel<PrivateDnsZoneGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PrivateDnsZoneGroupData>)Data).Write(writer, options);

        PrivateDnsZoneGroupData IJsonModel<PrivateDnsZoneGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PrivateDnsZoneGroupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PrivateDnsZoneGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PrivateDnsZoneGroupData IPersistableModel<PrivateDnsZoneGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PrivateDnsZoneGroupData>(data, options);

        string IPersistableModel<PrivateDnsZoneGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PrivateDnsZoneGroupData>)Data).GetFormatFromOptions(options);
    }
}
