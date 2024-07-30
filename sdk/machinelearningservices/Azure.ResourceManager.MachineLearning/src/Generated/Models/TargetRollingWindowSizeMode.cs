// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Target rolling windows size mode. </summary>
    internal readonly partial struct TargetRollingWindowSizeMode : IEquatable<TargetRollingWindowSizeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetRollingWindowSizeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetRollingWindowSizeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "Auto";
        private const string CustomValue = "Custom";

        /// <summary> Determine rolling windows size automatically. </summary>
        public static TargetRollingWindowSizeMode Auto { get; } = new TargetRollingWindowSizeMode(AutoValue);
        /// <summary> Use the specified rolling window size. </summary>
        public static TargetRollingWindowSizeMode Custom { get; } = new TargetRollingWindowSizeMode(CustomValue);
        /// <summary> Determines if two <see cref="TargetRollingWindowSizeMode"/> values are the same. </summary>
        public static bool operator ==(TargetRollingWindowSizeMode left, TargetRollingWindowSizeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetRollingWindowSizeMode"/> values are not the same. </summary>
        public static bool operator !=(TargetRollingWindowSizeMode left, TargetRollingWindowSizeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetRollingWindowSizeMode"/>. </summary>
        public static implicit operator TargetRollingWindowSizeMode(string value) => new TargetRollingWindowSizeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetRollingWindowSizeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetRollingWindowSizeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
