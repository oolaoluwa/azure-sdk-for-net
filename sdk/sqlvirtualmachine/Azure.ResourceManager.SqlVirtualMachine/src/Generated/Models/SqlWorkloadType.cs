// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> SQL Server workload type. </summary>
    public readonly partial struct SqlWorkloadType : IEquatable<SqlWorkloadType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlWorkloadType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlWorkloadType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GeneralValue = "GENERAL";
        private const string OltpValue = "OLTP";
        private const string DWValue = "DW";

        /// <summary> GENERAL. </summary>
        public static SqlWorkloadType General { get; } = new SqlWorkloadType(GeneralValue);
        /// <summary> OLTP. </summary>
        public static SqlWorkloadType Oltp { get; } = new SqlWorkloadType(OltpValue);
        /// <summary> DW. </summary>
        public static SqlWorkloadType DW { get; } = new SqlWorkloadType(DWValue);
        /// <summary> Determines if two <see cref="SqlWorkloadType"/> values are the same. </summary>
        public static bool operator ==(SqlWorkloadType left, SqlWorkloadType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlWorkloadType"/> values are not the same. </summary>
        public static bool operator !=(SqlWorkloadType left, SqlWorkloadType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlWorkloadType"/>. </summary>
        public static implicit operator SqlWorkloadType(string value) => new SqlWorkloadType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlWorkloadType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlWorkloadType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
