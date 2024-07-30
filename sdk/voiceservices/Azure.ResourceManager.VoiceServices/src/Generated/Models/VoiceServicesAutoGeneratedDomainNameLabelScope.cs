// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> Available auto-generated domain name scopes. </summary>
    public readonly partial struct VoiceServicesAutoGeneratedDomainNameLabelScope : IEquatable<VoiceServicesAutoGeneratedDomainNameLabelScope>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VoiceServicesAutoGeneratedDomainNameLabelScope"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VoiceServicesAutoGeneratedDomainNameLabelScope(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TenantReuseValue = "TenantReuse";
        private const string SubscriptionReuseValue = "SubscriptionReuse";
        private const string ResourceGroupReuseValue = "ResourceGroupReuse";
        private const string NoReuseValue = "NoReuse";

        /// <summary> TenantReuse. </summary>
        public static VoiceServicesAutoGeneratedDomainNameLabelScope TenantReuse { get; } = new VoiceServicesAutoGeneratedDomainNameLabelScope(TenantReuseValue);
        /// <summary> SubscriptionReuse. </summary>
        public static VoiceServicesAutoGeneratedDomainNameLabelScope SubscriptionReuse { get; } = new VoiceServicesAutoGeneratedDomainNameLabelScope(SubscriptionReuseValue);
        /// <summary> ResourceGroupReuse. </summary>
        public static VoiceServicesAutoGeneratedDomainNameLabelScope ResourceGroupReuse { get; } = new VoiceServicesAutoGeneratedDomainNameLabelScope(ResourceGroupReuseValue);
        /// <summary> NoReuse. </summary>
        public static VoiceServicesAutoGeneratedDomainNameLabelScope NoReuse { get; } = new VoiceServicesAutoGeneratedDomainNameLabelScope(NoReuseValue);
        /// <summary> Determines if two <see cref="VoiceServicesAutoGeneratedDomainNameLabelScope"/> values are the same. </summary>
        public static bool operator ==(VoiceServicesAutoGeneratedDomainNameLabelScope left, VoiceServicesAutoGeneratedDomainNameLabelScope right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VoiceServicesAutoGeneratedDomainNameLabelScope"/> values are not the same. </summary>
        public static bool operator !=(VoiceServicesAutoGeneratedDomainNameLabelScope left, VoiceServicesAutoGeneratedDomainNameLabelScope right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VoiceServicesAutoGeneratedDomainNameLabelScope"/>. </summary>
        public static implicit operator VoiceServicesAutoGeneratedDomainNameLabelScope(string value) => new VoiceServicesAutoGeneratedDomainNameLabelScope(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VoiceServicesAutoGeneratedDomainNameLabelScope other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VoiceServicesAutoGeneratedDomainNameLabelScope other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
