// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automanage
{
    public partial class AutomanageVmConfigurationProfileAssignmentReportResource : IJsonModel<AutomanageConfigurationProfileAssignmentReportData>
    {
        void IJsonModel<AutomanageConfigurationProfileAssignmentReportData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomanageConfigurationProfileAssignmentReportData>)Data).Write(writer, options);

        AutomanageConfigurationProfileAssignmentReportData IJsonModel<AutomanageConfigurationProfileAssignmentReportData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomanageConfigurationProfileAssignmentReportData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AutomanageConfigurationProfileAssignmentReportData IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomanageConfigurationProfileAssignmentReportData>(data, options);

        string IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomanageConfigurationProfileAssignmentReportData>)Data).GetFormatFromOptions(options);
    }
}
