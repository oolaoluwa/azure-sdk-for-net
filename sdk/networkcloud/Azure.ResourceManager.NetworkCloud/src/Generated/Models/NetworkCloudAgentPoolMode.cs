// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The selection of how this agent pool is utilized, either as a system pool or a user pool. System pools run the features and critical services for the Kubernetes Cluster, while user pools are dedicated to user workloads. Every Kubernetes cluster must contain at least one system node pool with at least one node. </summary>
    public readonly partial struct NetworkCloudAgentPoolMode : IEquatable<NetworkCloudAgentPoolMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudAgentPoolMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkCloudAgentPoolMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemValue = "System";
        private const string UserValue = "User";
        private const string NotApplicableValue = "NotApplicable";

        /// <summary> System. </summary>
        public static NetworkCloudAgentPoolMode System { get; } = new NetworkCloudAgentPoolMode(SystemValue);
        /// <summary> User. </summary>
        public static NetworkCloudAgentPoolMode User { get; } = new NetworkCloudAgentPoolMode(UserValue);
        /// <summary> NotApplicable. </summary>
        public static NetworkCloudAgentPoolMode NotApplicable { get; } = new NetworkCloudAgentPoolMode(NotApplicableValue);
        /// <summary> Determines if two <see cref="NetworkCloudAgentPoolMode"/> values are the same. </summary>
        public static bool operator ==(NetworkCloudAgentPoolMode left, NetworkCloudAgentPoolMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkCloudAgentPoolMode"/> values are not the same. </summary>
        public static bool operator !=(NetworkCloudAgentPoolMode left, NetworkCloudAgentPoolMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkCloudAgentPoolMode"/>. </summary>
        public static implicit operator NetworkCloudAgentPoolMode(string value) => new NetworkCloudAgentPoolMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkCloudAgentPoolMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkCloudAgentPoolMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
