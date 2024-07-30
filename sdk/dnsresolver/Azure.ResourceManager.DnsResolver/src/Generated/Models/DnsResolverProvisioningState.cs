// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The current provisioning state of the resource. </summary>
    public readonly partial struct DnsResolverProvisioningState : IEquatable<DnsResolverProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DnsResolverProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DnsResolverProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static DnsResolverProvisioningState Creating { get; } = new DnsResolverProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static DnsResolverProvisioningState Updating { get; } = new DnsResolverProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static DnsResolverProvisioningState Deleting { get; } = new DnsResolverProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static DnsResolverProvisioningState Succeeded { get; } = new DnsResolverProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static DnsResolverProvisioningState Failed { get; } = new DnsResolverProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static DnsResolverProvisioningState Canceled { get; } = new DnsResolverProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="DnsResolverProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DnsResolverProvisioningState left, DnsResolverProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DnsResolverProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DnsResolverProvisioningState left, DnsResolverProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DnsResolverProvisioningState"/>. </summary>
        public static implicit operator DnsResolverProvisioningState(string value) => new DnsResolverProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DnsResolverProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DnsResolverProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
