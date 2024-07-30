// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> Dependency reference for a serverless runtime resource. </summary>
    public partial class ServerlessRuntimeDependency
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeDependency"/>. </summary>
        /// <param name="id"> Dependency ID. </param>
        /// <param name="appContextId"> Application context ID. </param>
        /// <param name="path"> Dependency path. </param>
        /// <param name="documentType"> document type. </param>
        /// <param name="description"> description of Dependency. </param>
        /// <param name="lastUpdatedTime"> Last Update Time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="appContextId"/>, <paramref name="path"/>, <paramref name="documentType"/>, <paramref name="description"/> or <paramref name="lastUpdatedTime"/> is null. </exception>
        internal ServerlessRuntimeDependency(string id, string appContextId, string path, string documentType, string description, string lastUpdatedTime)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(appContextId, nameof(appContextId));
            Argument.AssertNotNull(path, nameof(path));
            Argument.AssertNotNull(documentType, nameof(documentType));
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(lastUpdatedTime, nameof(lastUpdatedTime));

            Id = id;
            AppContextId = appContextId;
            Path = path;
            DocumentType = documentType;
            Description = description;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeDependency"/>. </summary>
        /// <param name="id"> Dependency ID. </param>
        /// <param name="appContextId"> Application context ID. </param>
        /// <param name="path"> Dependency path. </param>
        /// <param name="documentType"> document type. </param>
        /// <param name="description"> description of Dependency. </param>
        /// <param name="lastUpdatedTime"> Last Update Time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerlessRuntimeDependency(string id, string appContextId, string path, string documentType, string description, string lastUpdatedTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            AppContextId = appContextId;
            Path = path;
            DocumentType = documentType;
            Description = description;
            LastUpdatedTime = lastUpdatedTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeDependency"/> for deserialization. </summary>
        internal ServerlessRuntimeDependency()
        {
        }

        /// <summary> Dependency ID. </summary>
        public string Id { get; }
        /// <summary> Application context ID. </summary>
        public string AppContextId { get; }
        /// <summary> Dependency path. </summary>
        public string Path { get; }
        /// <summary> document type. </summary>
        public string DocumentType { get; }
        /// <summary> description of Dependency. </summary>
        public string Description { get; }
        /// <summary> Last Update Time. </summary>
        public string LastUpdatedTime { get; }
    }
}
