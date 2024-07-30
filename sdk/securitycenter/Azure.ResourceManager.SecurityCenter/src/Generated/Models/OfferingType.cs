// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The type of the security offering. </summary>
    internal readonly partial struct OfferingType : IEquatable<OfferingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OfferingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OfferingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CspmMonitorAwsValue = "CspmMonitorAws";
        private const string DefenderForContainersAwsValue = "DefenderForContainersAws";
        private const string DefenderForServersAwsValue = "DefenderForServersAws";
        private const string DefenderForDatabasesAwsValue = "DefenderForDatabasesAws";
        private const string InformationProtectionAwsValue = "InformationProtectionAws";
        private const string CspmMonitorGcpValue = "CspmMonitorGcp";
        private const string CspmMonitorGithubValue = "CspmMonitorGithub";
        private const string CspmMonitorAzureDevOpsValue = "CspmMonitorAzureDevOps";
        private const string DefenderForServersGcpValue = "DefenderForServersGcp";
        private const string DefenderForContainersGcpValue = "DefenderForContainersGcp";
        private const string DefenderForDatabasesGcpValue = "DefenderForDatabasesGcp";
        private const string DefenderCspmAwsValue = "DefenderCspmAws";
        private const string DefenderCspmGcpValue = "DefenderCspmGcp";
        private const string DefenderForDevOpsGithubValue = "DefenderForDevOpsGithub";
        private const string DefenderForDevOpsAzureDevOpsValue = "DefenderForDevOpsAzureDevOps";
        private const string CspmMonitorGitLabValue = "CspmMonitorGitLab";
        private const string DefenderForDevOpsGitLabValue = "DefenderForDevOpsGitLab";

        /// <summary> CspmMonitorAws. </summary>
        public static OfferingType CspmMonitorAws { get; } = new OfferingType(CspmMonitorAwsValue);
        /// <summary> DefenderForContainersAws. </summary>
        public static OfferingType DefenderForContainersAws { get; } = new OfferingType(DefenderForContainersAwsValue);
        /// <summary> DefenderForServersAws. </summary>
        public static OfferingType DefenderForServersAws { get; } = new OfferingType(DefenderForServersAwsValue);
        /// <summary> DefenderForDatabasesAws. </summary>
        public static OfferingType DefenderForDatabasesAws { get; } = new OfferingType(DefenderForDatabasesAwsValue);
        /// <summary> InformationProtectionAws. </summary>
        public static OfferingType InformationProtectionAws { get; } = new OfferingType(InformationProtectionAwsValue);
        /// <summary> CspmMonitorGcp. </summary>
        public static OfferingType CspmMonitorGcp { get; } = new OfferingType(CspmMonitorGcpValue);
        /// <summary> CspmMonitorGithub. </summary>
        public static OfferingType CspmMonitorGithub { get; } = new OfferingType(CspmMonitorGithubValue);
        /// <summary> CspmMonitorAzureDevOps. </summary>
        public static OfferingType CspmMonitorAzureDevOps { get; } = new OfferingType(CspmMonitorAzureDevOpsValue);
        /// <summary> DefenderForServersGcp. </summary>
        public static OfferingType DefenderForServersGcp { get; } = new OfferingType(DefenderForServersGcpValue);
        /// <summary> DefenderForContainersGcp. </summary>
        public static OfferingType DefenderForContainersGcp { get; } = new OfferingType(DefenderForContainersGcpValue);
        /// <summary> DefenderForDatabasesGcp. </summary>
        public static OfferingType DefenderForDatabasesGcp { get; } = new OfferingType(DefenderForDatabasesGcpValue);
        /// <summary> DefenderCspmAws. </summary>
        public static OfferingType DefenderCspmAws { get; } = new OfferingType(DefenderCspmAwsValue);
        /// <summary> DefenderCspmGcp. </summary>
        public static OfferingType DefenderCspmGcp { get; } = new OfferingType(DefenderCspmGcpValue);
        /// <summary> DefenderForDevOpsGithub. </summary>
        public static OfferingType DefenderForDevOpsGithub { get; } = new OfferingType(DefenderForDevOpsGithubValue);
        /// <summary> DefenderForDevOpsAzureDevOps. </summary>
        public static OfferingType DefenderForDevOpsAzureDevOps { get; } = new OfferingType(DefenderForDevOpsAzureDevOpsValue);
        /// <summary> CspmMonitorGitLab. </summary>
        public static OfferingType CspmMonitorGitLab { get; } = new OfferingType(CspmMonitorGitLabValue);
        /// <summary> DefenderForDevOpsGitLab. </summary>
        public static OfferingType DefenderForDevOpsGitLab { get; } = new OfferingType(DefenderForDevOpsGitLabValue);
        /// <summary> Determines if two <see cref="OfferingType"/> values are the same. </summary>
        public static bool operator ==(OfferingType left, OfferingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OfferingType"/> values are not the same. </summary>
        public static bool operator !=(OfferingType left, OfferingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OfferingType"/>. </summary>
        public static implicit operator OfferingType(string value) => new OfferingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OfferingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OfferingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
