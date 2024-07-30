// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct ApiManagementPrivateEndpointServiceConnectionStatus : IEquatable<ApiManagementPrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiManagementPrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiManagementPrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static ApiManagementPrivateEndpointServiceConnectionStatus Pending { get; } = new ApiManagementPrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ApiManagementPrivateEndpointServiceConnectionStatus Approved { get; } = new ApiManagementPrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ApiManagementPrivateEndpointServiceConnectionStatus Rejected { get; } = new ApiManagementPrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="ApiManagementPrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ApiManagementPrivateEndpointServiceConnectionStatus left, ApiManagementPrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiManagementPrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ApiManagementPrivateEndpointServiceConnectionStatus left, ApiManagementPrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApiManagementPrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator ApiManagementPrivateEndpointServiceConnectionStatus(string value) => new ApiManagementPrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiManagementPrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiManagementPrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
