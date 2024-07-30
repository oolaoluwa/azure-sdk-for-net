// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Access mode types. </summary>
    public readonly partial struct MonitorPrivateLinkAccessMode : IEquatable<MonitorPrivateLinkAccessMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateLinkAccessMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorPrivateLinkAccessMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OpenValue = "Open";
        private const string PrivateOnlyValue = "PrivateOnly";

        /// <summary> Open. </summary>
        public static MonitorPrivateLinkAccessMode Open { get; } = new MonitorPrivateLinkAccessMode(OpenValue);
        /// <summary> PrivateOnly. </summary>
        public static MonitorPrivateLinkAccessMode PrivateOnly { get; } = new MonitorPrivateLinkAccessMode(PrivateOnlyValue);
        /// <summary> Determines if two <see cref="MonitorPrivateLinkAccessMode"/> values are the same. </summary>
        public static bool operator ==(MonitorPrivateLinkAccessMode left, MonitorPrivateLinkAccessMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorPrivateLinkAccessMode"/> values are not the same. </summary>
        public static bool operator !=(MonitorPrivateLinkAccessMode left, MonitorPrivateLinkAccessMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorPrivateLinkAccessMode"/>. </summary>
        public static implicit operator MonitorPrivateLinkAccessMode(string value) => new MonitorPrivateLinkAccessMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorPrivateLinkAccessMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorPrivateLinkAccessMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
