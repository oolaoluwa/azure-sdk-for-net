// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The type of the parameter. </summary>
    public readonly partial struct ScriptActivityParameterType : IEquatable<ScriptActivityParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScriptActivityParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScriptActivityParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BooleanValue = "Boolean";
        private const string DateTimeValue = "DateTime";
        private const string DateTimeOffsetValue = "DateTimeOffset";
        private const string DecimalValue = "Decimal";
        private const string DoubleValue = "Double";
        private const string GuidValue = "Guid";
        private const string Int16Value = "Int16";
        private const string Int32Value = "Int32";
        private const string Int64Value = "Int64";
        private const string SingleValue = "Single";
        private const string StringValue = "String";
        private const string TimeSpanValue = "Timespan";

        /// <summary> Boolean. </summary>
        public static ScriptActivityParameterType Boolean { get; } = new ScriptActivityParameterType(BooleanValue);
        /// <summary> DateTime. </summary>
        public static ScriptActivityParameterType DateTime { get; } = new ScriptActivityParameterType(DateTimeValue);
        /// <summary> DateTimeOffset. </summary>
        public static ScriptActivityParameterType DateTimeOffset { get; } = new ScriptActivityParameterType(DateTimeOffsetValue);
        /// <summary> Decimal. </summary>
        public static ScriptActivityParameterType Decimal { get; } = new ScriptActivityParameterType(DecimalValue);
        /// <summary> Double. </summary>
        public static ScriptActivityParameterType Double { get; } = new ScriptActivityParameterType(DoubleValue);
        /// <summary> Guid. </summary>
        public static ScriptActivityParameterType Guid { get; } = new ScriptActivityParameterType(GuidValue);
        /// <summary> Int16. </summary>
        public static ScriptActivityParameterType Int16 { get; } = new ScriptActivityParameterType(Int16Value);
        /// <summary> Int32. </summary>
        public static ScriptActivityParameterType Int32 { get; } = new ScriptActivityParameterType(Int32Value);
        /// <summary> Int64. </summary>
        public static ScriptActivityParameterType Int64 { get; } = new ScriptActivityParameterType(Int64Value);
        /// <summary> Single. </summary>
        public static ScriptActivityParameterType Single { get; } = new ScriptActivityParameterType(SingleValue);
        /// <summary> String. </summary>
        public static ScriptActivityParameterType String { get; } = new ScriptActivityParameterType(StringValue);
        /// <summary> Timespan. </summary>
        public static ScriptActivityParameterType TimeSpan { get; } = new ScriptActivityParameterType(TimeSpanValue);
        /// <summary> Determines if two <see cref="ScriptActivityParameterType"/> values are the same. </summary>
        public static bool operator ==(ScriptActivityParameterType left, ScriptActivityParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScriptActivityParameterType"/> values are not the same. </summary>
        public static bool operator !=(ScriptActivityParameterType left, ScriptActivityParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScriptActivityParameterType"/>. </summary>
        public static implicit operator ScriptActivityParameterType(string value) => new ScriptActivityParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScriptActivityParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScriptActivityParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
