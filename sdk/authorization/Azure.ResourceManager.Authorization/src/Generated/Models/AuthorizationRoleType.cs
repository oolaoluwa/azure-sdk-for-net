// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The role type. </summary>
    public readonly partial struct AuthorizationRoleType : IEquatable<AuthorizationRoleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AuthorizationRoleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AuthorizationRoleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BuiltInRoleValue = "BuiltInRole";
        private const string CustomRoleValue = "CustomRole";

        /// <summary> BuiltInRole. </summary>
        public static AuthorizationRoleType BuiltInRole { get; } = new AuthorizationRoleType(BuiltInRoleValue);
        /// <summary> CustomRole. </summary>
        public static AuthorizationRoleType CustomRole { get; } = new AuthorizationRoleType(CustomRoleValue);
        /// <summary> Determines if two <see cref="AuthorizationRoleType"/> values are the same. </summary>
        public static bool operator ==(AuthorizationRoleType left, AuthorizationRoleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AuthorizationRoleType"/> values are not the same. </summary>
        public static bool operator !=(AuthorizationRoleType left, AuthorizationRoleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AuthorizationRoleType"/>. </summary>
        public static implicit operator AuthorizationRoleType(string value) => new AuthorizationRoleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AuthorizationRoleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AuthorizationRoleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
