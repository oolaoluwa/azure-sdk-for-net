// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Gets the status of the resource at the time the operation was called. </summary>
    public readonly partial struct CommitmentPlanProvisioningState : IEquatable<CommitmentPlanProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommitmentPlanProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommitmentPlanProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";

        /// <summary> Accepted. </summary>
        public static CommitmentPlanProvisioningState Accepted { get; } = new CommitmentPlanProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static CommitmentPlanProvisioningState Creating { get; } = new CommitmentPlanProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static CommitmentPlanProvisioningState Deleting { get; } = new CommitmentPlanProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static CommitmentPlanProvisioningState Moving { get; } = new CommitmentPlanProvisioningState(MovingValue);
        /// <summary> Failed. </summary>
        public static CommitmentPlanProvisioningState Failed { get; } = new CommitmentPlanProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static CommitmentPlanProvisioningState Succeeded { get; } = new CommitmentPlanProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static CommitmentPlanProvisioningState Canceled { get; } = new CommitmentPlanProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="CommitmentPlanProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CommitmentPlanProvisioningState left, CommitmentPlanProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommitmentPlanProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CommitmentPlanProvisioningState left, CommitmentPlanProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommitmentPlanProvisioningState"/>. </summary>
        public static implicit operator CommitmentPlanProvisioningState(string value) => new CommitmentPlanProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommitmentPlanProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommitmentPlanProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
