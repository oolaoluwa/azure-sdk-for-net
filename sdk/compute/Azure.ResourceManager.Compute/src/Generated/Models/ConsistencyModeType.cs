// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> ConsistencyMode of the RestorePoint. Can be specified in the input while creating a restore point. For now, only CrashConsistent is accepted as a valid input. Please refer to https://aka.ms/RestorePoints for more details. </summary>
    public readonly partial struct ConsistencyModeType : IEquatable<ConsistencyModeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsistencyModeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsistencyModeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CrashConsistentValue = "CrashConsistent";
        private const string FileSystemConsistentValue = "FileSystemConsistent";
        private const string ApplicationConsistentValue = "ApplicationConsistent";

        /// <summary> CrashConsistent. </summary>
        public static ConsistencyModeType CrashConsistent { get; } = new ConsistencyModeType(CrashConsistentValue);
        /// <summary> FileSystemConsistent. </summary>
        public static ConsistencyModeType FileSystemConsistent { get; } = new ConsistencyModeType(FileSystemConsistentValue);
        /// <summary> ApplicationConsistent. </summary>
        public static ConsistencyModeType ApplicationConsistent { get; } = new ConsistencyModeType(ApplicationConsistentValue);
        /// <summary> Determines if two <see cref="ConsistencyModeType"/> values are the same. </summary>
        public static bool operator ==(ConsistencyModeType left, ConsistencyModeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsistencyModeType"/> values are not the same. </summary>
        public static bool operator !=(ConsistencyModeType left, ConsistencyModeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConsistencyModeType"/>. </summary>
        public static implicit operator ConsistencyModeType(string value) => new ConsistencyModeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsistencyModeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsistencyModeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
