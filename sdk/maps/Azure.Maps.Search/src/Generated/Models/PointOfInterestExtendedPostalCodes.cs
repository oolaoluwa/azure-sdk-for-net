// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search
{
    /// <summary> The PointOfInterestExtendedPostalCodes. </summary>
    public readonly partial struct PointOfInterestExtendedPostalCodes : IEquatable<PointOfInterestExtendedPostalCodes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PointOfInterestExtendedPostalCodes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PointOfInterestExtendedPostalCodes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PointOfInterestValue = "POI";
        private const string NoneValue = "None";
        /// <summary> None. </summary>
        public static PointOfInterestExtendedPostalCodes None { get; } = new PointOfInterestExtendedPostalCodes(NoneValue);
        /// <summary> Determines if two <see cref="PointOfInterestExtendedPostalCodes"/> values are the same. </summary>
        public static bool operator ==(PointOfInterestExtendedPostalCodes left, PointOfInterestExtendedPostalCodes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PointOfInterestExtendedPostalCodes"/> values are not the same. </summary>
        public static bool operator !=(PointOfInterestExtendedPostalCodes left, PointOfInterestExtendedPostalCodes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PointOfInterestExtendedPostalCodes"/>. </summary>
        public static implicit operator PointOfInterestExtendedPostalCodes(string value) => new PointOfInterestExtendedPostalCodes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PointOfInterestExtendedPostalCodes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PointOfInterestExtendedPostalCodes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
