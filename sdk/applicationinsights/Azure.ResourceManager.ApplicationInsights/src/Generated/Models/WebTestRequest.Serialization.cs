// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class WebTestRequest : IUtf8JsonSerializable, IJsonModel<WebTestRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebTestRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebTestRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RequestUri))
            {
                writer.WritePropertyName("RequestUrl"u8);
                writer.WriteStringValue(RequestUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("Headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HttpVerb))
            {
                writer.WritePropertyName("HttpVerb"u8);
                writer.WriteStringValue(HttpVerb);
            }
            if (Optional.IsDefined(RequestBody))
            {
                writer.WritePropertyName("RequestBody"u8);
                writer.WriteStringValue(RequestBody);
            }
            if (Optional.IsDefined(ParseDependentRequests))
            {
                writer.WritePropertyName("ParseDependentRequests"u8);
                writer.WriteBooleanValue(ParseDependentRequests.Value);
            }
            if (Optional.IsDefined(FollowRedirects))
            {
                writer.WritePropertyName("FollowRedirects"u8);
                writer.WriteBooleanValue(FollowRedirects.Value);
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

        WebTestRequest IJsonModel<WebTestRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestRequest(document.RootElement, options);
        }

        internal static WebTestRequest DeserializeWebTestRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri requestUrl = default;
            IList<WebTestRequestHeaderField> headers = default;
            string httpVerb = default;
            string requestBody = default;
            bool? parseDependentRequests = default;
            bool? followRedirects = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("RequestUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebTestRequestHeaderField> array = new List<WebTestRequestHeaderField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebTestRequestHeaderField.DeserializeWebTestRequestHeaderField(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("HttpVerb"u8))
                {
                    httpVerb = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("RequestBody"u8))
                {
                    requestBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ParseDependentRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parseDependentRequests = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("FollowRedirects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    followRedirects = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebTestRequest(
                requestUrl,
                headers ?? new ChangeTrackingList<WebTestRequestHeaderField>(),
                httpVerb,
                requestBody,
                parseDependentRequests,
                followRedirects,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  RequestUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequestUri))
                {
                    builder.Append("  RequestUrl: ");
                    builder.AppendLine($"'{RequestUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Headers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Headers))
                {
                    if (Headers.Any())
                    {
                        builder.Append("  Headers: ");
                        builder.AppendLine("[");
                        foreach (var item in Headers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  Headers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HttpVerb), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  HttpVerb: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HttpVerb))
                {
                    builder.Append("  HttpVerb: ");
                    if (HttpVerb.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HttpVerb}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HttpVerb}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestBody), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  RequestBody: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequestBody))
                {
                    builder.Append("  RequestBody: ");
                    if (RequestBody.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RequestBody}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RequestBody}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ParseDependentRequests), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ParseDependentRequests: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ParseDependentRequests))
                {
                    builder.Append("  ParseDependentRequests: ");
                    var boolValue = ParseDependentRequests.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FollowRedirects), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  FollowRedirects: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FollowRedirects))
                {
                    builder.Append("  FollowRedirects: ");
                    var boolValue = FollowRedirects.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebTestRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebTestRequest)} does not support writing '{options.Format}' format.");
            }
        }

        WebTestRequest IPersistableModel<WebTestRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebTestRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebTestRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebTestRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
