// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Message Media Content. </summary>
    public partial class AcsMessageMediaContent
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

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        internal AcsMessageMediaContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageMediaContent"/>. </summary>
        /// <param name="mimeType"> The MIME type of the file this media represents. </param>
        /// <param name="mediaId"> The media identifier. </param>
        /// <param name="fileName"> The filename of the underlying media file as specified when uploaded. </param>
        /// <param name="caption"> The caption for the media object, if supported and provided. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsMessageMediaContent(string mimeType, string mediaId, string fileName, string caption, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MimeType = mimeType;
            MediaId = mediaId;
            FileName = fileName;
            Caption = caption;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The MIME type of the file this media represents. </summary>
        public string MimeType { get; }
        /// <summary> The media identifier. </summary>
        public string MediaId { get; }
        /// <summary> The filename of the underlying media file as specified when uploaded. </summary>
        public string FileName { get; }
        /// <summary> The caption for the media object, if supported and provided. </summary>
        public string Caption { get; }
    }
}
