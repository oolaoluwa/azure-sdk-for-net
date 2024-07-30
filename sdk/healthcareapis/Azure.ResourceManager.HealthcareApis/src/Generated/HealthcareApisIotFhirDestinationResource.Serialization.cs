// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class HealthcareApisIotFhirDestinationResource : IJsonModel<HealthcareApisIotFhirDestinationData>
    {
        void IJsonModel<HealthcareApisIotFhirDestinationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HealthcareApisIotFhirDestinationData>)Data).Write(writer, options);

        HealthcareApisIotFhirDestinationData IJsonModel<HealthcareApisIotFhirDestinationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HealthcareApisIotFhirDestinationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HealthcareApisIotFhirDestinationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HealthcareApisIotFhirDestinationData IPersistableModel<HealthcareApisIotFhirDestinationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HealthcareApisIotFhirDestinationData>(data, options);

        string IPersistableModel<HealthcareApisIotFhirDestinationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HealthcareApisIotFhirDestinationData>)Data).GetFormatFromOptions(options);
    }
}
