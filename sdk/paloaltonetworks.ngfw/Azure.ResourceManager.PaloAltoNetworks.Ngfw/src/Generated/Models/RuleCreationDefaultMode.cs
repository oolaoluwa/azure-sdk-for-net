// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Type for Default Mode for rules creation. </summary>
    public readonly partial struct RuleCreationDefaultMode : IEquatable<RuleCreationDefaultMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RuleCreationDefaultMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RuleCreationDefaultMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPSValue = "IPS";
        private const string FirewallValue = "FIREWALL";
        private const string NoneValue = "NONE";

        /// <summary> IPS. </summary>
        public static RuleCreationDefaultMode IPS { get; } = new RuleCreationDefaultMode(IPSValue);
        /// <summary> FIREWALL. </summary>
        public static RuleCreationDefaultMode Firewall { get; } = new RuleCreationDefaultMode(FirewallValue);
        /// <summary> NONE. </summary>
        public static RuleCreationDefaultMode None { get; } = new RuleCreationDefaultMode(NoneValue);
        /// <summary> Determines if two <see cref="RuleCreationDefaultMode"/> values are the same. </summary>
        public static bool operator ==(RuleCreationDefaultMode left, RuleCreationDefaultMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RuleCreationDefaultMode"/> values are not the same. </summary>
        public static bool operator !=(RuleCreationDefaultMode left, RuleCreationDefaultMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RuleCreationDefaultMode"/>. </summary>
        public static implicit operator RuleCreationDefaultMode(string value) => new RuleCreationDefaultMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RuleCreationDefaultMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RuleCreationDefaultMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
