// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Solutions Diagnostic. </summary>
    public partial class SolutionsDiagnostic
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

        /// <summary> Initializes a new instance of <see cref="SolutionsDiagnostic"/>. </summary>
        internal SolutionsDiagnostic()
        {
            RequiredParameters = new ChangeTrackingList<string>();
            Insights = new ChangeTrackingList<SelfHelpDiagnosticInsight>();
        }

        /// <summary> Initializes a new instance of <see cref="SolutionsDiagnostic"/>. </summary>
        /// <param name="solutionId"> Solution Id to identify single Solutions Diagnostic. </param>
        /// <param name="status"> Denotes the status of the diagnostic resource. </param>
        /// <param name="statusDetails"> Details of the status. </param>
        /// <param name="replacementKey"> Place holder used in HTML Content replace control with the content. </param>
        /// <param name="estimatedCompletionTime"> Diagnostics estimated completion time in minutes. </param>
        /// <param name="requiredParameters"> Required parameters of this item. </param>
        /// <param name="insights"> Diagnostic insights. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SolutionsDiagnostic(string solutionId, SelfHelpDiagnosticStatus? status, string statusDetails, string replacementKey, string estimatedCompletionTime, IReadOnlyList<string> requiredParameters, IReadOnlyList<SelfHelpDiagnosticInsight> insights, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SolutionId = solutionId;
            Status = status;
            StatusDetails = statusDetails;
            ReplacementKey = replacementKey;
            EstimatedCompletionTime = estimatedCompletionTime;
            RequiredParameters = requiredParameters;
            Insights = insights;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Solution Id to identify single Solutions Diagnostic. </summary>
        public string SolutionId { get; }
        /// <summary> Denotes the status of the diagnostic resource. </summary>
        public SelfHelpDiagnosticStatus? Status { get; }
        /// <summary> Details of the status. </summary>
        public string StatusDetails { get; }
        /// <summary> Place holder used in HTML Content replace control with the content. </summary>
        public string ReplacementKey { get; }
        /// <summary> Diagnostics estimated completion time in minutes. </summary>
        public string EstimatedCompletionTime { get; }
        /// <summary> Required parameters of this item. </summary>
        public IReadOnlyList<string> RequiredParameters { get; }
        /// <summary> Diagnostic insights. </summary>
        public IReadOnlyList<SelfHelpDiagnosticInsight> Insights { get; }
    }
}
