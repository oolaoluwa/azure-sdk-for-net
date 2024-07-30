// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceRoutingType. </summary>
    public readonly partial struct ResourceRoutingType : IEquatable<ResourceRoutingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceRoutingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceRoutingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string ProxyOnlyValue = "ProxyOnly";
        private const string HostBasedValue = "HostBased";
        private const string ExtensionValue = "Extension";
        private const string TenantValue = "Tenant";
        private const string FanoutValue = "Fanout";
        private const string LocationBasedValue = "LocationBased";
        private const string FailoverValue = "Failover";
        private const string CascadeExtensionValue = "CascadeExtension";

        /// <summary> Default. </summary>
        public static ResourceRoutingType Default { get; } = new ResourceRoutingType(DefaultValue);
        /// <summary> ProxyOnly. </summary>
        public static ResourceRoutingType ProxyOnly { get; } = new ResourceRoutingType(ProxyOnlyValue);
        /// <summary> HostBased. </summary>
        public static ResourceRoutingType HostBased { get; } = new ResourceRoutingType(HostBasedValue);
        /// <summary> Extension. </summary>
        public static ResourceRoutingType Extension { get; } = new ResourceRoutingType(ExtensionValue);
        /// <summary> Tenant. </summary>
        public static ResourceRoutingType Tenant { get; } = new ResourceRoutingType(TenantValue);
        /// <summary> Fanout. </summary>
        public static ResourceRoutingType Fanout { get; } = new ResourceRoutingType(FanoutValue);
        /// <summary> LocationBased. </summary>
        public static ResourceRoutingType LocationBased { get; } = new ResourceRoutingType(LocationBasedValue);
        /// <summary> Failover. </summary>
        public static ResourceRoutingType Failover { get; } = new ResourceRoutingType(FailoverValue);
        /// <summary> CascadeExtension. </summary>
        public static ResourceRoutingType CascadeExtension { get; } = new ResourceRoutingType(CascadeExtensionValue);
        /// <summary> Determines if two <see cref="ResourceRoutingType"/> values are the same. </summary>
        public static bool operator ==(ResourceRoutingType left, ResourceRoutingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceRoutingType"/> values are not the same. </summary>
        public static bool operator !=(ResourceRoutingType left, ResourceRoutingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceRoutingType"/>. </summary>
        public static implicit operator ResourceRoutingType(string value) => new ResourceRoutingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceRoutingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceRoutingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
