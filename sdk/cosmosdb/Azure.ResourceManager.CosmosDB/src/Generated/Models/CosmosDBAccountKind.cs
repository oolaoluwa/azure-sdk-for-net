// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Indicates the type of database account. This can only be set at database account creation. </summary>
    public readonly partial struct CosmosDBAccountKind : IEquatable<CosmosDBAccountKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBAccountKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GlobalDocumentDBValue = "GlobalDocumentDB";
        private const string MongoDBValue = "MongoDB";
        private const string ParseValue = "Parse";

        /// <summary> GlobalDocumentDB. </summary>
        public static CosmosDBAccountKind GlobalDocumentDB { get; } = new CosmosDBAccountKind(GlobalDocumentDBValue);
        /// <summary> MongoDB. </summary>
        public static CosmosDBAccountKind MongoDB { get; } = new CosmosDBAccountKind(MongoDBValue);
        /// <summary> Parse. </summary>
        public static CosmosDBAccountKind Parse { get; } = new CosmosDBAccountKind(ParseValue);
        /// <summary> Determines if two <see cref="CosmosDBAccountKind"/> values are the same. </summary>
        public static bool operator ==(CosmosDBAccountKind left, CosmosDBAccountKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBAccountKind"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBAccountKind left, CosmosDBAccountKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBAccountKind"/>. </summary>
        public static implicit operator CosmosDBAccountKind(string value) => new CosmosDBAccountKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBAccountKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBAccountKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
