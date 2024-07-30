// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class GlobalRulestackCertificateObjectResource : IJsonModel<GlobalRulestackCertificateObjectData>
    {
        void IJsonModel<GlobalRulestackCertificateObjectData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GlobalRulestackCertificateObjectData>)Data).Write(writer, options);

        GlobalRulestackCertificateObjectData IJsonModel<GlobalRulestackCertificateObjectData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GlobalRulestackCertificateObjectData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GlobalRulestackCertificateObjectData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GlobalRulestackCertificateObjectData IPersistableModel<GlobalRulestackCertificateObjectData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GlobalRulestackCertificateObjectData>(data, options);

        string IPersistableModel<GlobalRulestackCertificateObjectData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GlobalRulestackCertificateObjectData>)Data).GetFormatFromOptions(options);
    }
}
