// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RedisEnterprise
{
    public partial class RedisEnterpriseClusterResource : IJsonModel<RedisEnterpriseClusterData>
    {
        void IJsonModel<RedisEnterpriseClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisEnterpriseClusterData>)Data).Write(writer, options);

        RedisEnterpriseClusterData IJsonModel<RedisEnterpriseClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisEnterpriseClusterData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RedisEnterpriseClusterData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RedisEnterpriseClusterData IPersistableModel<RedisEnterpriseClusterData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisEnterpriseClusterData>(data, options);

        string IPersistableModel<RedisEnterpriseClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisEnterpriseClusterData>)Data).GetFormatFromOptions(options);
    }
}
