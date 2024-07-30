// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class LuisConfig : IUtf8JsonSerializable, IJsonModel<LuisConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LuisConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LuisConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LuisConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(CallingOptions))
            {
                writer.WritePropertyName("callingOptions"u8);
                writer.WriteObjectValue(CallingOptions, options);
            }
            writer.WritePropertyName("targetProjectKind"u8);
            writer.WriteStringValue(TargetProjectKind.ToString());
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        LuisConfig IJsonModel<LuisConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LuisConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLuisConfig(document.RootElement, options);
        }

        internal static LuisConfig DeserializeLuisConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string query = default;
            LuisCallingConfig callingOptions = default;
            TargetProjectKind targetProjectKind = default;
            string apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callingOptions = LuisCallingConfig.DeserializeLuisCallingConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetProjectKind"u8))
                {
                    targetProjectKind = new TargetProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LuisConfig(targetProjectKind, apiVersion, serializedAdditionalRawData, query, callingOptions);
        }

        BinaryData IPersistableModel<LuisConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LuisConfig)} does not support writing '{options.Format}' format.");
            }
        }

        LuisConfig IPersistableModel<LuisConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLuisConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LuisConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LuisConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LuisConfig FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLuisConfig(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
