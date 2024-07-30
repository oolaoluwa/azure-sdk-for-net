// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The priority of the container group. </summary>
    public readonly partial struct ContainerGroupPriority : IEquatable<ContainerGroupPriority>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupPriority"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerGroupPriority(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegularValue = "Regular";
        private const string SpotValue = "Spot";

        /// <summary> Regular. </summary>
        public static ContainerGroupPriority Regular { get; } = new ContainerGroupPriority(RegularValue);
        /// <summary> Spot. </summary>
        public static ContainerGroupPriority Spot { get; } = new ContainerGroupPriority(SpotValue);
        /// <summary> Determines if two <see cref="ContainerGroupPriority"/> values are the same. </summary>
        public static bool operator ==(ContainerGroupPriority left, ContainerGroupPriority right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerGroupPriority"/> values are not the same. </summary>
        public static bool operator !=(ContainerGroupPriority left, ContainerGroupPriority right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerGroupPriority"/>. </summary>
        public static implicit operator ContainerGroupPriority(string value) => new ContainerGroupPriority(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerGroupPriority other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerGroupPriority other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
