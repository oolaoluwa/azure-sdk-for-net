// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDatabaseRestorePointResource : IJsonModel<SqlServerDatabaseRestorePointData>
    {
        void IJsonModel<SqlServerDatabaseRestorePointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDatabaseRestorePointData>)Data).Write(writer, options);

        SqlServerDatabaseRestorePointData IJsonModel<SqlServerDatabaseRestorePointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDatabaseRestorePointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerDatabaseRestorePointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SqlServerDatabaseRestorePointData IPersistableModel<SqlServerDatabaseRestorePointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerDatabaseRestorePointData>(data, options);

        string IPersistableModel<SqlServerDatabaseRestorePointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerDatabaseRestorePointData>)Data).GetFormatFromOptions(options);
    }
}
