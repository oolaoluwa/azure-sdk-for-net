// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Search
{
    public partial class NetworkSecurityPerimeterConfigurationResource : IJsonModel<NetworkSecurityPerimeterConfigurationData>
    {
        void IJsonModel<NetworkSecurityPerimeterConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkSecurityPerimeterConfigurationData>)Data).Write(writer, options);

        NetworkSecurityPerimeterConfigurationData IJsonModel<NetworkSecurityPerimeterConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkSecurityPerimeterConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        NetworkSecurityPerimeterConfigurationData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkSecurityPerimeterConfigurationData>(data, options);

        string IPersistableModel<NetworkSecurityPerimeterConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
