// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The prefix learned type. </summary>
    public readonly partial struct PeeringLearnedType : IEquatable<PeeringLearnedType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PeeringLearnedType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PeeringLearnedType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ViaServiceProviderValue = "ViaServiceProvider";
        private const string ViaSessionValue = "ViaSession";

        /// <summary> None. </summary>
        public static PeeringLearnedType None { get; } = new PeeringLearnedType(NoneValue);
        /// <summary> ViaServiceProvider. </summary>
        public static PeeringLearnedType ViaServiceProvider { get; } = new PeeringLearnedType(ViaServiceProviderValue);
        /// <summary> ViaSession. </summary>
        public static PeeringLearnedType ViaSession { get; } = new PeeringLearnedType(ViaSessionValue);
        /// <summary> Determines if two <see cref="PeeringLearnedType"/> values are the same. </summary>
        public static bool operator ==(PeeringLearnedType left, PeeringLearnedType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PeeringLearnedType"/> values are not the same. </summary>
        public static bool operator !=(PeeringLearnedType left, PeeringLearnedType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PeeringLearnedType"/>. </summary>
        public static implicit operator PeeringLearnedType(string value) => new PeeringLearnedType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PeeringLearnedType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PeeringLearnedType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
