// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Network security perimeter profile access rule. </summary>
    public partial class NetworkSecurityPerimeterProfileAccessRule
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfileAccessRule"/>. </summary>
        public NetworkSecurityPerimeterProfileAccessRule()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<WritableSubResource>();
            NetworkSecurityPerimeters = new ChangeTrackingList<NetworkSecurityPerimeterInfo>();
            FullyQualifiedDomainNames = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
            PhoneNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityPerimeterProfileAccessRule"/>. </summary>
        /// <param name="fullyQualifiedArmId"> Fully Qualified Arm id for network security perimeter profile access rule. </param>
        /// <param name="name"> Name for nsp access rule. </param>
        /// <param name="networkSecurityPerimeterProfileAccessRuleType"> nsp access rule type. </param>
        /// <param name="direction"> NSP access rule direction. </param>
        /// <param name="addressPrefixes"> Address prefixes. </param>
        /// <param name="subscriptions"> List of subscriptions. </param>
        /// <param name="networkSecurityPerimeters"> Network security perimeters. </param>
        /// <param name="fullyQualifiedDomainNames"> Fully qualified domain names. </param>
        /// <param name="emailAddresses"> List of email addresses. </param>
        /// <param name="phoneNumbers"> List of phone numbers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityPerimeterProfileAccessRule(string fullyQualifiedArmId, string name, string networkSecurityPerimeterProfileAccessRuleType, NetworkSecurityPerimeterProfileAccessRuleDirection? direction, IList<string> addressPrefixes, IList<WritableSubResource> subscriptions, IList<NetworkSecurityPerimeterInfo> networkSecurityPerimeters, IList<string> fullyQualifiedDomainNames, IList<string> emailAddresses, IList<string> phoneNumbers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FullyQualifiedArmId = fullyQualifiedArmId;
            Name = name;
            NetworkSecurityPerimeterProfileAccessRuleType = networkSecurityPerimeterProfileAccessRuleType;
            Direction = direction;
            AddressPrefixes = addressPrefixes;
            Subscriptions = subscriptions;
            NetworkSecurityPerimeters = networkSecurityPerimeters;
            FullyQualifiedDomainNames = fullyQualifiedDomainNames;
            EmailAddresses = emailAddresses;
            PhoneNumbers = phoneNumbers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully Qualified Arm id for network security perimeter profile access rule. </summary>
        public string FullyQualifiedArmId { get; set; }
        /// <summary> Name for nsp access rule. </summary>
        public string Name { get; set; }
        /// <summary> nsp access rule type. </summary>
        public string NetworkSecurityPerimeterProfileAccessRuleType { get; set; }
        /// <summary> NSP access rule direction. </summary>
        public NetworkSecurityPerimeterProfileAccessRuleDirection? Direction { get; set; }
        /// <summary> Address prefixes. </summary>
        public IList<string> AddressPrefixes { get; }
        /// <summary> List of subscriptions. </summary>
        public IList<WritableSubResource> Subscriptions { get; }
        /// <summary> Network security perimeters. </summary>
        public IList<NetworkSecurityPerimeterInfo> NetworkSecurityPerimeters { get; }
        /// <summary> Fully qualified domain names. </summary>
        public IList<string> FullyQualifiedDomainNames { get; }
        /// <summary> List of email addresses. </summary>
        public IList<string> EmailAddresses { get; }
        /// <summary> List of phone numbers. </summary>
        public IList<string> PhoneNumbers { get; }
    }
}
