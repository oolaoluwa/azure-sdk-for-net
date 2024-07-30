// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Type of Actions. </summary>
    public readonly partial struct WebApplicationFirewallAction : IEquatable<WebApplicationFirewallAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationFirewallAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string BlockValue = "Block";
        private const string LogValue = "Log";
        private const string JSChallengeValue = "JSChallenge";

        /// <summary> Allow. </summary>
        public static WebApplicationFirewallAction Allow { get; } = new WebApplicationFirewallAction(AllowValue);
        /// <summary> Block. </summary>
        public static WebApplicationFirewallAction Block { get; } = new WebApplicationFirewallAction(BlockValue);
        /// <summary> Log. </summary>
        public static WebApplicationFirewallAction Log { get; } = new WebApplicationFirewallAction(LogValue);
        /// <summary> JSChallenge. </summary>
        public static WebApplicationFirewallAction JSChallenge { get; } = new WebApplicationFirewallAction(JSChallengeValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallAction"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallAction left, WebApplicationFirewallAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallAction"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallAction left, WebApplicationFirewallAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebApplicationFirewallAction"/>. </summary>
        public static implicit operator WebApplicationFirewallAction(string value) => new WebApplicationFirewallAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
