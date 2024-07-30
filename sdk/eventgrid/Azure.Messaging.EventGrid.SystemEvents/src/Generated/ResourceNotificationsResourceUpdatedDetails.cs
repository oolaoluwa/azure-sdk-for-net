// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary>
    /// Describes the schema of the properties under resource info which are common
    /// across all ARN system topic events
    /// </summary>
    public partial class ResourceNotificationsResourceUpdatedDetails
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

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceUpdatedDetails"/>. </summary>
        /// <param name="tags"> the tags on the resource for which the event is being emitted. </param>
        /// <param name="properties"> properties in the payload of the resource for which the event is being emitted. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> or <paramref name="properties"/> is null. </exception>
        internal ResourceNotificationsResourceUpdatedDetails(IReadOnlyDictionary<string, string> tags, IReadOnlyDictionary<string, BinaryData> properties)
        {
            Argument.AssertNotNull(tags, nameof(tags));
            Argument.AssertNotNull(properties, nameof(properties));

            Tags = tags;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceUpdatedDetails"/>. </summary>
        /// <param name="id"> id of the resource for which the event is being emitted. </param>
        /// <param name="name"> name of the resource for which the event is being emitted. </param>
        /// <param name="type"> the type of the resource for which the event is being emitted. </param>
        /// <param name="location"> the location of the resource for which the event is being emitted. </param>
        /// <param name="tags"> the tags on the resource for which the event is being emitted. </param>
        /// <param name="properties"> properties in the payload of the resource for which the event is being emitted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceNotificationsResourceUpdatedDetails(string id, string name, string type, string location, IReadOnlyDictionary<string, string> tags, IReadOnlyDictionary<string, BinaryData> properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceUpdatedDetails"/> for deserialization. </summary>
        internal ResourceNotificationsResourceUpdatedDetails()
        {
        }

        /// <summary> id of the resource for which the event is being emitted. </summary>
        public string Id { get; }
        /// <summary> name of the resource for which the event is being emitted. </summary>
        public string Name { get; }
        /// <summary> the type of the resource for which the event is being emitted. </summary>
        public string Type { get; }
        /// <summary> the location of the resource for which the event is being emitted. </summary>
        public string Location { get; }
        /// <summary> the tags on the resource for which the event is being emitted. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary>
        /// properties in the payload of the resource for which the event is being emitted
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
        public IReadOnlyDictionary<string, BinaryData> Properties { get; }
    }
}
