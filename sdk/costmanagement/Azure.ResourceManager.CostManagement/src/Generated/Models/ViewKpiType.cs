// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> KPI type (Forecast, Budget). </summary>
    public readonly partial struct ViewKpiType : IEquatable<ViewKpiType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ViewKpiType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ViewKpiType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ForecastValue = "Forecast";
        private const string BudgetValue = "Budget";

        /// <summary> Forecast. </summary>
        public static ViewKpiType Forecast { get; } = new ViewKpiType(ForecastValue);
        /// <summary> Budget. </summary>
        public static ViewKpiType Budget { get; } = new ViewKpiType(BudgetValue);
        /// <summary> Determines if two <see cref="ViewKpiType"/> values are the same. </summary>
        public static bool operator ==(ViewKpiType left, ViewKpiType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ViewKpiType"/> values are not the same. </summary>
        public static bool operator !=(ViewKpiType left, ViewKpiType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ViewKpiType"/>. </summary>
        public static implicit operator ViewKpiType(string value) => new ViewKpiType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ViewKpiType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ViewKpiType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
