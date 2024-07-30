// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Unknown version of ApplicationGroupPolicy. </summary>
    internal partial class UnknownApplicationGroupPolicy : EventHubsApplicationGroupPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownApplicationGroupPolicy"/>. </summary>
        /// <param name="name"> The Name of this policy. </param>
        /// <param name="applicationGroupPolicyType"> Application Group Policy types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownApplicationGroupPolicy(string name, ApplicationGroupPolicyType applicationGroupPolicyType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, applicationGroupPolicyType, serializedAdditionalRawData)
        {
            ApplicationGroupPolicyType = applicationGroupPolicyType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownApplicationGroupPolicy"/> for deserialization. </summary>
        internal UnknownApplicationGroupPolicy()
        {
        }
    }
}
