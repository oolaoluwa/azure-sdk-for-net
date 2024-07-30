// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> `GeoJSON` type. </summary>
    public readonly partial struct GeoJsonType : IEquatable<GeoJsonType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GeoJsonType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GeoJsonType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FeatureValue = "Feature";

        /// <summary> Feature. </summary>
        public static GeoJsonType Feature { get; } = new GeoJsonType(FeatureValue);
        /// <summary> Determines if two <see cref="GeoJsonType"/> values are the same. </summary>
        public static bool operator ==(GeoJsonType left, GeoJsonType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GeoJsonType"/> values are not the same. </summary>
        public static bool operator !=(GeoJsonType left, GeoJsonType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GeoJsonType"/>. </summary>
        public static implicit operator GeoJsonType(string value) => new GeoJsonType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeoJsonType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GeoJsonType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
