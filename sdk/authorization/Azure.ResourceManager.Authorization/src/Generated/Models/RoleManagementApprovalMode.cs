// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The type of rule. </summary>
    public readonly partial struct RoleManagementApprovalMode : IEquatable<RoleManagementApprovalMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoleManagementApprovalMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoleManagementApprovalMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleStageValue = "SingleStage";
        private const string SerialValue = "Serial";
        private const string ParallelValue = "Parallel";
        private const string NoApprovalValue = "NoApproval";

        /// <summary> SingleStage. </summary>
        public static RoleManagementApprovalMode SingleStage { get; } = new RoleManagementApprovalMode(SingleStageValue);
        /// <summary> Serial. </summary>
        public static RoleManagementApprovalMode Serial { get; } = new RoleManagementApprovalMode(SerialValue);
        /// <summary> Parallel. </summary>
        public static RoleManagementApprovalMode Parallel { get; } = new RoleManagementApprovalMode(ParallelValue);
        /// <summary> NoApproval. </summary>
        public static RoleManagementApprovalMode NoApproval { get; } = new RoleManagementApprovalMode(NoApprovalValue);
        /// <summary> Determines if two <see cref="RoleManagementApprovalMode"/> values are the same. </summary>
        public static bool operator ==(RoleManagementApprovalMode left, RoleManagementApprovalMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoleManagementApprovalMode"/> values are not the same. </summary>
        public static bool operator !=(RoleManagementApprovalMode left, RoleManagementApprovalMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoleManagementApprovalMode"/>. </summary>
        public static implicit operator RoleManagementApprovalMode(string value) => new RoleManagementApprovalMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoleManagementApprovalMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoleManagementApprovalMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
