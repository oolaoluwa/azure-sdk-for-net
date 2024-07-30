// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> The role scope. </summary>
    public readonly partial struct KeyVaultRoleScope : IEquatable<KeyVaultRoleScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultRoleScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GlobalValue = "/";
        private const string KeysValue = "/keys";

        /// <summary> Global scope. </summary>
        public static KeyVaultRoleScope Global { get; } = new KeyVaultRoleScope(GlobalValue);
        /// <summary> Keys scope. </summary>
        public static KeyVaultRoleScope Keys { get; } = new KeyVaultRoleScope(KeysValue);
        /// <summary> Determines if two <see cref="KeyVaultRoleScope"/> values are the same. </summary>
        public static bool operator ==(KeyVaultRoleScope left, KeyVaultRoleScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultRoleScope"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultRoleScope left, KeyVaultRoleScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultRoleScope"/>. </summary>
        public static implicit operator KeyVaultRoleScope(string value) => new KeyVaultRoleScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultRoleScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultRoleScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
