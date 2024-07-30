// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    /// <summary> The state of the UpdateRun, UpdateStage, UpdateGroup, or MemberUpdate. </summary>
    public readonly partial struct ContainerServiceFleetUpdateState : IEquatable<ContainerServiceFleetUpdateState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceFleetUpdateState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceFleetUpdateState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string SkippedValue = "Skipped";
        private const string FailedValue = "Failed";
        private const string CompletedValue = "Completed";

        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that has not been started. </summary>
        public static ContainerServiceFleetUpdateState NotStarted { get; } = new ContainerServiceFleetUpdateState(NotStartedValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that is running. </summary>
        public static ContainerServiceFleetUpdateState Running { get; } = new ContainerServiceFleetUpdateState(RunningValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that is being stopped. </summary>
        public static ContainerServiceFleetUpdateState Stopping { get; } = new ContainerServiceFleetUpdateState(StoppingValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that has stopped. </summary>
        public static ContainerServiceFleetUpdateState Stopped { get; } = new ContainerServiceFleetUpdateState(StoppedValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that has been skipped. </summary>
        public static ContainerServiceFleetUpdateState Skipped { get; } = new ContainerServiceFleetUpdateState(SkippedValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that has failed. </summary>
        public static ContainerServiceFleetUpdateState Failed { get; } = new ContainerServiceFleetUpdateState(FailedValue);
        /// <summary> The state of an UpdateRun/UpdateStage/UpdateGroup/MemberUpdate that has completed. </summary>
        public static ContainerServiceFleetUpdateState Completed { get; } = new ContainerServiceFleetUpdateState(CompletedValue);
        /// <summary> Determines if two <see cref="ContainerServiceFleetUpdateState"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceFleetUpdateState left, ContainerServiceFleetUpdateState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceFleetUpdateState"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceFleetUpdateState left, ContainerServiceFleetUpdateState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerServiceFleetUpdateState"/>. </summary>
        public static implicit operator ContainerServiceFleetUpdateState(string value) => new ContainerServiceFleetUpdateState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceFleetUpdateState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceFleetUpdateState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
