// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class DscNodeConfigurationResource : IJsonModel<DscNodeConfigurationData>
    {
        void IJsonModel<DscNodeConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DscNodeConfigurationData>)Data).Write(writer, options);

        DscNodeConfigurationData IJsonModel<DscNodeConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DscNodeConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DscNodeConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DscNodeConfigurationData IPersistableModel<DscNodeConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DscNodeConfigurationData>(data, options);

        string IPersistableModel<DscNodeConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DscNodeConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
