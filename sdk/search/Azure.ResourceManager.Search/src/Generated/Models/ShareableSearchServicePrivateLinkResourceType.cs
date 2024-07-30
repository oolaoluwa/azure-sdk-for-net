// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes an resource type that has been onboarded to private link service, supported by Azure AI Search. </summary>
    public partial class ShareableSearchServicePrivateLinkResourceType
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

        /// <summary> Initializes a new instance of <see cref="ShareableSearchServicePrivateLinkResourceType"/>. </summary>
        internal ShareableSearchServicePrivateLinkResourceType()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShareableSearchServicePrivateLinkResourceType"/>. </summary>
        /// <param name="name"> The name of the resource type that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <param name="properties"> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure AI Search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShareableSearchServicePrivateLinkResourceType(string name, ShareableSearchServicePrivateLinkResourceProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the resource type that has been onboarded to private link service, supported by Azure AI Search. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure AI Search. </summary>
        [WirePath("properties")]
        public ShareableSearchServicePrivateLinkResourceProperties Properties { get; }
    }
}
