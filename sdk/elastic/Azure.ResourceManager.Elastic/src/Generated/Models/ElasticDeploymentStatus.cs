// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Flag specifying if the Elastic deployment status is healthy or not. </summary>
    public readonly partial struct ElasticDeploymentStatus : IEquatable<ElasticDeploymentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticDeploymentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticDeploymentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HealthyValue = "Healthy";
        private const string UnhealthyValue = "Unhealthy";

        /// <summary> Healthy. </summary>
        public static ElasticDeploymentStatus Healthy { get; } = new ElasticDeploymentStatus(HealthyValue);
        /// <summary> Unhealthy. </summary>
        public static ElasticDeploymentStatus Unhealthy { get; } = new ElasticDeploymentStatus(UnhealthyValue);
        /// <summary> Determines if two <see cref="ElasticDeploymentStatus"/> values are the same. </summary>
        public static bool operator ==(ElasticDeploymentStatus left, ElasticDeploymentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticDeploymentStatus"/> values are not the same. </summary>
        public static bool operator !=(ElasticDeploymentStatus left, ElasticDeploymentStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ElasticDeploymentStatus"/>. </summary>
        public static implicit operator ElasticDeploymentStatus(string value) => new ElasticDeploymentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticDeploymentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticDeploymentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
