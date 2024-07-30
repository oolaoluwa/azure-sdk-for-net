// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The default action of allow or deny when no other rules match. </summary>
    public readonly partial struct ContainerRegistryNetworkRuleDefaultAction : IEquatable<ContainerRegistryNetworkRuleDefaultAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryNetworkRuleDefaultAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryNetworkRuleDefaultAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static ContainerRegistryNetworkRuleDefaultAction Allow { get; } = new ContainerRegistryNetworkRuleDefaultAction(AllowValue);
        /// <summary> Deny. </summary>
        public static ContainerRegistryNetworkRuleDefaultAction Deny { get; } = new ContainerRegistryNetworkRuleDefaultAction(DenyValue);
        /// <summary> Determines if two <see cref="ContainerRegistryNetworkRuleDefaultAction"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryNetworkRuleDefaultAction left, ContainerRegistryNetworkRuleDefaultAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryNetworkRuleDefaultAction"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryNetworkRuleDefaultAction left, ContainerRegistryNetworkRuleDefaultAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryNetworkRuleDefaultAction"/>. </summary>
        public static implicit operator ContainerRegistryNetworkRuleDefaultAction(string value) => new ContainerRegistryNetworkRuleDefaultAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryNetworkRuleDefaultAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryNetworkRuleDefaultAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
