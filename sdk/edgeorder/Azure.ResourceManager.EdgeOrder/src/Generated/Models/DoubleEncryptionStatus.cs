// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Double encryption status as entered by the customer. It is compulsory to give this parameter if the 'Deny' or 'Disabled' policy is configured. </summary>
    public readonly partial struct DoubleEncryptionStatus : IEquatable<DoubleEncryptionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DoubleEncryptionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DoubleEncryptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Double encryption is disabled. </summary>
        public static DoubleEncryptionStatus Disabled { get; } = new DoubleEncryptionStatus(DisabledValue);
        /// <summary> Double encryption is enabled. </summary>
        public static DoubleEncryptionStatus Enabled { get; } = new DoubleEncryptionStatus(EnabledValue);
        /// <summary> Determines if two <see cref="DoubleEncryptionStatus"/> values are the same. </summary>
        public static bool operator ==(DoubleEncryptionStatus left, DoubleEncryptionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DoubleEncryptionStatus"/> values are not the same. </summary>
        public static bool operator !=(DoubleEncryptionStatus left, DoubleEncryptionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DoubleEncryptionStatus"/>. </summary>
        public static implicit operator DoubleEncryptionStatus(string value) => new DoubleEncryptionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DoubleEncryptionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DoubleEncryptionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
