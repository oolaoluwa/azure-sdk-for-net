// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Addon type. </summary>
    internal readonly partial struct AddonType : IEquatable<AddonType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddonType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddonType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IotEdgeValue = "IotEdge";
        private const string ArcForKubernetesValue = "ArcForKubernetes";

        /// <summary> IotEdge. </summary>
        public static AddonType IotEdge { get; } = new AddonType(IotEdgeValue);
        /// <summary> ArcForKubernetes. </summary>
        public static AddonType ArcForKubernetes { get; } = new AddonType(ArcForKubernetesValue);
        /// <summary> Determines if two <see cref="AddonType"/> values are the same. </summary>
        public static bool operator ==(AddonType left, AddonType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddonType"/> values are not the same. </summary>
        public static bool operator !=(AddonType left, AddonType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddonType"/>. </summary>
        public static implicit operator AddonType(string value) => new AddonType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddonType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddonType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
