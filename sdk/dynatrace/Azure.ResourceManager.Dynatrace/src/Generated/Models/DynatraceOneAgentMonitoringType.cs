// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> The monitoring mode of OneAgent. </summary>
    public readonly partial struct DynatraceOneAgentMonitoringType : IEquatable<DynatraceOneAgentMonitoringType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynatraceOneAgentMonitoringType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynatraceOneAgentMonitoringType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CloudInfrastructureValue = "CLOUD_INFRASTRUCTURE";
        private const string FullStackValue = "FULL_STACK";

        /// <summary> CLOUD_INFRASTRUCTURE. </summary>
        public static DynatraceOneAgentMonitoringType CloudInfrastructure { get; } = new DynatraceOneAgentMonitoringType(CloudInfrastructureValue);
        /// <summary> FULL_STACK. </summary>
        public static DynatraceOneAgentMonitoringType FullStack { get; } = new DynatraceOneAgentMonitoringType(FullStackValue);
        /// <summary> Determines if two <see cref="DynatraceOneAgentMonitoringType"/> values are the same. </summary>
        public static bool operator ==(DynatraceOneAgentMonitoringType left, DynatraceOneAgentMonitoringType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynatraceOneAgentMonitoringType"/> values are not the same. </summary>
        public static bool operator !=(DynatraceOneAgentMonitoringType left, DynatraceOneAgentMonitoringType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DynatraceOneAgentMonitoringType"/>. </summary>
        public static implicit operator DynatraceOneAgentMonitoringType(string value) => new DynatraceOneAgentMonitoringType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynatraceOneAgentMonitoringType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynatraceOneAgentMonitoringType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
