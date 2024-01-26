// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Input to get capabilities information for Microsoft.RecoveryServices. </summary>
    public partial class ResourceCapabilities : ResourceCapabilitiesBase
    {
        /// <summary> Initializes a new instance of <see cref="ResourceCapabilities"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        public ResourceCapabilities(ResourceType resourceCapabilitiesBaseType) : base(resourceCapabilitiesBaseType)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilities"/>. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Capabilities information. </param>
        internal ResourceCapabilities(ResourceType resourceCapabilitiesBaseType, IDictionary<string, BinaryData> serializedAdditionalRawData, CapabilitiesProperties properties) : base(resourceCapabilitiesBaseType, serializedAdditionalRawData)
        {
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceCapabilities"/> for deserialization. </summary>
        internal ResourceCapabilities()
        {
        }

        /// <summary> Capabilities information. </summary>
        internal CapabilitiesProperties Properties { get; set; }
        /// <summary> Gets the capabilities dns zones. </summary>
        public IList<DnsZone> CapabilitiesDnsZones
        {
            get
            {
                if (Properties is null)
                    Properties = new CapabilitiesProperties();
                return Properties.DnsZones;
            }
        }
    }
}
