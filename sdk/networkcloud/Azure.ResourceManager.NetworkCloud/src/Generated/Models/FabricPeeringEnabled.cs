// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The indicator to specify if the load balancer peers with the network fabric. </summary>
    public readonly partial struct FabricPeeringEnabled : IEquatable<FabricPeeringEnabled>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FabricPeeringEnabled"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FabricPeeringEnabled(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static FabricPeeringEnabled True { get; } = new FabricPeeringEnabled(TrueValue);
        /// <summary> False. </summary>
        public static FabricPeeringEnabled False { get; } = new FabricPeeringEnabled(FalseValue);
        /// <summary> Determines if two <see cref="FabricPeeringEnabled"/> values are the same. </summary>
        public static bool operator ==(FabricPeeringEnabled left, FabricPeeringEnabled right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FabricPeeringEnabled"/> values are not the same. </summary>
        public static bool operator !=(FabricPeeringEnabled left, FabricPeeringEnabled right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FabricPeeringEnabled"/>. </summary>
        public static implicit operator FabricPeeringEnabled(string value) => new FabricPeeringEnabled(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FabricPeeringEnabled other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FabricPeeringEnabled other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
