// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The ClientAuthenticationMethod. </summary>
    public readonly partial struct ClientAuthenticationMethod : IEquatable<ClientAuthenticationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClientAuthenticationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClientAuthenticationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string BodyValue = "Body";

        /// <summary> Basic Client Authentication method. </summary>
        public static ClientAuthenticationMethod Basic { get; } = new ClientAuthenticationMethod(BasicValue);
        /// <summary> Body based Authentication method. </summary>
        public static ClientAuthenticationMethod Body { get; } = new ClientAuthenticationMethod(BodyValue);
        /// <summary> Determines if two <see cref="ClientAuthenticationMethod"/> values are the same. </summary>
        public static bool operator ==(ClientAuthenticationMethod left, ClientAuthenticationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClientAuthenticationMethod"/> values are not the same. </summary>
        public static bool operator !=(ClientAuthenticationMethod left, ClientAuthenticationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClientAuthenticationMethod"/>. </summary>
        public static implicit operator ClientAuthenticationMethod(string value) => new ClientAuthenticationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClientAuthenticationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClientAuthenticationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
