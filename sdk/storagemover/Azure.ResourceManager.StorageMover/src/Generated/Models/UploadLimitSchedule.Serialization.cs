// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    internal partial class UploadLimitSchedule : IUtf8JsonSerializable, IJsonModel<UploadLimitSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UploadLimitSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UploadLimitSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadLimitSchedule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(WeeklyRecurrences))
            {
                writer.WritePropertyName("weeklyRecurrences"u8);
                writer.WriteStartArray();
                foreach (var item in WeeklyRecurrences)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        UploadLimitSchedule IJsonModel<UploadLimitSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadLimitSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUploadLimitSchedule(document.RootElement, options);
        }

        internal static UploadLimitSchedule DeserializeUploadLimitSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<UploadLimitWeeklyRecurrence> weeklyRecurrences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weeklyRecurrences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UploadLimitWeeklyRecurrence> array = new List<UploadLimitWeeklyRecurrence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UploadLimitWeeklyRecurrence.DeserializeUploadLimitWeeklyRecurrence(item, options));
                    }
                    weeklyRecurrences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UploadLimitSchedule(weeklyRecurrences ?? new ChangeTrackingList<UploadLimitWeeklyRecurrence>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UploadLimitSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UploadLimitSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        UploadLimitSchedule IPersistableModel<UploadLimitSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUploadLimitSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UploadLimitSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UploadLimitSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
