// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The EncryptionProtectorName. </summary>
    public readonly partial struct EncryptionProtectorName : IEquatable<EncryptionProtectorName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncryptionProtectorName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncryptionProtectorName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CurrentValue = "current";

        /// <summary> current. </summary>
        public static EncryptionProtectorName Current { get; } = new EncryptionProtectorName(CurrentValue);
        /// <summary> Determines if two <see cref="EncryptionProtectorName"/> values are the same. </summary>
        public static bool operator ==(EncryptionProtectorName left, EncryptionProtectorName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncryptionProtectorName"/> values are not the same. </summary>
        public static bool operator !=(EncryptionProtectorName left, EncryptionProtectorName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EncryptionProtectorName"/>. </summary>
        public static implicit operator EncryptionProtectorName(string value) => new EncryptionProtectorName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionProtectorName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncryptionProtectorName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
