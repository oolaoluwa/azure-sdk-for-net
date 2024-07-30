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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerThrottlingInfo : IUtf8JsonSerializable, IJsonModel<ContainerThrottlingInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerThrottlingInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerThrottlingInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerThrottlingInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerThrottlingInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Periods))
            {
                writer.WritePropertyName("periods"u8);
                writer.WriteNumberValue(Periods.Value);
            }
            if (Optional.IsDefined(ThrottledPeriods))
            {
                writer.WritePropertyName("throttledPeriods"u8);
                writer.WriteNumberValue(ThrottledPeriods.Value);
            }
            if (Optional.IsDefined(ThrottledTime))
            {
                writer.WritePropertyName("throttledTime"u8);
                writer.WriteNumberValue(ThrottledTime.Value);
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

        ContainerThrottlingInfo IJsonModel<ContainerThrottlingInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerThrottlingInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerThrottlingInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerThrottlingInfo(document.RootElement, options);
        }

        internal static ContainerThrottlingInfo DeserializeContainerThrottlingInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? periods = default;
            int? throttledPeriods = default;
            int? throttledTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    periods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttledPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttledPeriods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttledTime = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerThrottlingInfo(periods, throttledPeriods, throttledTime, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Periods), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  periods: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Periods))
                {
                    builder.Append("  periods: ");
                    builder.AppendLine($"{Periods.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThrottledPeriods), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throttledPeriods: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThrottledPeriods))
                {
                    builder.Append("  throttledPeriods: ");
                    builder.AppendLine($"{ThrottledPeriods.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThrottledTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throttledTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThrottledTime))
                {
                    builder.Append("  throttledTime: ");
                    builder.AppendLine($"{ThrottledTime.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerThrottlingInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerThrottlingInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerThrottlingInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerThrottlingInfo IPersistableModel<ContainerThrottlingInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerThrottlingInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerThrottlingInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerThrottlingInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerThrottlingInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
