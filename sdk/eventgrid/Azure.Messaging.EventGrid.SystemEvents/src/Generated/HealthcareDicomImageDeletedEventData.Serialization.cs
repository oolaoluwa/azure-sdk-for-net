// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class HealthcareDicomImageDeletedEventData : IUtf8JsonSerializable, IJsonModel<HealthcareDicomImageDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareDicomImageDeletedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareDicomImageDeletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageDeletedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PartitionName))
            {
                writer.WritePropertyName("partitionName"u8);
                writer.WriteStringValue(PartitionName);
            }
            if (Optional.IsDefined(ImageStudyInstanceUid))
            {
                writer.WritePropertyName("imageStudyInstanceUid"u8);
                writer.WriteStringValue(ImageStudyInstanceUid);
            }
            if (Optional.IsDefined(ImageSeriesInstanceUid))
            {
                writer.WritePropertyName("imageSeriesInstanceUid"u8);
                writer.WriteStringValue(ImageSeriesInstanceUid);
            }
            if (Optional.IsDefined(ImageSopInstanceUid))
            {
                writer.WritePropertyName("imageSopInstanceUid"u8);
                writer.WriteStringValue(ImageSopInstanceUid);
            }
            if (Optional.IsDefined(ServiceHostName))
            {
                writer.WritePropertyName("serviceHostName"u8);
                writer.WriteStringValue(ServiceHostName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
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

        HealthcareDicomImageDeletedEventData IJsonModel<HealthcareDicomImageDeletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareDicomImageDeletedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement, options);
        }

        internal static HealthcareDicomImageDeletedEventData DeserializeHealthcareDicomImageDeletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partitionName = default;
            string imageStudyInstanceUid = default;
            string imageSeriesInstanceUid = default;
            string imageSopInstanceUid = default;
            string serviceHostName = default;
            long? sequenceNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionName"u8))
                {
                    partitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageStudyInstanceUid"u8))
                {
                    imageStudyInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSeriesInstanceUid"u8))
                {
                    imageSeriesInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageSopInstanceUid"u8))
                {
                    imageSopInstanceUid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceHostName"u8))
                {
                    serviceHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareDicomImageDeletedEventData(
                partitionName,
                imageStudyInstanceUid,
                imageSeriesInstanceUid,
                imageSopInstanceUid,
                serviceHostName,
                sequenceNumber,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareDicomImageDeletedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareDicomImageDeletedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareDicomImageDeletedEventData IPersistableModel<HealthcareDicomImageDeletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareDicomImageDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareDicomImageDeletedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareDicomImageDeletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static HealthcareDicomImageDeletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeHealthcareDicomImageDeletedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
