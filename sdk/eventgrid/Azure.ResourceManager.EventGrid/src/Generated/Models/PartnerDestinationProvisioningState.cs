// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the partner destination. </summary>
    public readonly partial struct PartnerDestinationProvisioningState : IEquatable<PartnerDestinationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PartnerDestinationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PartnerDestinationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string IdleDueToMirroredChannelResourceDeletionValue = "IdleDueToMirroredChannelResourceDeletion";

        /// <summary> Creating. </summary>
        public static PartnerDestinationProvisioningState Creating { get; } = new PartnerDestinationProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static PartnerDestinationProvisioningState Updating { get; } = new PartnerDestinationProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static PartnerDestinationProvisioningState Deleting { get; } = new PartnerDestinationProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static PartnerDestinationProvisioningState Succeeded { get; } = new PartnerDestinationProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static PartnerDestinationProvisioningState Canceled { get; } = new PartnerDestinationProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static PartnerDestinationProvisioningState Failed { get; } = new PartnerDestinationProvisioningState(FailedValue);
        /// <summary> IdleDueToMirroredChannelResourceDeletion. </summary>
        public static PartnerDestinationProvisioningState IdleDueToMirroredChannelResourceDeletion { get; } = new PartnerDestinationProvisioningState(IdleDueToMirroredChannelResourceDeletionValue);
        /// <summary> Determines if two <see cref="PartnerDestinationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(PartnerDestinationProvisioningState left, PartnerDestinationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PartnerDestinationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(PartnerDestinationProvisioningState left, PartnerDestinationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PartnerDestinationProvisioningState"/>. </summary>
        public static implicit operator PartnerDestinationProvisioningState(string value) => new PartnerDestinationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PartnerDestinationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PartnerDestinationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
