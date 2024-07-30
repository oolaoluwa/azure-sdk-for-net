// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the Kubernetes cluster resource. </summary>
    public readonly partial struct KubernetesClusterProvisioningState : IEquatable<KubernetesClusterProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesClusterProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string AcceptedValue = "Accepted";
        private const string InProgressValue = "InProgress";
        private const string CreatedValue = "Created";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Succeeded. </summary>
        public static KubernetesClusterProvisioningState Succeeded { get; } = new KubernetesClusterProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static KubernetesClusterProvisioningState Failed { get; } = new KubernetesClusterProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static KubernetesClusterProvisioningState Canceled { get; } = new KubernetesClusterProvisioningState(CanceledValue);
        /// <summary> Accepted. </summary>
        public static KubernetesClusterProvisioningState Accepted { get; } = new KubernetesClusterProvisioningState(AcceptedValue);
        /// <summary> InProgress. </summary>
        public static KubernetesClusterProvisioningState InProgress { get; } = new KubernetesClusterProvisioningState(InProgressValue);
        /// <summary> Created. </summary>
        public static KubernetesClusterProvisioningState Created { get; } = new KubernetesClusterProvisioningState(CreatedValue);
        /// <summary> Updating. </summary>
        public static KubernetesClusterProvisioningState Updating { get; } = new KubernetesClusterProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static KubernetesClusterProvisioningState Deleting { get; } = new KubernetesClusterProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="KubernetesClusterProvisioningState"/> values are the same. </summary>
        public static bool operator ==(KubernetesClusterProvisioningState left, KubernetesClusterProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesClusterProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(KubernetesClusterProvisioningState left, KubernetesClusterProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KubernetesClusterProvisioningState"/>. </summary>
        public static implicit operator KubernetesClusterProvisioningState(string value) => new KubernetesClusterProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesClusterProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesClusterProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
