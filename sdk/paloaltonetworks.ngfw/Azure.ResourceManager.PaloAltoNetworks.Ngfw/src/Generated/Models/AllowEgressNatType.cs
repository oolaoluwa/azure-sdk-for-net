// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Egress NAT. </summary>
    public readonly partial struct AllowEgressNatType : IEquatable<AllowEgressNatType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AllowEgressNatType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AllowEgressNatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "DISABLED";
        private const string EnabledValue = "ENABLED";

        /// <summary> DISABLED. </summary>
        public static AllowEgressNatType Disabled { get; } = new AllowEgressNatType(DisabledValue);
        /// <summary> ENABLED. </summary>
        public static AllowEgressNatType Enabled { get; } = new AllowEgressNatType(EnabledValue);
        /// <summary> Determines if two <see cref="AllowEgressNatType"/> values are the same. </summary>
        public static bool operator ==(AllowEgressNatType left, AllowEgressNatType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AllowEgressNatType"/> values are not the same. </summary>
        public static bool operator !=(AllowEgressNatType left, AllowEgressNatType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AllowEgressNatType"/>. </summary>
        public static implicit operator AllowEgressNatType(string value) => new AllowEgressNatType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AllowEgressNatType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AllowEgressNatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
