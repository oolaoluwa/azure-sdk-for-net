// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Recommendation status. When the recommendation status is disabled recommendations are not generated. </summary>
    public readonly partial struct RecommendationConfigStatus : IEquatable<RecommendationConfigStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendationConfigStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendationConfigStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static RecommendationConfigStatus Disabled { get; } = new RecommendationConfigStatus(DisabledValue);
        /// <summary> Enabled. </summary>
        public static RecommendationConfigStatus Enabled { get; } = new RecommendationConfigStatus(EnabledValue);
        /// <summary> Determines if two <see cref="RecommendationConfigStatus"/> values are the same. </summary>
        public static bool operator ==(RecommendationConfigStatus left, RecommendationConfigStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendationConfigStatus"/> values are not the same. </summary>
        public static bool operator !=(RecommendationConfigStatus left, RecommendationConfigStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecommendationConfigStatus"/>. </summary>
        public static implicit operator RecommendationConfigStatus(string value) => new RecommendationConfigStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendationConfigStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendationConfigStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
