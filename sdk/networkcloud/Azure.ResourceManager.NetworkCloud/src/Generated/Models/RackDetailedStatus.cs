// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the rack. </summary>
    public readonly partial struct RackDetailedStatus : IEquatable<RackDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RackDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RackDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static RackDetailedStatus Error { get; } = new RackDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static RackDetailedStatus Available { get; } = new RackDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static RackDetailedStatus Provisioning { get; } = new RackDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="RackDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(RackDetailedStatus left, RackDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RackDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(RackDetailedStatus left, RackDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RackDetailedStatus"/>. </summary>
        public static implicit operator RackDetailedStatus(string value) => new RackDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RackDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RackDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
