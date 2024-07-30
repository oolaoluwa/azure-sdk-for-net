// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The type of the device model to use. </summary>
    public readonly partial struct VirtualMachineDeviceModelType : IEquatable<VirtualMachineDeviceModelType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineDeviceModelType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineDeviceModelType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string T1Value = "T1";
        private const string T2Value = "T2";

        /// <summary> T1. </summary>
        public static VirtualMachineDeviceModelType T1 { get; } = new VirtualMachineDeviceModelType(T1Value);
        /// <summary> T2. </summary>
        public static VirtualMachineDeviceModelType T2 { get; } = new VirtualMachineDeviceModelType(T2Value);
        /// <summary> Determines if two <see cref="VirtualMachineDeviceModelType"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineDeviceModelType left, VirtualMachineDeviceModelType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineDeviceModelType"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineDeviceModelType left, VirtualMachineDeviceModelType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachineDeviceModelType"/>. </summary>
        public static implicit operator VirtualMachineDeviceModelType(string value) => new VirtualMachineDeviceModelType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineDeviceModelType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineDeviceModelType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
