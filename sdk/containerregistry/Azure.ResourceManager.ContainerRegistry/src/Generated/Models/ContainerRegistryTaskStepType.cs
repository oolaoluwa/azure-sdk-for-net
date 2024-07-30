// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of the step. </summary>
    internal readonly partial struct ContainerRegistryTaskStepType : IEquatable<ContainerRegistryTaskStepType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskStepType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryTaskStepType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DockerValue = "Docker";
        private const string FileTaskValue = "FileTask";
        private const string EncodedTaskValue = "EncodedTask";

        /// <summary> Docker. </summary>
        public static ContainerRegistryTaskStepType Docker { get; } = new ContainerRegistryTaskStepType(DockerValue);
        /// <summary> FileTask. </summary>
        public static ContainerRegistryTaskStepType FileTask { get; } = new ContainerRegistryTaskStepType(FileTaskValue);
        /// <summary> EncodedTask. </summary>
        public static ContainerRegistryTaskStepType EncodedTask { get; } = new ContainerRegistryTaskStepType(EncodedTaskValue);
        /// <summary> Determines if two <see cref="ContainerRegistryTaskStepType"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryTaskStepType left, ContainerRegistryTaskStepType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryTaskStepType"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryTaskStepType left, ContainerRegistryTaskStepType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryTaskStepType"/>. </summary>
        public static implicit operator ContainerRegistryTaskStepType(string value) => new ContainerRegistryTaskStepType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryTaskStepType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryTaskStepType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
