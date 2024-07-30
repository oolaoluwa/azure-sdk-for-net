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

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class MessageCountDetails : IUtf8JsonSerializable, IJsonModel<MessageCountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageCountDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MessageCountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageCountDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ActiveMessageCount))
            {
                writer.WritePropertyName("activeMessageCount"u8);
                writer.WriteNumberValue(ActiveMessageCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DeadLetterMessageCount))
            {
                writer.WritePropertyName("deadLetterMessageCount"u8);
                writer.WriteNumberValue(DeadLetterMessageCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScheduledMessageCount))
            {
                writer.WritePropertyName("scheduledMessageCount"u8);
                writer.WriteNumberValue(ScheduledMessageCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TransferMessageCount))
            {
                writer.WritePropertyName("transferMessageCount"u8);
                writer.WriteNumberValue(TransferMessageCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TransferDeadLetterMessageCount))
            {
                writer.WritePropertyName("transferDeadLetterMessageCount"u8);
                writer.WriteNumberValue(TransferDeadLetterMessageCount.Value);
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

        MessageCountDetails IJsonModel<MessageCountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageCountDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageCountDetails(document.RootElement, options);
        }

        internal static MessageCountDetails DeserializeMessageCountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? activeMessageCount = default;
            long? deadLetterMessageCount = default;
            long? scheduledMessageCount = default;
            long? transferMessageCount = default;
            long? transferDeadLetterMessageCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deadLetterMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scheduledMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transferMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transferDeadLetterMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferDeadLetterMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageCountDetails(
                activeMessageCount,
                deadLetterMessageCount,
                scheduledMessageCount,
                transferMessageCount,
                transferDeadLetterMessageCount,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActiveMessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  activeMessageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActiveMessageCount))
                {
                    builder.Append("  activeMessageCount: ");
                    builder.AppendLine($"'{ActiveMessageCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetterMessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deadLetterMessageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetterMessageCount))
                {
                    builder.Append("  deadLetterMessageCount: ");
                    builder.AppendLine($"'{DeadLetterMessageCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScheduledMessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scheduledMessageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScheduledMessageCount))
                {
                    builder.Append("  scheduledMessageCount: ");
                    builder.AppendLine($"'{ScheduledMessageCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TransferMessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  transferMessageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TransferMessageCount))
                {
                    builder.Append("  transferMessageCount: ");
                    builder.AppendLine($"'{TransferMessageCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TransferDeadLetterMessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  transferDeadLetterMessageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TransferDeadLetterMessageCount))
                {
                    builder.Append("  transferDeadLetterMessageCount: ");
                    builder.AppendLine($"'{TransferDeadLetterMessageCount.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MessageCountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MessageCountDetails)} does not support writing '{options.Format}' format.");
            }
        }

        MessageCountDetails IPersistableModel<MessageCountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageCountDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageCountDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageCountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
