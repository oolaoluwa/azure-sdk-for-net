// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The type of pod event. </summary>
    public readonly partial struct PodEventType : IEquatable<PodEventType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PodEventType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PodEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "Normal";
        private const string WarningValue = "Warning";

        /// <summary> Normal. </summary>
        public static PodEventType Normal { get; } = new PodEventType(NormalValue);
        /// <summary> Warning. </summary>
        public static PodEventType Warning { get; } = new PodEventType(WarningValue);
        /// <summary> Determines if two <see cref="PodEventType"/> values are the same. </summary>
        public static bool operator ==(PodEventType left, PodEventType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PodEventType"/> values are not the same. </summary>
        public static bool operator !=(PodEventType left, PodEventType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PodEventType"/>. </summary>
        public static implicit operator PodEventType(string value) => new PodEventType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PodEventType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PodEventType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
