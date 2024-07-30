// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Indicates the type of index. </summary>
    public readonly partial struct CosmosDBIndexKind : IEquatable<CosmosDBIndexKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBIndexKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBIndexKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HashValue = "Hash";
        private const string RangeValue = "Range";
        private const string SpatialValue = "Spatial";

        /// <summary> Hash. </summary>
        public static CosmosDBIndexKind Hash { get; } = new CosmosDBIndexKind(HashValue);
        /// <summary> Range. </summary>
        public static CosmosDBIndexKind Range { get; } = new CosmosDBIndexKind(RangeValue);
        /// <summary> Spatial. </summary>
        public static CosmosDBIndexKind Spatial { get; } = new CosmosDBIndexKind(SpatialValue);
        /// <summary> Determines if two <see cref="CosmosDBIndexKind"/> values are the same. </summary>
        public static bool operator ==(CosmosDBIndexKind left, CosmosDBIndexKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBIndexKind"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBIndexKind left, CosmosDBIndexKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBIndexKind"/>. </summary>
        public static implicit operator CosmosDBIndexKind(string value) => new CosmosDBIndexKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBIndexKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBIndexKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
