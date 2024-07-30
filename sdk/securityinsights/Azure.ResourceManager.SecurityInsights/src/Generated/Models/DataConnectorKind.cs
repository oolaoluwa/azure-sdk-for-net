// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the data connector. </summary>
    internal readonly partial struct DataConnectorKind : IEquatable<DataConnectorKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectorKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectorKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureActiveDirectoryValue = "AzureActiveDirectory";
        private const string AzureSecurityCenterValue = "AzureSecurityCenter";
        private const string MicrosoftCloudAppSecurityValue = "MicrosoftCloudAppSecurity";
        private const string ThreatIntelligenceValue = "ThreatIntelligence";
        private const string Office365Value = "Office365";
        private const string AmazonWebServicesCloudTrailValue = "AmazonWebServicesCloudTrail";
        private const string AzureAdvancedThreatProtectionValue = "AzureAdvancedThreatProtection";
        private const string MicrosoftDefenderAdvancedThreatProtectionValue = "MicrosoftDefenderAdvancedThreatProtection";

        /// <summary> AzureActiveDirectory. </summary>
        public static DataConnectorKind AzureActiveDirectory { get; } = new DataConnectorKind(AzureActiveDirectoryValue);
        /// <summary> AzureSecurityCenter. </summary>
        public static DataConnectorKind AzureSecurityCenter { get; } = new DataConnectorKind(AzureSecurityCenterValue);
        /// <summary> MicrosoftCloudAppSecurity. </summary>
        public static DataConnectorKind MicrosoftCloudAppSecurity { get; } = new DataConnectorKind(MicrosoftCloudAppSecurityValue);
        /// <summary> ThreatIntelligence. </summary>
        public static DataConnectorKind ThreatIntelligence { get; } = new DataConnectorKind(ThreatIntelligenceValue);
        /// <summary> Office365. </summary>
        public static DataConnectorKind Office365 { get; } = new DataConnectorKind(Office365Value);
        /// <summary> AmazonWebServicesCloudTrail. </summary>
        public static DataConnectorKind AmazonWebServicesCloudTrail { get; } = new DataConnectorKind(AmazonWebServicesCloudTrailValue);
        /// <summary> AzureAdvancedThreatProtection. </summary>
        public static DataConnectorKind AzureAdvancedThreatProtection { get; } = new DataConnectorKind(AzureAdvancedThreatProtectionValue);
        /// <summary> MicrosoftDefenderAdvancedThreatProtection. </summary>
        public static DataConnectorKind MicrosoftDefenderAdvancedThreatProtection { get; } = new DataConnectorKind(MicrosoftDefenderAdvancedThreatProtectionValue);
        /// <summary> Determines if two <see cref="DataConnectorKind"/> values are the same. </summary>
        public static bool operator ==(DataConnectorKind left, DataConnectorKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectorKind"/> values are not the same. </summary>
        public static bool operator !=(DataConnectorKind left, DataConnectorKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataConnectorKind"/>. </summary>
        public static implicit operator DataConnectorKind(string value) => new DataConnectorKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectorKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectorKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
