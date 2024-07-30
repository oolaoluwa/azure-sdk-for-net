// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status of the origin. </summary>
    public readonly partial struct OriginProvisioningState : IEquatable<OriginProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OriginProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OriginProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static OriginProvisioningState Succeeded { get; } = new OriginProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static OriginProvisioningState Failed { get; } = new OriginProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static OriginProvisioningState Updating { get; } = new OriginProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static OriginProvisioningState Deleting { get; } = new OriginProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static OriginProvisioningState Creating { get; } = new OriginProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="OriginProvisioningState"/> values are the same. </summary>
        public static bool operator ==(OriginProvisioningState left, OriginProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OriginProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(OriginProvisioningState left, OriginProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OriginProvisioningState"/>. </summary>
        public static implicit operator OriginProvisioningState(string value) => new OriginProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OriginProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OriginProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
