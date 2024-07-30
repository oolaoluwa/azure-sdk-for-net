// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Service data flow direction. </summary>
    public readonly partial struct MobileNetworkSdfDirectionS : IEquatable<MobileNetworkSdfDirectionS>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSdfDirectionS"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkSdfDirectionS(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UplinkValue = "Uplink";
        private const string DownlinkValue = "Downlink";
        private const string BidirectionalValue = "Bidirectional";

        /// <summary> Traffic flowing from the UE to the data network. </summary>
        public static MobileNetworkSdfDirectionS Uplink { get; } = new MobileNetworkSdfDirectionS(UplinkValue);
        /// <summary> Traffic flowing from the data network to the UE. </summary>
        public static MobileNetworkSdfDirectionS Downlink { get; } = new MobileNetworkSdfDirectionS(DownlinkValue);
        /// <summary> Traffic flowing both to and from the UE. </summary>
        public static MobileNetworkSdfDirectionS Bidirectional { get; } = new MobileNetworkSdfDirectionS(BidirectionalValue);
        /// <summary> Determines if two <see cref="MobileNetworkSdfDirectionS"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkSdfDirectionS left, MobileNetworkSdfDirectionS right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkSdfDirectionS"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkSdfDirectionS left, MobileNetworkSdfDirectionS right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkSdfDirectionS"/>. </summary>
        public static implicit operator MobileNetworkSdfDirectionS(string value) => new MobileNetworkSdfDirectionS(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkSdfDirectionS other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkSdfDirectionS other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
