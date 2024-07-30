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
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class PortalConfigContractData : IUtf8JsonSerializable, IJsonModel<PortalConfigContractData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PortalConfigContractData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PortalConfigContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalConfigContractData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PortalConfigContractData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableBasicAuth))
            {
                writer.WritePropertyName("enableBasicAuth"u8);
                writer.WriteBooleanValue(EnableBasicAuth.Value);
            }
            if (Optional.IsDefined(Signin))
            {
                writer.WritePropertyName("signin"u8);
                writer.WriteObjectValue(Signin, options);
            }
            if (Optional.IsDefined(Signup))
            {
                writer.WritePropertyName("signup"u8);
                writer.WriteObjectValue(Signup, options);
            }
            if (Optional.IsDefined(Delegation))
            {
                writer.WritePropertyName("delegation"u8);
                writer.WriteObjectValue(Delegation, options);
            }
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteObjectValue(Cors, options);
            }
            if (Optional.IsDefined(Csp))
            {
                writer.WritePropertyName("csp"u8);
                writer.WriteObjectValue(Csp, options);
            }
            writer.WriteEndObject();
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

        PortalConfigContractData IJsonModel<PortalConfigContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalConfigContractData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PortalConfigContractData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePortalConfigContractData(document.RootElement, options);
        }

        internal static PortalConfigContractData DeserializePortalConfigContractData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            bool? enableBasicAuth = default;
            PortalConfigPropertiesSignin signin = default;
            PortalConfigPropertiesSignup signup = default;
            PortalConfigDelegationProperties delegation = default;
            PortalConfigCorsProperties cors = default;
            PortalConfigCspProperties csp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("enableBasicAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBasicAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("signin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signin = PortalConfigPropertiesSignin.DeserializePortalConfigPropertiesSignin(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("signup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            signup = PortalConfigPropertiesSignup.DeserializePortalConfigPropertiesSignup(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("delegation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delegation = PortalConfigDelegationProperties.DeserializePortalConfigDelegationProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cors = PortalConfigCorsProperties.DeserializePortalConfigCorsProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("csp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            csp = PortalConfigCspProperties.DeserializePortalConfigCspProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PortalConfigContractData(
                id,
                name,
                type,
                systemData,
                enableBasicAuth,
                signin,
                signup,
                delegation,
                cors,
                csp,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnableBasicAuth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enableBasicAuth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnableBasicAuth))
                {
                    builder.Append("    enableBasicAuth: ");
                    var boolValue = EnableBasicAuth.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("Require", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    signin: ");
                builder.AppendLine("{");
                builder.AppendLine("      signin: {");
                builder.Append("        require: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Signin))
                {
                    builder.Append("    signin: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Signin, options, 4, false, "    signin: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SignupTermsOfService", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    signup: ");
                builder.AppendLine("{");
                builder.AppendLine("      signup: {");
                builder.Append("        termsOfService: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Signup))
                {
                    builder.Append("    signup: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Signup, options, 4, false, "    signup: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Delegation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    delegation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Delegation))
                {
                    builder.Append("    delegation: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Delegation, options, 4, false, "    delegation: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("CorsAllowedOrigins", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    cors: ");
                builder.AppendLine("{");
                builder.AppendLine("      cors: {");
                builder.Append("        allowedOrigins: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Cors))
                {
                    builder.Append("    cors: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Cors, options, 4, false, "    cors: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Csp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    csp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Csp))
                {
                    builder.Append("    csp: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Csp, options, 4, false, "    csp: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PortalConfigContractData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalConfigContractData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PortalConfigContractData)} does not support writing '{options.Format}' format.");
            }
        }

        PortalConfigContractData IPersistableModel<PortalConfigContractData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PortalConfigContractData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePortalConfigContractData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PortalConfigContractData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PortalConfigContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
