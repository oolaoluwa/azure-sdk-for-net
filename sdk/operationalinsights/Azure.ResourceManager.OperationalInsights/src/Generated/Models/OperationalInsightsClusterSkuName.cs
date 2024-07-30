// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The name of the SKU. </summary>
    public readonly partial struct OperationalInsightsClusterSkuName : IEquatable<OperationalInsightsClusterSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsClusterSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsClusterSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CapacityReservationValue = "CapacityReservation";

        /// <summary> CapacityReservation. </summary>
        public static OperationalInsightsClusterSkuName CapacityReservation { get; } = new OperationalInsightsClusterSkuName(CapacityReservationValue);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterSkuName"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsClusterSkuName left, OperationalInsightsClusterSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsClusterSkuName"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsClusterSkuName left, OperationalInsightsClusterSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationalInsightsClusterSkuName"/>. </summary>
        public static implicit operator OperationalInsightsClusterSkuName(string value) => new OperationalInsightsClusterSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsClusterSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsClusterSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
