// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> Type of the accessory. </summary>
    public readonly partial struct AccessoryType : IEquatable<AccessoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AccessoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AccessoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HeadwearValue = "headwear";
        private const string GlassesValue = "glasses";
        private const string MaskValue = "mask";

        /// <summary> Head wear. </summary>
        public static AccessoryType Headwear { get; } = new AccessoryType(HeadwearValue);
        /// <summary> Glasses. </summary>
        public static AccessoryType Glasses { get; } = new AccessoryType(GlassesValue);
        /// <summary> Mask. </summary>
        public static AccessoryType Mask { get; } = new AccessoryType(MaskValue);
        /// <summary> Determines if two <see cref="AccessoryType"/> values are the same. </summary>
        public static bool operator ==(AccessoryType left, AccessoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AccessoryType"/> values are not the same. </summary>
        public static bool operator !=(AccessoryType left, AccessoryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AccessoryType"/>. </summary>
        public static implicit operator AccessoryType(string value) => new AccessoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AccessoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AccessoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
