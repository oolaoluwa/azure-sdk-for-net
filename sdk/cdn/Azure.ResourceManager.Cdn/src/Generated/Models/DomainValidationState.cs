// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </summary>
    public readonly partial struct DomainValidationState : IEquatable<DomainValidationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DomainValidationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DomainValidationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SubmittingValue = "Submitting";
        private const string PendingValue = "Pending";
        private const string RejectedValue = "Rejected";
        private const string TimedOutValue = "TimedOut";
        private const string PendingRevalidationValue = "PendingRevalidation";
        private const string ApprovedValue = "Approved";
        private const string RefreshingValidationTokenValue = "RefreshingValidationToken";
        private const string InternalErrorValue = "InternalError";

        /// <summary> Unknown. </summary>
        public static DomainValidationState Unknown { get; } = new DomainValidationState(UnknownValue);
        /// <summary> Submitting. </summary>
        public static DomainValidationState Submitting { get; } = new DomainValidationState(SubmittingValue);
        /// <summary> Pending. </summary>
        public static DomainValidationState Pending { get; } = new DomainValidationState(PendingValue);
        /// <summary> Rejected. </summary>
        public static DomainValidationState Rejected { get; } = new DomainValidationState(RejectedValue);
        /// <summary> TimedOut. </summary>
        public static DomainValidationState TimedOut { get; } = new DomainValidationState(TimedOutValue);
        /// <summary> PendingRevalidation. </summary>
        public static DomainValidationState PendingRevalidation { get; } = new DomainValidationState(PendingRevalidationValue);
        /// <summary> Approved. </summary>
        public static DomainValidationState Approved { get; } = new DomainValidationState(ApprovedValue);
        /// <summary> RefreshingValidationToken. </summary>
        public static DomainValidationState RefreshingValidationToken { get; } = new DomainValidationState(RefreshingValidationTokenValue);
        /// <summary> InternalError. </summary>
        public static DomainValidationState InternalError { get; } = new DomainValidationState(InternalErrorValue);
        /// <summary> Determines if two <see cref="DomainValidationState"/> values are the same. </summary>
        public static bool operator ==(DomainValidationState left, DomainValidationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DomainValidationState"/> values are not the same. </summary>
        public static bool operator !=(DomainValidationState left, DomainValidationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DomainValidationState"/>. </summary>
        public static implicit operator DomainValidationState(string value) => new DomainValidationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DomainValidationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DomainValidationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
