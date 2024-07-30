// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The state of the  ExpressRoute Circuit Authorization provisioning. </summary>
    public readonly partial struct GlobalReachConnectionProvisioningState : IEquatable<GlobalReachConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GlobalReachConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GlobalReachConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static GlobalReachConnectionProvisioningState Succeeded { get; } = new GlobalReachConnectionProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static GlobalReachConnectionProvisioningState Failed { get; } = new GlobalReachConnectionProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static GlobalReachConnectionProvisioningState Updating { get; } = new GlobalReachConnectionProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static GlobalReachConnectionProvisioningState Canceled { get; } = new GlobalReachConnectionProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="GlobalReachConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(GlobalReachConnectionProvisioningState left, GlobalReachConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GlobalReachConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(GlobalReachConnectionProvisioningState left, GlobalReachConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GlobalReachConnectionProvisioningState"/>. </summary>
        public static implicit operator GlobalReachConnectionProvisioningState(string value) => new GlobalReachConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GlobalReachConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GlobalReachConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
