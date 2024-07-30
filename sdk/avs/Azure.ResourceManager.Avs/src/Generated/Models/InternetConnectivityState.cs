// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Connectivity to internet is enabled or disabled. </summary>
    public readonly partial struct InternetConnectivityState : IEquatable<InternetConnectivityState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternetConnectivityState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternetConnectivityState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static InternetConnectivityState Enabled { get; } = new InternetConnectivityState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static InternetConnectivityState Disabled { get; } = new InternetConnectivityState(DisabledValue);
        /// <summary> Determines if two <see cref="InternetConnectivityState"/> values are the same. </summary>
        public static bool operator ==(InternetConnectivityState left, InternetConnectivityState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternetConnectivityState"/> values are not the same. </summary>
        public static bool operator !=(InternetConnectivityState left, InternetConnectivityState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternetConnectivityState"/>. </summary>
        public static implicit operator InternetConnectivityState(string value) => new InternetConnectivityState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternetConnectivityState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternetConnectivityState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
