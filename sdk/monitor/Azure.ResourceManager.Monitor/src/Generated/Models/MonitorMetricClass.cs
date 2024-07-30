// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The class of the metric. </summary>
    public readonly partial struct MonitorMetricClass : IEquatable<MonitorMetricClass>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorMetricClass"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorMetricClass(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailabilityValue = "Availability";
        private const string TransactionsValue = "Transactions";
        private const string ErrorsValue = "Errors";
        private const string LatencyValue = "Latency";
        private const string SaturationValue = "Saturation";

        /// <summary> Availability. </summary>
        public static MonitorMetricClass Availability { get; } = new MonitorMetricClass(AvailabilityValue);
        /// <summary> Transactions. </summary>
        public static MonitorMetricClass Transactions { get; } = new MonitorMetricClass(TransactionsValue);
        /// <summary> Errors. </summary>
        public static MonitorMetricClass Errors { get; } = new MonitorMetricClass(ErrorsValue);
        /// <summary> Latency. </summary>
        public static MonitorMetricClass Latency { get; } = new MonitorMetricClass(LatencyValue);
        /// <summary> Saturation. </summary>
        public static MonitorMetricClass Saturation { get; } = new MonitorMetricClass(SaturationValue);
        /// <summary> Determines if two <see cref="MonitorMetricClass"/> values are the same. </summary>
        public static bool operator ==(MonitorMetricClass left, MonitorMetricClass right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorMetricClass"/> values are not the same. </summary>
        public static bool operator !=(MonitorMetricClass left, MonitorMetricClass right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorMetricClass"/>. </summary>
        public static implicit operator MonitorMetricClass(string value) => new MonitorMetricClass(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorMetricClass other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorMetricClass other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
