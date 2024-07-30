// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Text
{
    /// <summary> An object describing the detected language. </summary>
    public partial class DetectedLanguage
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

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="language"> A string representing the code of the detected language. </param>
        /// <param name="confidence">
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="language"/> is null. </exception>
        internal DetectedLanguage(string language, float confidence)
        {
            Argument.AssertNotNull(language, nameof(language));

            Language = language;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="language"> A string representing the code of the detected language. </param>
        /// <param name="confidence">
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedLanguage(string language, float confidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Language = language;
            Confidence = confidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/> for deserialization. </summary>
        internal DetectedLanguage()
        {
        }

        /// <summary> A string representing the code of the detected language. </summary>
        public string Language { get; }
        /// <summary>
        /// A float value indicating the confidence in the result.
        /// The score is between zero and one and a low score indicates a low confidence.
        /// </summary>
        public float Confidence { get; }
    }
}
