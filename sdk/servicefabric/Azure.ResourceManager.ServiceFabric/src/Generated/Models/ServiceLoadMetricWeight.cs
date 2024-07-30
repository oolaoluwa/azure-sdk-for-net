// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Determines the metric weight relative to the other metrics that are configured for this service. During runtime, if two metrics end up in conflict, the Cluster Resource Manager prefers the metric with the higher weight. </summary>
    public readonly partial struct ServiceLoadMetricWeight : IEquatable<ServiceLoadMetricWeight>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceLoadMetricWeight"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceLoadMetricWeight(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ZeroValue = "Zero";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Disables resource balancing for this metric. This value is zero. </summary>
        public static ServiceLoadMetricWeight Zero { get; } = new ServiceLoadMetricWeight(ZeroValue);
        /// <summary> Specifies the metric weight of the service load as Low. The value is 1. </summary>
        public static ServiceLoadMetricWeight Low { get; } = new ServiceLoadMetricWeight(LowValue);
        /// <summary> Specifies the metric weight of the service load as Medium. The value is 2. </summary>
        public static ServiceLoadMetricWeight Medium { get; } = new ServiceLoadMetricWeight(MediumValue);
        /// <summary> Specifies the metric weight of the service load as High. The value is 3. </summary>
        public static ServiceLoadMetricWeight High { get; } = new ServiceLoadMetricWeight(HighValue);
        /// <summary> Determines if two <see cref="ServiceLoadMetricWeight"/> values are the same. </summary>
        public static bool operator ==(ServiceLoadMetricWeight left, ServiceLoadMetricWeight right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceLoadMetricWeight"/> values are not the same. </summary>
        public static bool operator !=(ServiceLoadMetricWeight left, ServiceLoadMetricWeight right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceLoadMetricWeight"/>. </summary>
        public static implicit operator ServiceLoadMetricWeight(string value) => new ServiceLoadMetricWeight(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceLoadMetricWeight other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceLoadMetricWeight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
