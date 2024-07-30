// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Schedule enable or disable status. Indicates whether the schedule applied to is either enabled or disabled. </summary>
    public readonly partial struct DevCenterScheduleEnableStatus : IEquatable<DevCenterScheduleEnableStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterScheduleEnableStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterScheduleEnableStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IsEnabledValue = "Enabled";
        private const string IsDisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DevCenterScheduleEnableStatus IsEnabled { get; } = new DevCenterScheduleEnableStatus(IsEnabledValue);
        /// <summary> Disabled. </summary>
        public static DevCenterScheduleEnableStatus IsDisabled { get; } = new DevCenterScheduleEnableStatus(IsDisabledValue);
        /// <summary> Determines if two <see cref="DevCenterScheduleEnableStatus"/> values are the same. </summary>
        public static bool operator ==(DevCenterScheduleEnableStatus left, DevCenterScheduleEnableStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterScheduleEnableStatus"/> values are not the same. </summary>
        public static bool operator !=(DevCenterScheduleEnableStatus left, DevCenterScheduleEnableStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevCenterScheduleEnableStatus"/>. </summary>
        public static implicit operator DevCenterScheduleEnableStatus(string value) => new DevCenterScheduleEnableStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterScheduleEnableStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterScheduleEnableStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
