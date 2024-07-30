// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> SQL Server connectivity option. </summary>
    public readonly partial struct SqlServerConnectivityType : IEquatable<SqlServerConnectivityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlServerConnectivityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlServerConnectivityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocalValue = "LOCAL";
        private const string PrivateValue = "PRIVATE";
        private const string PublicValue = "PUBLIC";

        /// <summary> LOCAL. </summary>
        public static SqlServerConnectivityType Local { get; } = new SqlServerConnectivityType(LocalValue);
        /// <summary> PRIVATE. </summary>
        public static SqlServerConnectivityType Private { get; } = new SqlServerConnectivityType(PrivateValue);
        /// <summary> PUBLIC. </summary>
        public static SqlServerConnectivityType Public { get; } = new SqlServerConnectivityType(PublicValue);
        /// <summary> Determines if two <see cref="SqlServerConnectivityType"/> values are the same. </summary>
        public static bool operator ==(SqlServerConnectivityType left, SqlServerConnectivityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlServerConnectivityType"/> values are not the same. </summary>
        public static bool operator !=(SqlServerConnectivityType left, SqlServerConnectivityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlServerConnectivityType"/>. </summary>
        public static implicit operator SqlServerConnectivityType(string value) => new SqlServerConnectivityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlServerConnectivityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlServerConnectivityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
