// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The unit details. </summary>
    public readonly partial struct DevCenterUsageUnit : IEquatable<DevCenterUsageUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterUsageUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterUsageUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountValue = "Count";

        /// <summary> Count. </summary>
        public static DevCenterUsageUnit Count { get; } = new DevCenterUsageUnit(CountValue);
        /// <summary> Determines if two <see cref="DevCenterUsageUnit"/> values are the same. </summary>
        public static bool operator ==(DevCenterUsageUnit left, DevCenterUsageUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterUsageUnit"/> values are not the same. </summary>
        public static bool operator !=(DevCenterUsageUnit left, DevCenterUsageUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevCenterUsageUnit"/>. </summary>
        public static implicit operator DevCenterUsageUnit(string value) => new DevCenterUsageUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterUsageUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterUsageUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
