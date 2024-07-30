// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> The response of the List Namespace operation. </summary>
    internal partial class NotificationHubNamespaceListResult
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceListResult"/>. </summary>
        internal NotificationHubNamespaceListResult()
        {
            Value = new ChangeTrackingList<NotificationHubNamespaceData>();
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubNamespaceListResult"/>. </summary>
        /// <param name="value"> Gets or sets result of the List AuthorizationRules operation. </param>
        /// <param name="nextLink"> Gets or sets link to the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubNamespaceListResult(IReadOnlyList<NotificationHubNamespaceData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets result of the List AuthorizationRules operation. </summary>
        public IReadOnlyList<NotificationHubNamespaceData> Value { get; }
        /// <summary> Gets or sets link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
