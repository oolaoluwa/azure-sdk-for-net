// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    internal partial class PrivateEndpoint : IUtf8JsonSerializable, IJsonModel<PrivateEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        PrivateEndpoint IJsonModel<PrivateEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpoint(document.RootElement, options);
        }

        internal static PrivateEndpoint DeserializePrivateEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateEndpoint(id, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PrivateEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateEndpoint IPersistableModel<PrivateEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
