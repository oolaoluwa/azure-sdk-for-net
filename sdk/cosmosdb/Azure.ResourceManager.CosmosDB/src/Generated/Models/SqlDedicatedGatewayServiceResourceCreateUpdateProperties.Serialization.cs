// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class SqlDedicatedGatewayServiceResourceCreateUpdateProperties : IUtf8JsonSerializable, IJsonModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceResourceCreateUpdateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DedicatedGatewayType))
            {
                writer.WritePropertyName("dedicatedGatewayType"u8);
                writer.WriteStringValue(DedicatedGatewayType.Value.ToString());
            }
            if (Optional.IsDefined(InstanceSize))
            {
                writer.WritePropertyName("instanceSize"u8);
                writer.WriteStringValue(InstanceSize.Value.ToString());
            }
            if (Optional.IsDefined(InstanceCount))
            {
                writer.WritePropertyName("instanceCount"u8);
                writer.WriteNumberValue(InstanceCount.Value);
            }
            writer.WritePropertyName("serviceType"u8);
            writer.WriteStringValue(ServiceType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SqlDedicatedGatewayServiceResourceCreateUpdateProperties IJsonModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceResourceCreateUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDedicatedGatewayServiceResourceCreateUpdateProperties(document.RootElement, options);
        }

        internal static SqlDedicatedGatewayServiceResourceCreateUpdateProperties DeserializeSqlDedicatedGatewayServiceResourceCreateUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DedicatedGatewayType? dedicatedGatewayType = default;
            CosmosDBServiceSize? instanceSize = default;
            int? instanceCount = default;
            CosmosDBServiceType serviceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dedicatedGatewayType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dedicatedGatewayType = new DedicatedGatewayType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceSize = new CosmosDBServiceSize(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceType"u8))
                {
                    serviceType = new CosmosDBServiceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlDedicatedGatewayServiceResourceCreateUpdateProperties(instanceSize, instanceCount, serviceType, serializedAdditionalRawData, dedicatedGatewayType);
        }

        BinaryData IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceResourceCreateUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SqlDedicatedGatewayServiceResourceCreateUpdateProperties IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlDedicatedGatewayServiceResourceCreateUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlDedicatedGatewayServiceResourceCreateUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlDedicatedGatewayServiceResourceCreateUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
