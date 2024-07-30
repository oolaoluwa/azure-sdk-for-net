// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Whether a reinstall of the packet core is required to pick up the latest configuration changes. </summary>
    public readonly partial struct MobileNetworkReinstallRequired : IEquatable<MobileNetworkReinstallRequired>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkReinstallRequired"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkReinstallRequired(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequiredValue = "Required";
        private const string NotRequiredValue = "NotRequired";

        /// <summary> A reinstall of the packet core is required. </summary>
        public static MobileNetworkReinstallRequired Required { get; } = new MobileNetworkReinstallRequired(RequiredValue);
        /// <summary> A reinstall of the packet core is not required. </summary>
        public static MobileNetworkReinstallRequired NotRequired { get; } = new MobileNetworkReinstallRequired(NotRequiredValue);
        /// <summary> Determines if two <see cref="MobileNetworkReinstallRequired"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkReinstallRequired left, MobileNetworkReinstallRequired right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkReinstallRequired"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkReinstallRequired left, MobileNetworkReinstallRequired right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkReinstallRequired"/>. </summary>
        public static implicit operator MobileNetworkReinstallRequired(string value) => new MobileNetworkReinstallRequired(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkReinstallRequired other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkReinstallRequired other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
