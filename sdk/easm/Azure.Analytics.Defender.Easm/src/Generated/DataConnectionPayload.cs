// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary>
    /// The DataConnectionPayload.
    /// Please note <see cref="DataConnectionPayload"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureDataExplorerDataConnectionPayload"/> and <see cref="LogAnalyticsDataConnectionPayload"/>.
    /// </summary>
    public abstract partial class DataConnectionPayload
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataConnectionPayload"/>. </summary>
        protected DataConnectionPayload()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataConnectionPayload"/>. </summary>
        /// <param name="kind"> Discriminator property for DataConnectionPayload. </param>
        /// <param name="name"> The name of data connection. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. (1-7 for weekly, 1-31 for monthly). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataConnectionPayload(string kind, string name, DataConnectionContent? content, DataConnectionFrequency? frequency, int? frequencyOffset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Name = name;
            Content = content;
            Frequency = frequency;
            FrequencyOffset = frequencyOffset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Discriminator property for DataConnectionPayload. </summary>
        internal string Kind { get; set; }
        /// <summary> The name of data connection. </summary>
        public string Name { get; set; }
        /// <summary> The type of data the data connection will transfer. </summary>
        public DataConnectionContent? Content { get; set; }
        /// <summary> The rate at which the data connection will receive updates. </summary>
        public DataConnectionFrequency? Frequency { get; set; }
        /// <summary> The day to update the data connection on. (1-7 for weekly, 1-31 for monthly). </summary>
        public int? FrequencyOffset { get; set; }
    }
}
