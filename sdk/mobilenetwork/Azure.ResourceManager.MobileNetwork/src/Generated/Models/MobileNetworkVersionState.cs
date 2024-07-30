// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The state of this packet core control plane version. </summary>
    public readonly partial struct MobileNetworkVersionState : IEquatable<MobileNetworkVersionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkVersionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MobileNetworkVersionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string PreviewValue = "Preview";
        private const string ValidatingValue = "Validating";
        private const string ValidationFailedValue = "ValidationFailed";
        private const string ActiveValue = "Active";
        private const string DeprecatedValue = "Deprecated";

        /// <summary> The state of this version is unknown. </summary>
        public static MobileNetworkVersionState Unknown { get; } = new MobileNetworkVersionState(UnknownValue);
        /// <summary> This version is a preview and is not suitable for production use. </summary>
        public static MobileNetworkVersionState Preview { get; } = new MobileNetworkVersionState(PreviewValue);
        /// <summary> This version is currently being validated. </summary>
        public static MobileNetworkVersionState Validating { get; } = new MobileNetworkVersionState(ValidatingValue);
        /// <summary> This version failed validation. </summary>
        public static MobileNetworkVersionState ValidationFailed { get; } = new MobileNetworkVersionState(ValidationFailedValue);
        /// <summary> This version is active and suitable for production use. </summary>
        public static MobileNetworkVersionState Active { get; } = new MobileNetworkVersionState(ActiveValue);
        /// <summary> This version is deprecated and is no longer supported. </summary>
        public static MobileNetworkVersionState Deprecated { get; } = new MobileNetworkVersionState(DeprecatedValue);
        /// <summary> Determines if two <see cref="MobileNetworkVersionState"/> values are the same. </summary>
        public static bool operator ==(MobileNetworkVersionState left, MobileNetworkVersionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MobileNetworkVersionState"/> values are not the same. </summary>
        public static bool operator !=(MobileNetworkVersionState left, MobileNetworkVersionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MobileNetworkVersionState"/>. </summary>
        public static implicit operator MobileNetworkVersionState(string value) => new MobileNetworkVersionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MobileNetworkVersionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MobileNetworkVersionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
