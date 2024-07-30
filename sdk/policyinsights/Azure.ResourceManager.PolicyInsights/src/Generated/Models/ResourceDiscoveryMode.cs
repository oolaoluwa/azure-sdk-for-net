// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The way resources to remediate are discovered. Defaults to ExistingNonCompliant if not specified. </summary>
    public readonly partial struct ResourceDiscoveryMode : IEquatable<ResourceDiscoveryMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceDiscoveryMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceDiscoveryMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExistingNonCompliantValue = "ExistingNonCompliant";
        private const string ReEvaluateComplianceValue = "ReEvaluateCompliance";

        /// <summary> Remediate resources that are already known to be non-compliant. </summary>
        public static ResourceDiscoveryMode ExistingNonCompliant { get; } = new ResourceDiscoveryMode(ExistingNonCompliantValue);
        /// <summary> Re-evaluate the compliance state of resources and then remediate the resources found to be non-compliant. </summary>
        public static ResourceDiscoveryMode ReEvaluateCompliance { get; } = new ResourceDiscoveryMode(ReEvaluateComplianceValue);
        /// <summary> Determines if two <see cref="ResourceDiscoveryMode"/> values are the same. </summary>
        public static bool operator ==(ResourceDiscoveryMode left, ResourceDiscoveryMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceDiscoveryMode"/> values are not the same. </summary>
        public static bool operator !=(ResourceDiscoveryMode left, ResourceDiscoveryMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceDiscoveryMode"/>. </summary>
        public static implicit operator ResourceDiscoveryMode(string value) => new ResourceDiscoveryMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceDiscoveryMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceDiscoveryMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
