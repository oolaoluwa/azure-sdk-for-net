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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageTaskAssignmentReport : IUtf8JsonSerializable, IJsonModel<StorageTaskAssignmentReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTaskAssignmentReport>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageTaskAssignmentReport>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskAssignmentReport)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("prefix"u8);
            writer.WriteStringValue(Prefix);
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

        StorageTaskAssignmentReport IJsonModel<StorageTaskAssignmentReport>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskAssignmentReport)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTaskAssignmentReport(document.RootElement, options);
        }

        internal static StorageTaskAssignmentReport DeserializeStorageTaskAssignmentReport(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageTaskAssignmentReport(prefix, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Prefix), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  prefix: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Prefix))
                {
                    builder.Append("  prefix: ");
                    if (Prefix.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Prefix}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Prefix}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StorageTaskAssignmentReport>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageTaskAssignmentReport)} does not support writing '{options.Format}' format.");
            }
        }

        StorageTaskAssignmentReport IPersistableModel<StorageTaskAssignmentReport>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskAssignmentReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageTaskAssignmentReport(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageTaskAssignmentReport)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageTaskAssignmentReport>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
