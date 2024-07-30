// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The TaskSlot counts for a Job. </summary>
    public partial class BatchTaskSlotCounts
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

        /// <summary> Initializes a new instance of <see cref="BatchTaskSlotCounts"/>. </summary>
        /// <param name="active"> The number of TaskSlots for active Tasks. </param>
        /// <param name="running"> The number of TaskSlots for running Tasks. </param>
        /// <param name="completed"> The number of TaskSlots for completed Tasks. </param>
        /// <param name="succeeded"> The number of TaskSlots for succeeded Tasks. </param>
        /// <param name="failed"> The number of TaskSlots for failed Tasks. </param>
        internal BatchTaskSlotCounts(int active, int running, int completed, int succeeded, int failed)
        {
            Active = active;
            Running = running;
            Completed = completed;
            Succeeded = succeeded;
            Failed = failed;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskSlotCounts"/>. </summary>
        /// <param name="active"> The number of TaskSlots for active Tasks. </param>
        /// <param name="running"> The number of TaskSlots for running Tasks. </param>
        /// <param name="completed"> The number of TaskSlots for completed Tasks. </param>
        /// <param name="succeeded"> The number of TaskSlots for succeeded Tasks. </param>
        /// <param name="failed"> The number of TaskSlots for failed Tasks. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchTaskSlotCounts(int active, int running, int completed, int succeeded, int failed, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Active = active;
            Running = running;
            Completed = completed;
            Succeeded = succeeded;
            Failed = failed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskSlotCounts"/> for deserialization. </summary>
        internal BatchTaskSlotCounts()
        {
        }

        /// <summary> The number of TaskSlots for active Tasks. </summary>
        public int Active { get; }
        /// <summary> The number of TaskSlots for running Tasks. </summary>
        public int Running { get; }
        /// <summary> The number of TaskSlots for completed Tasks. </summary>
        public int Completed { get; }
        /// <summary> The number of TaskSlots for succeeded Tasks. </summary>
        public int Succeeded { get; }
        /// <summary> The number of TaskSlots for failed Tasks. </summary>
        public int Failed { get; }
    }
}
