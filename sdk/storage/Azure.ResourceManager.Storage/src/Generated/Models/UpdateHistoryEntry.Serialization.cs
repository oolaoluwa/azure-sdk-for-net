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
    public partial class UpdateHistoryEntry : IUtf8JsonSerializable, IJsonModel<UpdateHistoryEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateHistoryEntry>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateHistoryEntry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateHistoryEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateHistoryEntry)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("update"u8);
                writer.WriteStringValue(UpdateType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ImmutabilityPeriodSinceCreationInDays))
            {
                writer.WritePropertyName("immutabilityPeriodSinceCreationInDays"u8);
                writer.WriteNumberValue(ImmutabilityPeriodSinceCreationInDays.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectIdentifier))
            {
                writer.WritePropertyName("objectIdentifier"u8);
                writer.WriteStringValue(ObjectIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Upn))
            {
                writer.WritePropertyName("upn"u8);
                writer.WriteStringValue(Upn);
            }
            if (Optional.IsDefined(AllowProtectedAppendWrites))
            {
                writer.WritePropertyName("allowProtectedAppendWrites"u8);
                writer.WriteBooleanValue(AllowProtectedAppendWrites.Value);
            }
            if (Optional.IsDefined(AllowProtectedAppendWritesAll))
            {
                writer.WritePropertyName("allowProtectedAppendWritesAll"u8);
                writer.WriteBooleanValue(AllowProtectedAppendWritesAll.Value);
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

        UpdateHistoryEntry IJsonModel<UpdateHistoryEntry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateHistoryEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateHistoryEntry)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateHistoryEntry(document.RootElement, options);
        }

        internal static UpdateHistoryEntry DeserializeUpdateHistoryEntry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImmutabilityPolicyUpdateType? update = default;
            int? immutabilityPeriodSinceCreationInDays = default;
            DateTimeOffset? timestamp = default;
            string objectIdentifier = default;
            Guid? tenantId = default;
            string upn = default;
            bool? allowProtectedAppendWrites = default;
            bool? allowProtectedAppendWritesAll = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("update"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    update = new ImmutabilityPolicyUpdateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("immutabilityPeriodSinceCreationInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    immutabilityPeriodSinceCreationInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectIdentifier"u8))
                {
                    objectIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("upn"u8))
                {
                    upn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowProtectedAppendWrites"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowProtectedAppendWrites = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowProtectedAppendWritesAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowProtectedAppendWritesAll = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateHistoryEntry(
                update,
                immutabilityPeriodSinceCreationInDays,
                timestamp,
                objectIdentifier,
                tenantId,
                upn,
                allowProtectedAppendWrites,
                allowProtectedAppendWritesAll,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdateType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  update: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdateType))
                {
                    builder.Append("  update: ");
                    builder.AppendLine($"'{UpdateType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImmutabilityPeriodSinceCreationInDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  immutabilityPeriodSinceCreationInDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ImmutabilityPeriodSinceCreationInDays))
                {
                    builder.Append("  immutabilityPeriodSinceCreationInDays: ");
                    builder.AppendLine($"{ImmutabilityPeriodSinceCreationInDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timestamp))
                {
                    builder.Append("  timestamp: ");
                    var formattedDateTimeString = TypeFormatters.ToString(Timestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ObjectIdentifier), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  objectIdentifier: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ObjectIdentifier))
                {
                    builder.Append("  objectIdentifier: ");
                    if (ObjectIdentifier.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ObjectIdentifier}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ObjectIdentifier}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TenantId))
                {
                    builder.Append("  tenantId: ");
                    builder.AppendLine($"'{TenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Upn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Upn))
                {
                    builder.Append("  upn: ");
                    if (Upn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Upn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Upn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowProtectedAppendWrites), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowProtectedAppendWrites: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowProtectedAppendWrites))
                {
                    builder.Append("  allowProtectedAppendWrites: ");
                    var boolValue = AllowProtectedAppendWrites.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowProtectedAppendWritesAll), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowProtectedAppendWritesAll: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowProtectedAppendWritesAll))
                {
                    builder.Append("  allowProtectedAppendWritesAll: ");
                    var boolValue = AllowProtectedAppendWritesAll.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<UpdateHistoryEntry>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateHistoryEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(UpdateHistoryEntry)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateHistoryEntry IPersistableModel<UpdateHistoryEntry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateHistoryEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateHistoryEntry(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateHistoryEntry)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateHistoryEntry>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
