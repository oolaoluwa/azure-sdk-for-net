// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A value indicating whether storage auto-grow is supported in this region. "Enabled" means storage auto-grow is supported. "Disabled" stands for storage auto-grow is not supported. </summary>
    public readonly partial struct PostgreSqlFlexibleServerStorageAutoGrowthSupported : IEquatable<PostgreSqlFlexibleServerStorageAutoGrowthSupported>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerStorageAutoGrowthSupported"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerStorageAutoGrowthSupported(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static PostgreSqlFlexibleServerStorageAutoGrowthSupported Enabled { get; } = new PostgreSqlFlexibleServerStorageAutoGrowthSupported(EnabledValue);
        /// <summary> Disabled. </summary>
        public static PostgreSqlFlexibleServerStorageAutoGrowthSupported Disabled { get; } = new PostgreSqlFlexibleServerStorageAutoGrowthSupported(DisabledValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerStorageAutoGrowthSupported"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerStorageAutoGrowthSupported left, PostgreSqlFlexibleServerStorageAutoGrowthSupported right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerStorageAutoGrowthSupported"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerStorageAutoGrowthSupported left, PostgreSqlFlexibleServerStorageAutoGrowthSupported right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerStorageAutoGrowthSupported"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerStorageAutoGrowthSupported(string value) => new PostgreSqlFlexibleServerStorageAutoGrowthSupported(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerStorageAutoGrowthSupported other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerStorageAutoGrowthSupported other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
