// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteSlotFtpPublishingCredentialsPolicyResource : IJsonModel<CsmPublishingCredentialsPoliciesEntityData>
    {
        void IJsonModel<CsmPublishingCredentialsPoliciesEntityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CsmPublishingCredentialsPoliciesEntityData>)Data).Write(writer, options);

        CsmPublishingCredentialsPoliciesEntityData IJsonModel<CsmPublishingCredentialsPoliciesEntityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CsmPublishingCredentialsPoliciesEntityData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CsmPublishingCredentialsPoliciesEntityData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CsmPublishingCredentialsPoliciesEntityData IPersistableModel<CsmPublishingCredentialsPoliciesEntityData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CsmPublishingCredentialsPoliciesEntityData>(data, options);

        string IPersistableModel<CsmPublishingCredentialsPoliciesEntityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CsmPublishingCredentialsPoliciesEntityData>)Data).GetFormatFromOptions(options);
    }
}
