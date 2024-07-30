// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ContainerServiceTrustedAccessRoleBindingResource : IJsonModel<ContainerServiceTrustedAccessRoleBindingData>
    {
        void IJsonModel<ContainerServiceTrustedAccessRoleBindingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceTrustedAccessRoleBindingData>)Data).Write(writer, options);

        ContainerServiceTrustedAccessRoleBindingData IJsonModel<ContainerServiceTrustedAccessRoleBindingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceTrustedAccessRoleBindingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ContainerServiceTrustedAccessRoleBindingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ContainerServiceTrustedAccessRoleBindingData IPersistableModel<ContainerServiceTrustedAccessRoleBindingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ContainerServiceTrustedAccessRoleBindingData>(data, options);

        string IPersistableModel<ContainerServiceTrustedAccessRoleBindingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ContainerServiceTrustedAccessRoleBindingData>)Data).GetFormatFromOptions(options);
    }
}
