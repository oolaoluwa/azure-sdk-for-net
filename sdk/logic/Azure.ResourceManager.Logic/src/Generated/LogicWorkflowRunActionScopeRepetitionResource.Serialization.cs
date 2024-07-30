// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Logic
{
    public partial class LogicWorkflowRunActionScopeRepetitionResource : IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>
    {
        void IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>)Data).Write(writer, options);

        LogicWorkflowRunActionRepetitionDefinitionData IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LogicWorkflowRunActionRepetitionDefinitionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LogicWorkflowRunActionRepetitionDefinitionData IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LogicWorkflowRunActionRepetitionDefinitionData>(data, options);

        string IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LogicWorkflowRunActionRepetitionDefinitionData>)Data).GetFormatFromOptions(options);
    }
}
