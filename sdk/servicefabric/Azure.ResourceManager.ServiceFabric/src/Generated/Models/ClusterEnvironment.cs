// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Cluster operating system, the default will be Windows. </summary>
    public readonly partial struct ClusterEnvironment : IEquatable<ClusterEnvironment>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterEnvironment"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterEnvironment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static ClusterEnvironment Windows { get; } = new ClusterEnvironment(WindowsValue);
        /// <summary> Linux. </summary>
        public static ClusterEnvironment Linux { get; } = new ClusterEnvironment(LinuxValue);
        /// <summary> Determines if two <see cref="ClusterEnvironment"/> values are the same. </summary>
        public static bool operator ==(ClusterEnvironment left, ClusterEnvironment right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterEnvironment"/> values are not the same. </summary>
        public static bool operator !=(ClusterEnvironment left, ClusterEnvironment right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterEnvironment"/>. </summary>
        public static implicit operator ClusterEnvironment(string value) => new ClusterEnvironment(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterEnvironment other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterEnvironment other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
