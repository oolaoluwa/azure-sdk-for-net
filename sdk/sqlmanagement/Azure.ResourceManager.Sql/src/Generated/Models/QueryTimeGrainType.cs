// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Interval type (length). </summary>
    public readonly partial struct QueryTimeGrainType : IEquatable<QueryTimeGrainType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryTimeGrainType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryTimeGrainType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PT1HValue = "PT1H";
        private const string P1DValue = "P1D";

        /// <summary> PT1H. </summary>
        public static QueryTimeGrainType PT1H { get; } = new QueryTimeGrainType(PT1HValue);
        /// <summary> P1D. </summary>
        public static QueryTimeGrainType P1D { get; } = new QueryTimeGrainType(P1DValue);
        /// <summary> Determines if two <see cref="QueryTimeGrainType"/> values are the same. </summary>
        public static bool operator ==(QueryTimeGrainType left, QueryTimeGrainType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryTimeGrainType"/> values are not the same. </summary>
        public static bool operator !=(QueryTimeGrainType left, QueryTimeGrainType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryTimeGrainType"/>. </summary>
        public static implicit operator QueryTimeGrainType(string value) => new QueryTimeGrainType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryTimeGrainType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryTimeGrainType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
