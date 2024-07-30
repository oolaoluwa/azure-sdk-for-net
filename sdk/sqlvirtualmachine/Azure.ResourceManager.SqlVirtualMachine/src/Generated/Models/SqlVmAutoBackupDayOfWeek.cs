// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> The SqlVmAutoBackupDayOfWeek. </summary>
    public readonly partial struct SqlVmAutoBackupDayOfWeek : IEquatable<SqlVmAutoBackupDayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlVmAutoBackupDayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVmAutoBackupDayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";
        private const string SundayValue = "Sunday";

        /// <summary> Monday. </summary>
        public static SqlVmAutoBackupDayOfWeek Monday { get; } = new SqlVmAutoBackupDayOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static SqlVmAutoBackupDayOfWeek Tuesday { get; } = new SqlVmAutoBackupDayOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static SqlVmAutoBackupDayOfWeek Wednesday { get; } = new SqlVmAutoBackupDayOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static SqlVmAutoBackupDayOfWeek Thursday { get; } = new SqlVmAutoBackupDayOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static SqlVmAutoBackupDayOfWeek Friday { get; } = new SqlVmAutoBackupDayOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static SqlVmAutoBackupDayOfWeek Saturday { get; } = new SqlVmAutoBackupDayOfWeek(SaturdayValue);
        /// <summary> Sunday. </summary>
        public static SqlVmAutoBackupDayOfWeek Sunday { get; } = new SqlVmAutoBackupDayOfWeek(SundayValue);
        /// <summary> Determines if two <see cref="SqlVmAutoBackupDayOfWeek"/> values are the same. </summary>
        public static bool operator ==(SqlVmAutoBackupDayOfWeek left, SqlVmAutoBackupDayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVmAutoBackupDayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(SqlVmAutoBackupDayOfWeek left, SqlVmAutoBackupDayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlVmAutoBackupDayOfWeek"/>. </summary>
        public static implicit operator SqlVmAutoBackupDayOfWeek(string value) => new SqlVmAutoBackupDayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVmAutoBackupDayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVmAutoBackupDayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
