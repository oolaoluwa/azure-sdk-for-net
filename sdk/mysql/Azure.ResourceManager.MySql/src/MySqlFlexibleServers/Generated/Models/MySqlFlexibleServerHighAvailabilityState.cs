// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The state of server high availability. </summary>
    public readonly partial struct MySqlFlexibleServerHighAvailabilityState : IEquatable<MySqlFlexibleServerHighAvailabilityState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerHighAvailabilityState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerHighAvailabilityState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotEnabledValue = "NotEnabled";
        private const string CreatingStandbyValue = "CreatingStandby";
        private const string HealthyValue = "Healthy";
        private const string FailingOverValue = "FailingOver";
        private const string RemovingStandbyValue = "RemovingStandby";

        /// <summary> NotEnabled. </summary>
        public static MySqlFlexibleServerHighAvailabilityState NotEnabled { get; } = new MySqlFlexibleServerHighAvailabilityState(NotEnabledValue);
        /// <summary> CreatingStandby. </summary>
        public static MySqlFlexibleServerHighAvailabilityState CreatingStandby { get; } = new MySqlFlexibleServerHighAvailabilityState(CreatingStandbyValue);
        /// <summary> Healthy. </summary>
        public static MySqlFlexibleServerHighAvailabilityState Healthy { get; } = new MySqlFlexibleServerHighAvailabilityState(HealthyValue);
        /// <summary> FailingOver. </summary>
        public static MySqlFlexibleServerHighAvailabilityState FailingOver { get; } = new MySqlFlexibleServerHighAvailabilityState(FailingOverValue);
        /// <summary> RemovingStandby. </summary>
        public static MySqlFlexibleServerHighAvailabilityState RemovingStandby { get; } = new MySqlFlexibleServerHighAvailabilityState(RemovingStandbyValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerHighAvailabilityState"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerHighAvailabilityState left, MySqlFlexibleServerHighAvailabilityState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerHighAvailabilityState"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerHighAvailabilityState left, MySqlFlexibleServerHighAvailabilityState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerHighAvailabilityState"/>. </summary>
        public static implicit operator MySqlFlexibleServerHighAvailabilityState(string value) => new MySqlFlexibleServerHighAvailabilityState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerHighAvailabilityState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerHighAvailabilityState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
