// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the edition of the license. The values are either Standard or Datacenter. </summary>
    public readonly partial struct HybridComputeLicenseEdition : IEquatable<HybridComputeLicenseEdition>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeLicenseEdition"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeLicenseEdition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string DataCenterValue = "Datacenter";

        /// <summary> Standard. </summary>
        public static HybridComputeLicenseEdition Standard { get; } = new HybridComputeLicenseEdition(StandardValue);
        /// <summary> Datacenter. </summary>
        public static HybridComputeLicenseEdition DataCenter { get; } = new HybridComputeLicenseEdition(DataCenterValue);
        /// <summary> Determines if two <see cref="HybridComputeLicenseEdition"/> values are the same. </summary>
        public static bool operator ==(HybridComputeLicenseEdition left, HybridComputeLicenseEdition right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeLicenseEdition"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeLicenseEdition left, HybridComputeLicenseEdition right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HybridComputeLicenseEdition"/>. </summary>
        public static implicit operator HybridComputeLicenseEdition(string value) => new HybridComputeLicenseEdition(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeLicenseEdition other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeLicenseEdition other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
