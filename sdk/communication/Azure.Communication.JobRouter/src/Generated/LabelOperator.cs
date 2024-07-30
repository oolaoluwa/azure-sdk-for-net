// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes supported operations on label values. </summary>
    public readonly partial struct LabelOperator : IEquatable<LabelOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LabelOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LabelOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualValue = "equal";
        private const string NotEqualValue = "notEqual";
        private const string LessThanValue = "lessThan";
        private const string LessThanOrEqualValue = "lessThanOrEqual";
        private const string GreaterThanValue = "greaterThan";
        private const string GreaterThanOrEqualValue = "greaterThanOrEqual";

        /// <summary> Equal. </summary>
        public static LabelOperator Equal { get; } = new LabelOperator(EqualValue);
        /// <summary> Not Equal. </summary>
        public static LabelOperator NotEqual { get; } = new LabelOperator(NotEqualValue);
        /// <summary> Less than. </summary>
        public static LabelOperator LessThan { get; } = new LabelOperator(LessThanValue);
        /// <summary> Less than or equal. </summary>
        public static LabelOperator LessThanOrEqual { get; } = new LabelOperator(LessThanOrEqualValue);
        /// <summary> Greater than. </summary>
        public static LabelOperator GreaterThan { get; } = new LabelOperator(GreaterThanValue);
        /// <summary> Greater than or equal. </summary>
        public static LabelOperator GreaterThanOrEqual { get; } = new LabelOperator(GreaterThanOrEqualValue);
        /// <summary> Determines if two <see cref="LabelOperator"/> values are the same. </summary>
        public static bool operator ==(LabelOperator left, LabelOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LabelOperator"/> values are not the same. </summary>
        public static bool operator !=(LabelOperator left, LabelOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LabelOperator"/>. </summary>
        public static implicit operator LabelOperator(string value) => new LabelOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LabelOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LabelOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
