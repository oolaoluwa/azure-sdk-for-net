// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4Observation : IUtf8JsonSerializable, IJsonModel<FhirR4Observation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Observation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FhirR4Observation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Observation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Observation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteStartArray();
                foreach (var item in Identifier)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStartArray();
                foreach (var item in Category)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("code"u8);
            writer.WriteObjectValue(Code, options);
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteObjectValue(Subject, options);
            }
            if (Optional.IsDefined(Encounter))
            {
                writer.WritePropertyName("encounter"u8);
                writer.WriteObjectValue(Encounter, options);
            }
            if (Optional.IsDefined(EffectiveDateTime))
            {
                writer.WritePropertyName("effectiveDateTime"u8);
                writer.WriteStringValue(EffectiveDateTime);
            }
            if (Optional.IsDefined(EffectivePeriod))
            {
                writer.WritePropertyName("effectivePeriod"u8);
                writer.WriteObjectValue(EffectivePeriod, options);
            }
            if (Optional.IsDefined(EffectiveInstant))
            {
                writer.WritePropertyName("effectiveInstant"u8);
                writer.WriteStringValue(EffectiveInstant);
            }
            if (Optional.IsDefined(Issued))
            {
                writer.WritePropertyName("issued"u8);
                writer.WriteStringValue(Issued);
            }
            if (Optional.IsDefined(ValueQuantity))
            {
                writer.WritePropertyName("valueQuantity"u8);
                writer.WriteObjectValue(ValueQuantity, options);
            }
            if (Optional.IsDefined(ValueCodeableConcept))
            {
                writer.WritePropertyName("valueCodeableConcept"u8);
                writer.WriteObjectValue(ValueCodeableConcept, options);
            }
            if (Optional.IsDefined(ValueString))
            {
                writer.WritePropertyName("valueString"u8);
                writer.WriteStringValue(ValueString);
            }
            if (Optional.IsDefined(ValueBoolean))
            {
                writer.WritePropertyName("valueBoolean"u8);
                writer.WriteBooleanValue(ValueBoolean.Value);
            }
            if (Optional.IsDefined(ValueInteger))
            {
                writer.WritePropertyName("valueInteger"u8);
                writer.WriteNumberValue(ValueInteger.Value);
            }
            if (Optional.IsDefined(ValueRange))
            {
                writer.WritePropertyName("valueRange"u8);
                writer.WriteObjectValue(ValueRange, options);
            }
            if (Optional.IsDefined(ValueRatio))
            {
                writer.WritePropertyName("valueRatio"u8);
                writer.WriteObjectValue(ValueRatio, options);
            }
            if (Optional.IsDefined(ValueSampledData))
            {
                writer.WritePropertyName("valueSampledData"u8);
                writer.WriteObjectValue(ValueSampledData, options);
            }
            if (Optional.IsDefined(ValueTime))
            {
                writer.WritePropertyName("valueTime"u8);
                writer.WriteStringValue(ValueTime.Value, "T");
            }
            if (Optional.IsDefined(ValueDateTime))
            {
                writer.WritePropertyName("valueDateTime"u8);
                writer.WriteStringValue(ValueDateTime);
            }
            if (Optional.IsDefined(ValuePeriod))
            {
                writer.WritePropertyName("valuePeriod"u8);
                writer.WriteObjectValue(ValuePeriod, options);
            }
            if (Optional.IsDefined(DataAbsentReason))
            {
                writer.WritePropertyName("dataAbsentReason"u8);
                writer.WriteObjectValue(DataAbsentReason, options);
            }
            if (Optional.IsCollectionDefined(Interpretation))
            {
                writer.WritePropertyName("interpretation"u8);
                writer.WriteStartArray();
                foreach (var item in Interpretation)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Note))
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStartArray();
                foreach (var item in Note)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BodySite))
            {
                writer.WritePropertyName("bodySite"u8);
                writer.WriteObjectValue(BodySite, options);
            }
            if (Optional.IsDefined(Method))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteObjectValue(Method, options);
            }
            if (Optional.IsCollectionDefined(ReferenceRange))
            {
                writer.WritePropertyName("referenceRange"u8);
                writer.WriteStartArray();
                foreach (var item in ReferenceRange)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HasMember))
            {
                writer.WritePropertyName("hasMember"u8);
                writer.WriteStartArray();
                foreach (var item in HasMember)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DerivedFrom))
            {
                writer.WritePropertyName("derivedFrom"u8);
                writer.WriteStartArray();
                foreach (var item in DerivedFrom)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Component))
            {
                writer.WritePropertyName("component"u8);
                writer.WriteStartArray();
                foreach (var item in Component)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteObjectValue(Text, options);
            }
            if (Optional.IsCollectionDefined(Contained))
            {
                writer.WritePropertyName("contained"u8);
                writer.WriteStartArray();
                foreach (var item in Contained)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ModifierExtension))
            {
                writer.WritePropertyName("modifierExtension"u8);
                writer.WriteStartArray();
                foreach (var item in ModifierExtension)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Meta))
            {
                writer.WritePropertyName("meta"u8);
                writer.WriteObjectValue(Meta, options);
            }
            if (Optional.IsDefined(ImplicitRules))
            {
                writer.WritePropertyName("implicitRules"u8);
                writer.WriteStringValue(ImplicitRules);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        FhirR4Observation IJsonModel<FhirR4Observation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Observation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Observation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Observation(document.RootElement, options);
        }

        internal static FhirR4Observation DeserializeFhirR4Observation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FhirR4Identifier> identifier = default;
            ObservationStatusCodeType status = default;
            IReadOnlyList<FhirR4CodeableConcept> category = default;
            FhirR4CodeableConcept code = default;
            FhirR4Reference subject = default;
            FhirR4Reference encounter = default;
            string effectiveDateTime = default;
            FhirR4Period effectivePeriod = default;
            string effectiveInstant = default;
            string issued = default;
            FhirR4Quantity valueQuantity = default;
            FhirR4CodeableConcept valueCodeableConcept = default;
            string valueString = default;
            bool? valueBoolean = default;
            int? valueInteger = default;
            FhirR4Range valueRange = default;
            FhirR4Ratio valueRatio = default;
            FhirR4SampledData valueSampledData = default;
            TimeSpan? valueTime = default;
            string valueDateTime = default;
            FhirR4Period valuePeriod = default;
            FhirR4CodeableConcept dataAbsentReason = default;
            IReadOnlyList<FhirR4CodeableConcept> interpretation = default;
            IReadOnlyList<FhirR4Annotation> note = default;
            FhirR4CodeableConcept bodySite = default;
            FhirR4CodeableConcept method = default;
            IReadOnlyList<FhirR4ObservationReferenceRange> referenceRange = default;
            IReadOnlyList<FhirR4Reference> hasMember = default;
            IReadOnlyList<FhirR4Reference> derivedFrom = default;
            IReadOnlyList<FhirR4ObservationComponent> component = default;
            FhirR4Narrative text = default;
            IReadOnlyList<FhirR4Resource> contained = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IReadOnlyList<FhirR4Extension> modifierExtension = default;
            string resourceType = default;
            string id = default;
            FhirR4Meta meta = default;
            string implicitRules = default;
            string language = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Identifier> array = new List<FhirR4Identifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Identifier.DeserializeFhirR4Identifier(item, options));
                    }
                    identifier = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new ObservationStatusCodeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    category = array;
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subject = FhirR4Reference.DeserializeFhirR4Reference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encounter = FhirR4Reference.DeserializeFhirR4Reference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("effectiveDateTime"u8))
                {
                    effectiveDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectivePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectivePeriod = FhirR4Period.DeserializeFhirR4Period(property.Value, options);
                    continue;
                }
                if (property.NameEquals("effectiveInstant"u8))
                {
                    effectiveInstant = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issued"u8))
                {
                    issued = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueQuantity = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueCodeableConcept"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueCodeableConcept = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueString"u8))
                {
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueBoolean"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueBoolean = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueInteger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInteger = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("valueRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueRange = FhirR4Range.DeserializeFhirR4Range(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueRatio = FhirR4Ratio.DeserializeFhirR4Ratio(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueSampledData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSampledData = FhirR4SampledData.DeserializeFhirR4SampledData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valueDateTime"u8))
                {
                    valueDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valuePeriod = FhirR4Period.DeserializeFhirR4Period(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataAbsentReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAbsentReason = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("interpretation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4CodeableConcept> array = new List<FhirR4CodeableConcept>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(item, options));
                    }
                    interpretation = array;
                    continue;
                }
                if (property.NameEquals("note"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Annotation> array = new List<FhirR4Annotation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Annotation.DeserializeFhirR4Annotation(item, options));
                    }
                    note = array;
                    continue;
                }
                if (property.NameEquals("bodySite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bodySite = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("referenceRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4ObservationReferenceRange> array = new List<FhirR4ObservationReferenceRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4ObservationReferenceRange.DeserializeFhirR4ObservationReferenceRange(item, options));
                    }
                    referenceRange = array;
                    continue;
                }
                if (property.NameEquals("hasMember"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Reference> array = new List<FhirR4Reference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Reference.DeserializeFhirR4Reference(item, options));
                    }
                    hasMember = array;
                    continue;
                }
                if (property.NameEquals("derivedFrom"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Reference> array = new List<FhirR4Reference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Reference.DeserializeFhirR4Reference(item, options));
                    }
                    derivedFrom = array;
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4ObservationComponent> array = new List<FhirR4ObservationComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4ObservationComponent.DeserializeFhirR4ObservationComponent(item, options));
                    }
                    component = array;
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = FhirR4Narrative.DeserializeFhirR4Narrative(property.Value, options);
                    continue;
                }
                if (property.NameEquals("contained"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Resource> array = new List<FhirR4Resource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeFhirR4Resource(item, options));
                    }
                    contained = array;
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (property.NameEquals("modifierExtension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    modifierExtension = array;
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meta = FhirR4Meta.DeserializeFhirR4Meta(property.Value, options);
                    continue;
                }
                if (property.NameEquals("implicitRules"u8))
                {
                    implicitRules = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FhirR4Observation(
                resourceType,
                id,
                meta,
                implicitRules,
                language,
                additionalProperties,
                text,
                contained ?? new ChangeTrackingList<FhirR4Resource>(),
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                modifierExtension ?? new ChangeTrackingList<FhirR4Extension>(),
                identifier ?? new ChangeTrackingList<FhirR4Identifier>(),
                status,
                category ?? new ChangeTrackingList<FhirR4CodeableConcept>(),
                code,
                subject,
                encounter,
                effectiveDateTime,
                effectivePeriod,
                effectiveInstant,
                issued,
                valueQuantity,
                valueCodeableConcept,
                valueString,
                valueBoolean,
                valueInteger,
                valueRange,
                valueRatio,
                valueSampledData,
                valueTime,
                valueDateTime,
                valuePeriod,
                dataAbsentReason,
                interpretation ?? new ChangeTrackingList<FhirR4CodeableConcept>(),
                note ?? new ChangeTrackingList<FhirR4Annotation>(),
                bodySite,
                method,
                referenceRange ?? new ChangeTrackingList<FhirR4ObservationReferenceRange>(),
                hasMember ?? new ChangeTrackingList<FhirR4Reference>(),
                derivedFrom ?? new ChangeTrackingList<FhirR4Reference>(),
                component ?? new ChangeTrackingList<FhirR4ObservationComponent>());
        }

        BinaryData IPersistableModel<FhirR4Observation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Observation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Observation)} does not support writing '{options.Format}' format.");
            }
        }

        FhirR4Observation IPersistableModel<FhirR4Observation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Observation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4Observation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Observation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Observation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4Observation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4Observation(document.RootElement);
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
