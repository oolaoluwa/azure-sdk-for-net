// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Defines when it is acceptable to reboot a VM during a software update operation. </summary>
    public readonly partial struct VmGuestPatchRebootSetting : IEquatable<VmGuestPatchRebootSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmGuestPatchRebootSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmGuestPatchRebootSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IfRequiredValue = "IfRequired";
        private const string NeverValue = "Never";
        private const string AlwaysValue = "Always";

        /// <summary> IfRequired. </summary>
        public static VmGuestPatchRebootSetting IfRequired { get; } = new VmGuestPatchRebootSetting(IfRequiredValue);
        /// <summary> Never. </summary>
        public static VmGuestPatchRebootSetting Never { get; } = new VmGuestPatchRebootSetting(NeverValue);
        /// <summary> Always. </summary>
        public static VmGuestPatchRebootSetting Always { get; } = new VmGuestPatchRebootSetting(AlwaysValue);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootSetting"/> values are the same. </summary>
        public static bool operator ==(VmGuestPatchRebootSetting left, VmGuestPatchRebootSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmGuestPatchRebootSetting"/> values are not the same. </summary>
        public static bool operator !=(VmGuestPatchRebootSetting left, VmGuestPatchRebootSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmGuestPatchRebootSetting"/>. </summary>
        public static implicit operator VmGuestPatchRebootSetting(string value) => new VmGuestPatchRebootSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmGuestPatchRebootSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmGuestPatchRebootSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
