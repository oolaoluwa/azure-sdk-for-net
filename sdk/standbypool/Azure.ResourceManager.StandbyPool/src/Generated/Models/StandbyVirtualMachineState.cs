// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> State of standby virtual machines. </summary>
    public readonly partial struct StandbyVirtualMachineState : IEquatable<StandbyVirtualMachineState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StandbyVirtualMachineState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StandbyVirtualMachineState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string DeallocatedValue = "Deallocated";

        /// <summary> The virtual machine is up and running. </summary>
        public static StandbyVirtualMachineState Running { get; } = new StandbyVirtualMachineState(RunningValue);
        /// <summary> The virtual machine has released the lease on the underlying hardware and is powered off. </summary>
        public static StandbyVirtualMachineState Deallocated { get; } = new StandbyVirtualMachineState(DeallocatedValue);
        /// <summary> Determines if two <see cref="StandbyVirtualMachineState"/> values are the same. </summary>
        public static bool operator ==(StandbyVirtualMachineState left, StandbyVirtualMachineState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StandbyVirtualMachineState"/> values are not the same. </summary>
        public static bool operator !=(StandbyVirtualMachineState left, StandbyVirtualMachineState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StandbyVirtualMachineState"/>. </summary>
        public static implicit operator StandbyVirtualMachineState(string value) => new StandbyVirtualMachineState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StandbyVirtualMachineState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StandbyVirtualMachineState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
