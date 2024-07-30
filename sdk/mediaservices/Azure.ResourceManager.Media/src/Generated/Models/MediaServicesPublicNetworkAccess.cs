// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Whether or not public network access is allowed for resources under the Media Services account. </summary>
    public readonly partial struct MediaServicesPublicNetworkAccess : IEquatable<MediaServicesPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaServicesPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaServicesPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Public network access is enabled. </summary>
        public static MediaServicesPublicNetworkAccess Enabled { get; } = new MediaServicesPublicNetworkAccess(EnabledValue);
        /// <summary> Public network access is disabled. </summary>
        public static MediaServicesPublicNetworkAccess Disabled { get; } = new MediaServicesPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="MediaServicesPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(MediaServicesPublicNetworkAccess left, MediaServicesPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaServicesPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(MediaServicesPublicNetworkAccess left, MediaServicesPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MediaServicesPublicNetworkAccess"/>. </summary>
        public static implicit operator MediaServicesPublicNetworkAccess(string value) => new MediaServicesPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaServicesPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaServicesPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
