// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The data source type. </summary>
    public readonly partial struct DataSourceType : IEquatable<DataSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectorValue = "Connector";
        private const string LinkInteractionValue = "LinkInteraction";
        private const string SystemDefaultValue = "SystemDefault";

        /// <summary> Connector. </summary>
        public static DataSourceType Connector { get; } = new DataSourceType(ConnectorValue);
        /// <summary> LinkInteraction. </summary>
        public static DataSourceType LinkInteraction { get; } = new DataSourceType(LinkInteractionValue);
        /// <summary> SystemDefault. </summary>
        public static DataSourceType SystemDefault { get; } = new DataSourceType(SystemDefaultValue);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are the same. </summary>
        public static bool operator ==(DataSourceType left, DataSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are not the same. </summary>
        public static bool operator !=(DataSourceType left, DataSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataSourceType"/>. </summary>
        public static implicit operator DataSourceType(string value) => new DataSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
