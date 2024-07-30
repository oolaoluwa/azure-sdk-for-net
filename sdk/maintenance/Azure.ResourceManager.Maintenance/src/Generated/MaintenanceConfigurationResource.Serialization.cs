// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Maintenance
{
    public partial class MaintenanceConfigurationResource : IJsonModel<MaintenanceConfigurationData>
    {
        void IJsonModel<MaintenanceConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MaintenanceConfigurationData>)Data).Write(writer, options);

        MaintenanceConfigurationData IJsonModel<MaintenanceConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MaintenanceConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MaintenanceConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MaintenanceConfigurationData IPersistableModel<MaintenanceConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MaintenanceConfigurationData>(data, options);

        string IPersistableModel<MaintenanceConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MaintenanceConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
