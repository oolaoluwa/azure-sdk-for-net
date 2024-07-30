// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents the name of the health check operation performed. </summary>
    public readonly partial struct SessionHostHealthCheckName : IEquatable<SessionHostHealthCheckName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionHostHealthCheckName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionHostHealthCheckName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainJoinedCheckValue = "DomainJoinedCheck";
        private const string DomainTrustCheckValue = "DomainTrustCheck";
        private const string FSLogixHealthCheckValue = "FSLogixHealthCheck";
        private const string SxsStackListenerCheckValue = "SxSStackListenerCheck";
        private const string UrlsAccessibleCheckValue = "UrlsAccessibleCheck";
        private const string MonitoringAgentCheckValue = "MonitoringAgentCheck";
        private const string DomainReachableValue = "DomainReachable";
        private const string WebRtcRedirectorCheckValue = "WebRTCRedirectorCheck";
        private const string SupportedEncryptionCheckValue = "SupportedEncryptionCheck";
        private const string MetaDataServiceCheckValue = "MetaDataServiceCheck";
        private const string AppAttachHealthCheckValue = "AppAttachHealthCheck";

        /// <summary> Verifies the SessionHost is joined to a domain. If this check fails is classified as fatal as no connection can succeed if the SessionHost is not joined to the domain. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName DomainJoinedCheck { get; } = new SessionHostHealthCheckName(DomainJoinedCheckValue);
        /// <summary> Verifies the SessionHost is not experiencing domain trust issues that will prevent authentication on SessionHost at connection time when session is created. If this check fails is classified as fatal as no connection can succeed if we cannot reach the domain for authentication on the SessionHost. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName DomainTrustCheck { get; } = new SessionHostHealthCheckName(DomainTrustCheckValue);
        /// <summary> Verifies the FSLogix service is up and running to make sure users' profiles are loaded in the session. If this check fails is classified as fatal as even if the connection can succeed, user experience is bad as the user profile cannot be loaded and user will get a temporary profile in the session. (Currently Disabled). </summary>
        public static SessionHostHealthCheckName FSLogixHealthCheck { get; } = new SessionHostHealthCheckName(FSLogixHealthCheckValue);
        /// <summary> Verifies that the SxS stack is up and running so connections can succeed. If this check fails is classified as fatal as no connection can succeed if the SxS stack is not ready. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName SxsStackListenerCheck { get; } = new SessionHostHealthCheckName(SxsStackListenerCheckValue);
        /// <summary> Verifies that the required WVD service and Geneva URLs are reachable from the SessionHost. These URLs are: RdTokenUri, RdBrokerURI, RdDiagnosticsUri and storage blob URLs for agent monitoring (geneva). If this check fails, it is non fatal and the machine still can service connections, main issue may be that monitoring agent is unable to store warm path data (logs, operations ...). (Currently Disabled). </summary>
        public static SessionHostHealthCheckName UrlsAccessibleCheck { get; } = new SessionHostHealthCheckName(UrlsAccessibleCheckValue);
        /// <summary> Verifies that the required Geneva agent is running. If this check fails, it is non fatal and the machine still can service connections, main issue may be that monitoring agent is missing or running (possibly) older version. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName MonitoringAgentCheck { get; } = new SessionHostHealthCheckName(MonitoringAgentCheckValue);
        /// <summary> Verifies the domain the SessionHost is joined to is still reachable. If this check fails is classified as fatal as no connection can succeed if the domain the SessionHost is joined is not reachable at the time of connection. (Currently Disabled). </summary>
        public static SessionHostHealthCheckName DomainReachable { get; } = new SessionHostHealthCheckName(DomainReachableValue);
        /// <summary> Verifies whether the WebRTCRedirector component is healthy. The WebRTCRedirector component is used to optimize video and audio performance in Microsoft Teams. This checks whether the component is still running, and whether there is a higher version available. If this check fails, it is non fatal and the machine still can service connections, main issue may be the WebRTCRedirector component has to be restarted or updated. (Currently Disabled). </summary>
        public static SessionHostHealthCheckName WebRtcRedirectorCheck { get; } = new SessionHostHealthCheckName(WebRtcRedirectorCheckValue);
        /// <summary> Verifies the value of SecurityLayer registration key. If the value is 0 (SecurityLayer.RDP) this check fails with Error code = NativeMethodErrorCode.E_FAIL and is fatal. If the value is 1 (SecurityLayer.Negotiate) this check fails with Error code = NativeMethodErrorCode.ERROR_SUCCESS and is non fatal. (Currently Disabled). </summary>
        public static SessionHostHealthCheckName SupportedEncryptionCheck { get; } = new SessionHostHealthCheckName(SupportedEncryptionCheckValue);
        /// <summary> Verifies the metadata service is accessible and return compute properties. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName MetaDataServiceCheck { get; } = new SessionHostHealthCheckName(MetaDataServiceCheckValue);
        /// <summary> Verifies that the AppAttachService is healthy (there were no issues during package staging). The AppAttachService is used to enable the staging/registration (and eventual deregistration/destaging) of MSIX apps that have been set up by the tenant admin. This checks whether the component had any failures during package staging. Failures in staging will prevent some MSIX apps from working properly for the end user. If this check fails, it is non fatal and the machine still can service connections, main issue may be certain apps will not work for end-users. (Currently Enabled). </summary>
        public static SessionHostHealthCheckName AppAttachHealthCheck { get; } = new SessionHostHealthCheckName(AppAttachHealthCheckValue);
        /// <summary> Determines if two <see cref="SessionHostHealthCheckName"/> values are the same. </summary>
        public static bool operator ==(SessionHostHealthCheckName left, SessionHostHealthCheckName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionHostHealthCheckName"/> values are not the same. </summary>
        public static bool operator !=(SessionHostHealthCheckName left, SessionHostHealthCheckName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SessionHostHealthCheckName"/>. </summary>
        public static implicit operator SessionHostHealthCheckName(string value) => new SessionHostHealthCheckName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionHostHealthCheckName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionHostHealthCheckName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
