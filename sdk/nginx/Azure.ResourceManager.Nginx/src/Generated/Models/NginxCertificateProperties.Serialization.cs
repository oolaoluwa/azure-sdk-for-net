// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxCertificateProperties : IUtf8JsonSerializable, IJsonModel<NginxCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxCertificateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NginxCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxCertificateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(KeyVirtualPath))
            {
                writer.WritePropertyName("keyVirtualPath"u8);
                writer.WriteStringValue(KeyVirtualPath);
            }
            if (Optional.IsDefined(CertificateVirtualPath))
            {
                writer.WritePropertyName("certificateVirtualPath"u8);
                writer.WriteStringValue(CertificateVirtualPath);
            }
            if (Optional.IsDefined(KeyVaultSecretId))
            {
                writer.WritePropertyName("keyVaultSecretId"u8);
                writer.WriteStringValue(KeyVaultSecretId);
            }
            if (options.Format != "W" && Optional.IsDefined(Sha1Thumbprint))
            {
                writer.WritePropertyName("sha1Thumbprint"u8);
                writer.WriteStringValue(Sha1Thumbprint);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultSecretVersion))
            {
                writer.WritePropertyName("keyVaultSecretVersion"u8);
                writer.WriteStringValue(KeyVaultSecretVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultSecretCreated))
            {
                writer.WritePropertyName("keyVaultSecretCreated"u8);
                writer.WriteStringValue(KeyVaultSecretCreated.Value, "O");
            }
            if (Optional.IsDefined(CertificateError))
            {
                writer.WritePropertyName("certificateError"u8);
                writer.WriteObjectValue(CertificateError, options);
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

        NginxCertificateProperties IJsonModel<NginxCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxCertificateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxCertificateProperties(document.RootElement, options);
        }

        internal static NginxCertificateProperties DeserializeNginxCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NginxProvisioningState? provisioningState = default;
            string keyVirtualPath = default;
            string certificateVirtualPath = default;
            string keyVaultSecretId = default;
            string sha1Thumbprint = default;
            string keyVaultSecretVersion = default;
            DateTimeOffset? keyVaultSecretCreated = default;
            NginxCertificateError certificateError = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new NginxProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVirtualPath"u8))
                {
                    keyVirtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateVirtualPath"u8))
                {
                    certificateVirtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretId"u8))
                {
                    keyVaultSecretId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sha1Thumbprint"u8))
                {
                    sha1Thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretVersion"u8))
                {
                    keyVaultSecretVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultSecretCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultSecretCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("certificateError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateError = NginxCertificateError.DeserializeNginxCertificateError(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NginxCertificateProperties(
                provisioningState,
                keyVirtualPath,
                certificateVirtualPath,
                keyVaultSecretId,
                sha1Thumbprint,
                keyVaultSecretVersion,
                keyVaultSecretCreated,
                certificateError,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxCertificateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NginxCertificateProperties IPersistableModel<NginxCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxCertificateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
