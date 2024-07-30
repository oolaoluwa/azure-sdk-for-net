// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Scale type. </summary>
    public readonly partial struct KustoScaleType : IEquatable<KustoScaleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoScaleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoScaleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutomaticValue = "automatic";
        private const string ManualValue = "manual";
        private const string NoneValue = "none";

        /// <summary> automatic. </summary>
        public static KustoScaleType Automatic { get; } = new KustoScaleType(AutomaticValue);
        /// <summary> manual. </summary>
        public static KustoScaleType Manual { get; } = new KustoScaleType(ManualValue);
        /// <summary> none. </summary>
        public static KustoScaleType None { get; } = new KustoScaleType(NoneValue);
        /// <summary> Determines if two <see cref="KustoScaleType"/> values are the same. </summary>
        public static bool operator ==(KustoScaleType left, KustoScaleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoScaleType"/> values are not the same. </summary>
        public static bool operator !=(KustoScaleType left, KustoScaleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoScaleType"/>. </summary>
        public static implicit operator KustoScaleType(string value) => new KustoScaleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoScaleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoScaleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
