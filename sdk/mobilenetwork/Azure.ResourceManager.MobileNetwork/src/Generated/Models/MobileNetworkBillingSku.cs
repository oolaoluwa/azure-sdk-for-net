// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The SKU of the packet core control plane resource. The SKU list may change over time when a new SKU gets added or an exiting SKU gets removed. </summary>
    public readonly partial struct MobileNetworkBillingSku : IEquatable<MobileNetworkBillingSku>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkBillingSku"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkBillingSku(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string G0Value = "G0";
        private const string G1Value = "G1";
        private const string G2Value = "G2";
        private const string G5Value = "G5";
        private const string G10Value = "G10";

        /// <summary> 100 Mbps, 20 active SIMs plan, 2 RANs. </summary>
        public static MobileNetworkBillingSku G0 { get; } = new MobileNetworkBillingSku(G0Value);
        /// <summary> 1 Gbps, 100 active SIMs plan, 5 RANs. </summary>
        public static MobileNetworkBillingSku G1 { get; } = new MobileNetworkBillingSku(G1Value);
        /// <summary> 2 Gbps, 200 active SIMs plan, 10 RANs. </summary>
        public static MobileNetworkBillingSku G2 { get; } = new MobileNetworkBillingSku(G2Value);
        /// <summary> 5 Gbps, 500 active SIMs plan. </summary>
        public static MobileNetworkBillingSku G5 { get; } = new MobileNetworkBillingSku(G5Value);
        /// <summary> 10 Gbps, 1000 active SIMs plan. </summary>
        public static MobileNetworkBillingSku G10 { get; } = new MobileNetworkBillingSku(G10Value);
        /// <summary> Determines if two <see cref="MobileNetworkBillingSku"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkBillingSku left, MobileNetworkBillingSku right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkBillingSku"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkBillingSku left, MobileNetworkBillingSku right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkBillingSku"/>. </summary>
        public static implicit operator MobileNetworkBillingSku(string value) => new MobileNetworkBillingSku(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkBillingSku other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkBillingSku other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
