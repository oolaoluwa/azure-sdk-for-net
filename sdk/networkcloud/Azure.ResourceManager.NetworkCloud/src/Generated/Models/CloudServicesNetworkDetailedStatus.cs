// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the cloud services network. </summary>
    public readonly partial struct CloudServicesNetworkDetailedStatus : IEquatable<CloudServicesNetworkDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudServicesNetworkDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudServicesNetworkDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Error. </summary>
        public static CloudServicesNetworkDetailedStatus Error { get; } = new CloudServicesNetworkDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static CloudServicesNetworkDetailedStatus Available { get; } = new CloudServicesNetworkDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static CloudServicesNetworkDetailedStatus Provisioning { get; } = new CloudServicesNetworkDetailedStatus(ProvisioningValue);
        /// <summary> Determines if two <see cref="CloudServicesNetworkDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(CloudServicesNetworkDetailedStatus left, CloudServicesNetworkDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudServicesNetworkDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(CloudServicesNetworkDetailedStatus left, CloudServicesNetworkDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudServicesNetworkDetailedStatus"/>. </summary>
        public static implicit operator CloudServicesNetworkDetailedStatus(string value) => new CloudServicesNetworkDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudServicesNetworkDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudServicesNetworkDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
