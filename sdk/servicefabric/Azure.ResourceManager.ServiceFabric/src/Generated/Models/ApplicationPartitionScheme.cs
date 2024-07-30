// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Enumerates the ways that a service can be partitioned. </summary>
    internal readonly partial struct ApplicationPartitionScheme : IEquatable<ApplicationPartitionScheme>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationPartitionScheme"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationPartitionScheme(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string SingletonValue = "Singleton";
        private const string UniformInt64RangeValue = "UniformInt64Range";
        private const string NamedValue = "Named";

        /// <summary> Indicates the partition kind is invalid. All Service Fabric enumerations have the invalid type. The value is zero. </summary>
        public static ApplicationPartitionScheme Invalid { get; } = new ApplicationPartitionScheme(InvalidValue);
        /// <summary> Indicates that the partition is based on string names, and is a SingletonPartitionSchemeDescription object, The value is 1. </summary>
        public static ApplicationPartitionScheme Singleton { get; } = new ApplicationPartitionScheme(SingletonValue);
        /// <summary> Indicates that the partition is based on Int64 key ranges, and is a UniformInt64RangePartitionSchemeDescription object. The value is 2. </summary>
        public static ApplicationPartitionScheme UniformInt64Range { get; } = new ApplicationPartitionScheme(UniformInt64RangeValue);
        /// <summary> Indicates that the partition is based on string names, and is a NamedPartitionSchemeDescription object. The value is 3. </summary>
        public static ApplicationPartitionScheme Named { get; } = new ApplicationPartitionScheme(NamedValue);
        /// <summary> Determines if two <see cref="ApplicationPartitionScheme"/> values are the same. </summary>
        public static bool operator ==(ApplicationPartitionScheme left, ApplicationPartitionScheme right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationPartitionScheme"/> values are not the same. </summary>
        public static bool operator !=(ApplicationPartitionScheme left, ApplicationPartitionScheme right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationPartitionScheme"/>. </summary>
        public static implicit operator ApplicationPartitionScheme(string value) => new ApplicationPartitionScheme(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationPartitionScheme other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationPartitionScheme other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
