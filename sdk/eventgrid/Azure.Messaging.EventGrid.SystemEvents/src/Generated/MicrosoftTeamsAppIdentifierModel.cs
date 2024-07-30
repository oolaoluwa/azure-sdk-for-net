// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> A Microsoft Teams application. </summary>
    public partial class MicrosoftTeamsAppIdentifierModel
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

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsAppIdentifierModel"/>. </summary>
        /// <param name="appId"> The Id of the Microsoft Teams application. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams application belongs to. By default 'public' if missing. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appId"/> is null. </exception>
        internal MicrosoftTeamsAppIdentifierModel(string appId, CommunicationCloudEnvironmentModel cloud)
        {
            Argument.AssertNotNull(appId, nameof(appId));

            AppId = appId;
            Cloud = cloud;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsAppIdentifierModel"/>. </summary>
        /// <param name="appId"> The Id of the Microsoft Teams application. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams application belongs to. By default 'public' if missing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MicrosoftTeamsAppIdentifierModel(string appId, CommunicationCloudEnvironmentModel cloud, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppId = appId;
            Cloud = cloud;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsAppIdentifierModel"/> for deserialization. </summary>
        internal MicrosoftTeamsAppIdentifierModel()
        {
        }

        /// <summary> The Id of the Microsoft Teams application. </summary>
        public string AppId { get; }
        /// <summary> The cloud that the Microsoft Teams application belongs to. By default 'public' if missing. </summary>
        public CommunicationCloudEnvironmentModel Cloud { get; }
    }
}
