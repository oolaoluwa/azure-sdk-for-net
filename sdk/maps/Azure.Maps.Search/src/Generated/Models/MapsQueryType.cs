// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> The type of query being returned: NEARBY or NON_NEAR. </summary>
    public readonly partial struct MapsQueryType : IEquatable<MapsQueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapsQueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapsQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NearbyValue = "NEARBY";
        private const string GlobalValue = "NON_NEAR";

        /// <summary> Search was performed around a certain latitude and longitude with a defined radius. </summary>
        public static MapsQueryType Nearby { get; } = new MapsQueryType(NearbyValue);
        /// <summary> Search was performed globally, without biasing to a certain latitude and longitude, and no defined radius. </summary>
        public static MapsQueryType Global { get; } = new MapsQueryType(GlobalValue);
        /// <summary> Determines if two <see cref="MapsQueryType"/> values are the same. </summary>
        public static bool operator ==(MapsQueryType left, MapsQueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapsQueryType"/> values are not the same. </summary>
        public static bool operator !=(MapsQueryType left, MapsQueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapsQueryType"/>. </summary>
        public static implicit operator MapsQueryType(string value) => new MapsQueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapsQueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapsQueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
