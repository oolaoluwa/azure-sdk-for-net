// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> snooze scope. </summary>
    public readonly partial struct SnoozeScope : IEquatable<SnoozeScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SnoozeScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SnoozeScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MetricValue = "Metric";
        private const string SeriesValue = "Series";
        /// <summary> Determines if two <see cref="SnoozeScope"/> values are the same. </summary>
        public static bool operator ==(SnoozeScope left, SnoozeScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SnoozeScope"/> values are not the same. </summary>
        public static bool operator !=(SnoozeScope left, SnoozeScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SnoozeScope"/>. </summary>
        public static implicit operator SnoozeScope(string value) => new SnoozeScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SnoozeScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SnoozeScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
