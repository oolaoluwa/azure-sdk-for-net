// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment network dependency category type. </summary>
    public readonly partial struct IntegrationServiceEnvironmentNetworkDependencyCategoryType : IEquatable<IntegrationServiceEnvironmentNetworkDependencyCategoryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentNetworkDependencyCategoryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationServiceEnvironmentNetworkDependencyCategoryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AzureStorageValue = "AzureStorage";
        private const string AzureManagementValue = "AzureManagement";
        private const string AzureActiveDirectoryValue = "AzureActiveDirectory";
        private const string SslCertificateVerificationValue = "SSLCertificateVerification";
        private const string DiagnosticLogsAndMetricsValue = "DiagnosticLogsAndMetrics";
        private const string IntegrationServiceEnvironmentConnectorsValue = "IntegrationServiceEnvironmentConnectors";
        private const string RedisCacheValue = "RedisCache";
        private const string AccessEndpointsValue = "AccessEndpoints";
        private const string RecoveryServiceValue = "RecoveryService";
        private const string SqlValue = "SQL";
        private const string RegionalServiceValue = "RegionalService";

        /// <summary> NotSpecified. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType NotSpecified { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(NotSpecifiedValue);
        /// <summary> AzureStorage. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType AzureStorage { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(AzureStorageValue);
        /// <summary> AzureManagement. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType AzureManagement { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(AzureManagementValue);
        /// <summary> AzureActiveDirectory. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType AzureActiveDirectory { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(AzureActiveDirectoryValue);
        /// <summary> SSLCertificateVerification. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType SslCertificateVerification { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(SslCertificateVerificationValue);
        /// <summary> DiagnosticLogsAndMetrics. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType DiagnosticLogsAndMetrics { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(DiagnosticLogsAndMetricsValue);
        /// <summary> IntegrationServiceEnvironmentConnectors. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType IntegrationServiceEnvironmentConnectors { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(IntegrationServiceEnvironmentConnectorsValue);
        /// <summary> RedisCache. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType RedisCache { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(RedisCacheValue);
        /// <summary> AccessEndpoints. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType AccessEndpoints { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(AccessEndpointsValue);
        /// <summary> RecoveryService. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType RecoveryService { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(RecoveryServiceValue);
        /// <summary> SQL. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType Sql { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(SqlValue);
        /// <summary> RegionalService. </summary>
        public static IntegrationServiceEnvironmentNetworkDependencyCategoryType RegionalService { get; } = new IntegrationServiceEnvironmentNetworkDependencyCategoryType(RegionalServiceValue);
        /// <summary> Determines if two <see cref="IntegrationServiceEnvironmentNetworkDependencyCategoryType"/> values are the same. </summary>
        public static bool operator ==(IntegrationServiceEnvironmentNetworkDependencyCategoryType left, IntegrationServiceEnvironmentNetworkDependencyCategoryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationServiceEnvironmentNetworkDependencyCategoryType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationServiceEnvironmentNetworkDependencyCategoryType left, IntegrationServiceEnvironmentNetworkDependencyCategoryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationServiceEnvironmentNetworkDependencyCategoryType"/>. </summary>
        public static implicit operator IntegrationServiceEnvironmentNetworkDependencyCategoryType(string value) => new IntegrationServiceEnvironmentNetworkDependencyCategoryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationServiceEnvironmentNetworkDependencyCategoryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationServiceEnvironmentNetworkDependencyCategoryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
