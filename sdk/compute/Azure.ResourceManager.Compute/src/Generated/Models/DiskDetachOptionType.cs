// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the detach behavior to be used while detaching a disk or which is already in the process of detachment from the virtual machine. Supported values are: **ForceDetach.** detachOption: **ForceDetach** is applicable only for managed data disks. If a previous detachment attempt of the data disk did not complete due to an unexpected failure from the virtual machine and the disk is still not released then use force-detach as a last resort option to detach the disk forcibly from the VM. All writes might not have been flushed when using this detach behavior. **This feature is still in preview** mode and is not supported for VirtualMachineScaleSet. To force-detach a data disk update toBeDetached to 'true' along with setting detachOption: 'ForceDetach'. </summary>
    public readonly partial struct DiskDetachOptionType : IEquatable<DiskDetachOptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskDetachOptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskDetachOptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ForceDetachValue = "ForceDetach";

        /// <summary> ForceDetach. </summary>
        public static DiskDetachOptionType ForceDetach { get; } = new DiskDetachOptionType(ForceDetachValue);
        /// <summary> Determines if two <see cref="DiskDetachOptionType"/> values are the same. </summary>
        public static bool operator ==(DiskDetachOptionType left, DiskDetachOptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskDetachOptionType"/> values are not the same. </summary>
        public static bool operator !=(DiskDetachOptionType left, DiskDetachOptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskDetachOptionType"/>. </summary>
        public static implicit operator DiskDetachOptionType(string value) => new DiskDetachOptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskDetachOptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskDetachOptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
