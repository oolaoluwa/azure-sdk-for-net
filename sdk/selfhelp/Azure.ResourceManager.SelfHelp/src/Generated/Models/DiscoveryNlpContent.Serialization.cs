// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class DiscoveryNlpContent : IUtf8JsonSerializable, IJsonModel<DiscoveryNlpContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveryNlpContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiscoveryNlpContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryNlpContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryNlpContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("issueSummary"u8);
            writer.WriteStringValue(IssueSummary);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ServiceId))
            {
                writer.WritePropertyName("serviceId"u8);
                writer.WriteStringValue(ServiceId);
            }
            if (Optional.IsDefined(AdditionalContext))
            {
                writer.WritePropertyName("additionalContext"u8);
                writer.WriteStringValue(AdditionalContext);
            }
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

        DiscoveryNlpContent IJsonModel<DiscoveryNlpContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryNlpContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryNlpContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveryNlpContent(document.RootElement, options);
        }

        internal static DiscoveryNlpContent DeserializeDiscoveryNlpContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string issueSummary = default;
            string resourceId = default;
            string serviceId = default;
            string additionalContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issueSummary"u8))
                {
                    issueSummary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceId"u8))
                {
                    serviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalContext"u8))
                {
                    additionalContext = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiscoveryNlpContent(issueSummary, resourceId, serviceId, additionalContext, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveryNlpContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryNlpContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveryNlpContent)} does not support writing '{options.Format}' format.");
            }
        }

        DiscoveryNlpContent IPersistableModel<DiscoveryNlpContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryNlpContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveryNlpContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveryNlpContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveryNlpContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
