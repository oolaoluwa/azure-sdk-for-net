// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class VirtualMachineScaleSetVmExtensionResource : IJsonModel<VirtualMachineScaleSetVmExtensionData>
    {
        void IJsonModel<VirtualMachineScaleSetVmExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetVmExtensionData>)Data).Write(writer, options);

        VirtualMachineScaleSetVmExtensionData IJsonModel<VirtualMachineScaleSetVmExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VirtualMachineScaleSetVmExtensionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VirtualMachineScaleSetVmExtensionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VirtualMachineScaleSetVmExtensionData IPersistableModel<VirtualMachineScaleSetVmExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VirtualMachineScaleSetVmExtensionData>(data, options);

        string IPersistableModel<VirtualMachineScaleSetVmExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VirtualMachineScaleSetVmExtensionData>)Data).GetFormatFromOptions(options);
    }
}
