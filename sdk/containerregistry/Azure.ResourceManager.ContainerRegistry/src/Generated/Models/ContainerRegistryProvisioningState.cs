// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The provisioning state of this agent pool. </summary>
    public readonly partial struct ContainerRegistryProvisioningState : IEquatable<ContainerRegistryProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static ContainerRegistryProvisioningState Creating { get; } = new ContainerRegistryProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ContainerRegistryProvisioningState Updating { get; } = new ContainerRegistryProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ContainerRegistryProvisioningState Deleting { get; } = new ContainerRegistryProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static ContainerRegistryProvisioningState Succeeded { get; } = new ContainerRegistryProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerRegistryProvisioningState Failed { get; } = new ContainerRegistryProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerRegistryProvisioningState Canceled { get; } = new ContainerRegistryProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="ContainerRegistryProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryProvisioningState left, ContainerRegistryProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryProvisioningState left, ContainerRegistryProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryProvisioningState"/>. </summary>
        public static implicit operator ContainerRegistryProvisioningState(string value) => new ContainerRegistryProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
