// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Specifies on which week of the month the dayOfWeek applies. </summary>
    public readonly partial struct ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex : IEquatable<ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirstValue = "First";
        private const string SecondValue = "Second";
        private const string ThirdValue = "Third";
        private const string FourthValue = "Fourth";
        private const string LastValue = "Last";

        /// <summary> First week of the month. </summary>
        public static ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex First { get; } = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(FirstValue);
        /// <summary> Second week of the month. </summary>
        public static ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Second { get; } = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(SecondValue);
        /// <summary> Third week of the month. </summary>
        public static ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Third { get; } = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(ThirdValue);
        /// <summary> Fourth week of the month. </summary>
        public static ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Fourth { get; } = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(FourthValue);
        /// <summary> Last week of the month. </summary>
        public static ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Last { get; } = new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(LastValue);
        /// <summary> Determines if two <see cref="ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex left, ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex left, ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex"/>. </summary>
        public static implicit operator ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(string value) => new ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
