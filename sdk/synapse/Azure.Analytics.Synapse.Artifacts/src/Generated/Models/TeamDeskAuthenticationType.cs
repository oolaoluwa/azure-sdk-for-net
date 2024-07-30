// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication type to use. </summary>
    public readonly partial struct TeamDeskAuthenticationType : IEquatable<TeamDeskAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TeamDeskAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TeamDeskAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string TokenValue = "Token";

        /// <summary> Basic. </summary>
        public static TeamDeskAuthenticationType Basic { get; } = new TeamDeskAuthenticationType(BasicValue);
        /// <summary> Token. </summary>
        public static TeamDeskAuthenticationType Token { get; } = new TeamDeskAuthenticationType(TokenValue);
        /// <summary> Determines if two <see cref="TeamDeskAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(TeamDeskAuthenticationType left, TeamDeskAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TeamDeskAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(TeamDeskAuthenticationType left, TeamDeskAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TeamDeskAuthenticationType"/>. </summary>
        public static implicit operator TeamDeskAuthenticationType(string value) => new TeamDeskAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TeamDeskAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TeamDeskAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
