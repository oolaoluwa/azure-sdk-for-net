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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ApplicationStack : IUtf8JsonSerializable, IJsonModel<ApplicationStack>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationStack>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationStack>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStack)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Display))
            {
                writer.WritePropertyName("display"u8);
                writer.WriteStringValue(Display);
            }
            if (Optional.IsDefined(Dependency))
            {
                writer.WritePropertyName("dependency"u8);
                writer.WriteStringValue(Dependency);
            }
            if (Optional.IsCollectionDefined(MajorVersions))
            {
                writer.WritePropertyName("majorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MajorVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Frameworks))
            {
                writer.WritePropertyName("frameworks"u8);
                writer.WriteStartArray();
                foreach (var item in Frameworks)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteStartArray();
                foreach (var item in IsDeprecated)
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

        ApplicationStack IJsonModel<ApplicationStack>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationStack)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationStack(document.RootElement, options);
        }

        internal static ApplicationStack DeserializeApplicationStack(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string display = default;
            string dependency = default;
            IList<StackMajorVersion> majorVersions = default;
            IList<ApplicationStack> frameworks = default;
            IList<ApplicationStack> isDeprecated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"u8))
                {
                    display = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependency"u8))
                {
                    dependency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("majorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StackMajorVersion> array = new List<StackMajorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StackMajorVersion.DeserializeStackMajorVersion(item, options));
                    }
                    majorVersions = array;
                    continue;
                }
                if (property.NameEquals("frameworks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationStack> array = new List<ApplicationStack>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeApplicationStack(item, options));
                    }
                    frameworks = array;
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationStack> array = new List<ApplicationStack>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeApplicationStack(item, options));
                    }
                    isDeprecated = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationStack(
                name,
                display,
                dependency,
                majorVersions ?? new ChangeTrackingList<StackMajorVersion>(),
                frameworks ?? new ChangeTrackingList<ApplicationStack>(),
                isDeprecated ?? new ChangeTrackingList<ApplicationStack>(),
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Display), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  display: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Display))
                {
                    builder.Append("  display: ");
                    if (Display.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Display}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Display}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Dependency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dependency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Dependency))
                {
                    builder.Append("  dependency: ");
                    if (Dependency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Dependency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Dependency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MajorVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  majorVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(MajorVersions))
                {
                    if (MajorVersions.Any())
                    {
                        builder.Append("  majorVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in MajorVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  majorVersions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Frameworks), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  frameworks: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Frameworks))
                {
                    if (Frameworks.Any())
                    {
                        builder.Append("  frameworks: ");
                        builder.AppendLine("[");
                        foreach (var item in Frameworks)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  frameworks: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDeprecated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isDeprecated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IsDeprecated))
                {
                    if (IsDeprecated.Any())
                    {
                        builder.Append("  isDeprecated: ");
                        builder.AppendLine("[");
                        foreach (var item in IsDeprecated)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  isDeprecated: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationStack>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationStack)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationStack IPersistableModel<ApplicationStack>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationStack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationStack(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationStack)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationStack>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
