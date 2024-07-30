// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The risk level of the threat that was detected. Learn more: https://docs.microsoft.com/en-us/azure/security-center/security-center-alerts-overview#how-are-alerts-classified. </summary>
    public readonly partial struct SecurityAlertSeverity : IEquatable<SecurityAlertSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAlertSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InformationalValue = "Informational";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Informational. </summary>
        public static SecurityAlertSeverity Informational { get; } = new SecurityAlertSeverity(InformationalValue);
        /// <summary> Low. </summary>
        public static SecurityAlertSeverity Low { get; } = new SecurityAlertSeverity(LowValue);
        /// <summary> Medium. </summary>
        public static SecurityAlertSeverity Medium { get; } = new SecurityAlertSeverity(MediumValue);
        /// <summary> High. </summary>
        public static SecurityAlertSeverity High { get; } = new SecurityAlertSeverity(HighValue);
        /// <summary> Determines if two <see cref="SecurityAlertSeverity"/> values are the same. </summary>
        public static bool operator ==(SecurityAlertSeverity left, SecurityAlertSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAlertSeverity"/> values are not the same. </summary>
        public static bool operator !=(SecurityAlertSeverity left, SecurityAlertSeverity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityAlertSeverity"/>. </summary>
        public static implicit operator SecurityAlertSeverity(string value) => new SecurityAlertSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAlertSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAlertSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
