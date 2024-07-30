// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status. </summary>
    public readonly partial struct FrontDoorProvisioningState : IEquatable<FrontDoorProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static FrontDoorProvisioningState Succeeded { get; } = new FrontDoorProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static FrontDoorProvisioningState Failed { get; } = new FrontDoorProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static FrontDoorProvisioningState Updating { get; } = new FrontDoorProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static FrontDoorProvisioningState Deleting { get; } = new FrontDoorProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static FrontDoorProvisioningState Creating { get; } = new FrontDoorProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="FrontDoorProvisioningState"/> values are the same. </summary>
        public static bool operator ==(FrontDoorProvisioningState left, FrontDoorProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorProvisioningState left, FrontDoorProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorProvisioningState"/>. </summary>
        public static implicit operator FrontDoorProvisioningState(string value) => new FrontDoorProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
