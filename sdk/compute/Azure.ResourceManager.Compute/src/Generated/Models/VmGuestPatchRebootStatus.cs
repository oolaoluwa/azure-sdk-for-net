// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The reboot state of the VM following completion of the operation. </summary>
    public readonly partial struct VmGuestPatchRebootStatus : IEquatable<VmGuestPatchRebootStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmGuestPatchRebootStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmGuestPatchRebootStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NotNeededValue = "NotNeeded";
        private const string RequiredValue = "Required";
        private const string StartedValue = "Started";
        private const string FailedValue = "Failed";
        private const string CompletedValue = "Completed";

        /// <summary> Unknown. </summary>
        public static VmGuestPatchRebootStatus Unknown { get; } = new VmGuestPatchRebootStatus(UnknownValue);
        /// <summary> NotNeeded. </summary>
        public static VmGuestPatchRebootStatus NotNeeded { get; } = new VmGuestPatchRebootStatus(NotNeededValue);
        /// <summary> Required. </summary>
        public static VmGuestPatchRebootStatus Required { get; } = new VmGuestPatchRebootStatus(RequiredValue);
        /// <summary> Started. </summary>
        public static VmGuestPatchRebootStatus Started { get; } = new VmGuestPatchRebootStatus(StartedValue);
        /// <summary> Failed. </summary>
        public static VmGuestPatchRebootStatus Failed { get; } = new VmGuestPatchRebootStatus(FailedValue);
        /// <summary> Completed. </summary>
        public static VmGuestPatchRebootStatus Completed { get; } = new VmGuestPatchRebootStatus(CompletedValue);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootStatus"/> values are the same. </summary>
        public static bool operator ==(VmGuestPatchRebootStatus left, VmGuestPatchRebootStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootStatus"/> values are not the same. </summary>
        public static bool operator !=(VmGuestPatchRebootStatus left, VmGuestPatchRebootStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmGuestPatchRebootStatus"/>. </summary>
        public static implicit operator VmGuestPatchRebootStatus(string value) => new VmGuestPatchRebootStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmGuestPatchRebootStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmGuestPatchRebootStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
