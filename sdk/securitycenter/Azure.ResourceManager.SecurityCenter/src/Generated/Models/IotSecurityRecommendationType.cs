// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The type of IoT Security recommendation. </summary>
    public readonly partial struct IotSecurityRecommendationType : IEquatable<IotSecurityRecommendationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotSecurityRecommendationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotSecurityRecommendationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IotAcrAuthenticationValue = "IoT_ACRAuthentication";
        private const string IotAgentSendsUnutilizedMessagesValue = "IoT_AgentSendsUnutilizedMessages";
        private const string IotBaselineValue = "IoT_Baseline";
        private const string IotEdgeHubMemOptimizeValue = "IoT_EdgeHubMemOptimize";
        private const string IotEdgeLoggingOptionsValue = "IoT_EdgeLoggingOptions";
        private const string IotInconsistentModuleSettingsValue = "IoT_InconsistentModuleSettings";
        private const string IotInstallAgentValue = "IoT_InstallAgent";
        private const string IotIPFilterDenyAllValue = "IoT_IPFilter_DenyAll";
        private const string IotIPFilterPermissiveRuleValue = "IoT_IPFilter_PermissiveRule";
        private const string IotOpenPortsValue = "IoT_OpenPorts";
        private const string IotPermissiveFirewallPolicyValue = "IoT_PermissiveFirewallPolicy";
        private const string IotPermissiveInputFirewallRulesValue = "IoT_PermissiveInputFirewallRules";
        private const string IotPermissiveOutputFirewallRulesValue = "IoT_PermissiveOutputFirewallRules";
        private const string IotPrivilegedDockerOptionsValue = "IoT_PrivilegedDockerOptions";
        private const string IotSharedCredentialsValue = "IoT_SharedCredentials";
        private const string IotVulnerableTlsCipherSuiteValue = "IoT_VulnerableTLSCipherSuite";

        /// <summary> Authentication schema used for pull an edge module from an ACR repository does not use Service Principal Authentication. </summary>
        public static IotSecurityRecommendationType IotAcrAuthentication { get; } = new IotSecurityRecommendationType(IotAcrAuthenticationValue);
        /// <summary> IoT agent message size capacity is currently underutilized, causing an increase in the number of sent messages. Adjust message intervals for better utilization. </summary>
        public static IotSecurityRecommendationType IotAgentSendsUnutilizedMessages { get; } = new IotSecurityRecommendationType(IotAgentSendsUnutilizedMessagesValue);
        /// <summary> Identified security related system configuration issues. </summary>
        public static IotSecurityRecommendationType IotBaseline { get; } = new IotSecurityRecommendationType(IotBaselineValue);
        /// <summary> You can optimize Edge Hub memory usage by turning off protocol heads for any protocols not used by Edge modules in your solution. </summary>
        public static IotSecurityRecommendationType IotEdgeHubMemOptimize { get; } = new IotSecurityRecommendationType(IotEdgeHubMemOptimizeValue);
        /// <summary> Logging is disabled for this edge module. </summary>
        public static IotSecurityRecommendationType IotEdgeLoggingOptions { get; } = new IotSecurityRecommendationType(IotEdgeLoggingOptionsValue);
        /// <summary> A minority within a device security group has inconsistent Edge Module settings with the rest of their group. </summary>
        public static IotSecurityRecommendationType IotInconsistentModuleSettings { get; } = new IotSecurityRecommendationType(IotInconsistentModuleSettingsValue);
        /// <summary> Install the Azure Security of Things Agent. </summary>
        public static IotSecurityRecommendationType IotInstallAgent { get; } = new IotSecurityRecommendationType(IotInstallAgentValue);
        /// <summary> IP Filter Configuration should have rules defined for allowed traffic and should deny all other traffic by default. </summary>
        public static IotSecurityRecommendationType IotIPFilterDenyAll { get; } = new IotSecurityRecommendationType(IotIPFilterDenyAllValue);
        /// <summary> An Allow IP Filter rules source IP range is too large. Overly permissive rules might expose your IoT hub to malicious intenders. </summary>
        public static IotSecurityRecommendationType IotIPFilterPermissiveRule { get; } = new IotSecurityRecommendationType(IotIPFilterPermissiveRuleValue);
        /// <summary> A listening endpoint was found on the device. </summary>
        public static IotSecurityRecommendationType IotOpenPorts { get; } = new IotSecurityRecommendationType(IotOpenPortsValue);
        /// <summary> An Allowed firewall policy was found (INPUT/OUTPUT). The policy should Deny all traffic by default and define rules to allow necessary communication to/from the device. </summary>
        public static IotSecurityRecommendationType IotPermissiveFirewallPolicy { get; } = new IotSecurityRecommendationType(IotPermissiveFirewallPolicyValue);
        /// <summary> A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports. </summary>
        public static IotSecurityRecommendationType IotPermissiveInputFirewallRules { get; } = new IotSecurityRecommendationType(IotPermissiveInputFirewallRulesValue);
        /// <summary> A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports. </summary>
        public static IotSecurityRecommendationType IotPermissiveOutputFirewallRules { get; } = new IotSecurityRecommendationType(IotPermissiveOutputFirewallRulesValue);
        /// <summary> Edge module is configured to run in privileged mode, with extensive Linux capabilities or with host-level network access (send/receive data to host machine). </summary>
        public static IotSecurityRecommendationType IotPrivilegedDockerOptions { get; } = new IotSecurityRecommendationType(IotPrivilegedDockerOptionsValue);
        /// <summary> Same authentication credentials to the IoT Hub used by multiple devices. This could indicate an illegitimate device impersonating a legitimate device. It also exposes the risk of device impersonation by an attacker. </summary>
        public static IotSecurityRecommendationType IotSharedCredentials { get; } = new IotSecurityRecommendationType(IotSharedCredentialsValue);
        /// <summary> Insecure TLS configurations detected. Immediate upgrade recommended. </summary>
        public static IotSecurityRecommendationType IotVulnerableTlsCipherSuite { get; } = new IotSecurityRecommendationType(IotVulnerableTlsCipherSuiteValue);
        /// <summary> Determines if two <see cref="IotSecurityRecommendationType"/> values are the same. </summary>
        public static bool operator ==(IotSecurityRecommendationType left, IotSecurityRecommendationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotSecurityRecommendationType"/> values are not the same. </summary>
        public static bool operator !=(IotSecurityRecommendationType left, IotSecurityRecommendationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IotSecurityRecommendationType"/>. </summary>
        public static implicit operator IotSecurityRecommendationType(string value) => new IotSecurityRecommendationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotSecurityRecommendationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotSecurityRecommendationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
