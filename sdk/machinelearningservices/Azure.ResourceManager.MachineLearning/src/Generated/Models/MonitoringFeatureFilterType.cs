// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitoringFeatureFilterType. </summary>
    internal readonly partial struct MonitoringFeatureFilterType : IEquatable<MonitoringFeatureFilterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitoringFeatureFilterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitoringFeatureFilterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllFeaturesValue = "AllFeatures";
        private const string TopNByAttributionValue = "TopNByAttribution";
        private const string FeatureSubsetValue = "FeatureSubset";

        /// <summary> Includes all features. </summary>
        public static MonitoringFeatureFilterType AllFeatures { get; } = new MonitoringFeatureFilterType(AllFeaturesValue);
        /// <summary> Only includes the top contributing features, measured by feature attribution. </summary>
        public static MonitoringFeatureFilterType TopNByAttribution { get; } = new MonitoringFeatureFilterType(TopNByAttributionValue);
        /// <summary> Includes a user-defined subset of features. </summary>
        public static MonitoringFeatureFilterType FeatureSubset { get; } = new MonitoringFeatureFilterType(FeatureSubsetValue);
        /// <summary> Determines if two <see cref="MonitoringFeatureFilterType"/> values are the same. </summary>
        public static bool operator ==(MonitoringFeatureFilterType left, MonitoringFeatureFilterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitoringFeatureFilterType"/> values are not the same. </summary>
        public static bool operator !=(MonitoringFeatureFilterType left, MonitoringFeatureFilterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitoringFeatureFilterType"/>. </summary>
        public static implicit operator MonitoringFeatureFilterType(string value) => new MonitoringFeatureFilterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitoringFeatureFilterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitoringFeatureFilterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
