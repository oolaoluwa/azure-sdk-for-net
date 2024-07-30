// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The sharing state of the gallery, which only appears in the response. </summary>
    public readonly partial struct SharingState : IEquatable<SharingState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SharingState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SharingState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string InProgressValue = "InProgress";
        private const string FailedValue = "Failed";
        private const string UnknownValue = "Unknown";

        /// <summary> Succeeded. </summary>
        public static SharingState Succeeded { get; } = new SharingState(SucceededValue);
        /// <summary> InProgress. </summary>
        public static SharingState InProgress { get; } = new SharingState(InProgressValue);
        /// <summary> Failed. </summary>
        public static SharingState Failed { get; } = new SharingState(FailedValue);
        /// <summary> Unknown. </summary>
        public static SharingState Unknown { get; } = new SharingState(UnknownValue);
        /// <summary> Determines if two <see cref="SharingState"/> values are the same. </summary>
        public static bool operator ==(SharingState left, SharingState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SharingState"/> values are not the same. </summary>
        public static bool operator !=(SharingState left, SharingState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SharingState"/>. </summary>
        public static implicit operator SharingState(string value) => new SharingState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SharingState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SharingState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
