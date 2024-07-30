// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A value indicating whether Zone Redundant HA is supported in this region. "Enabled" means zone redundant HA is supported. "Disabled" stands for zone redundant HA is not supported. </summary>
    public readonly partial struct PostgreSqlFlexibleServerZoneRedundantHaSupported : IEquatable<PostgreSqlFlexibleServerZoneRedundantHaSupported>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerZoneRedundantHaSupported"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerZoneRedundantHaSupported(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlFlexibleServerZoneRedundantHaSupported Enabled { get; } = new PostgreSqlFlexibleServerZoneRedundantHaSupported(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlFlexibleServerZoneRedundantHaSupported Disabled { get; } = new PostgreSqlFlexibleServerZoneRedundantHaSupported(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerZoneRedundantHaSupported"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerZoneRedundantHaSupported left, PostgreSqlFlexibleServerZoneRedundantHaSupported right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerZoneRedundantHaSupported"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerZoneRedundantHaSupported left, PostgreSqlFlexibleServerZoneRedundantHaSupported right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerZoneRedundantHaSupported"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerZoneRedundantHaSupported(string value) => new PostgreSqlFlexibleServerZoneRedundantHaSupported(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerZoneRedundantHaSupported other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerZoneRedundantHaSupported other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
