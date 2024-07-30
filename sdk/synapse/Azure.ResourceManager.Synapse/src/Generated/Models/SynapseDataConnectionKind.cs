// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Kind of the endpoint for the data connection. </summary>
    internal readonly partial struct SynapseDataConnectionKind : IEquatable<SynapseDataConnectionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseDataConnectionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseDataConnectionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EventHubValue = "EventHub";
        private const string EventGridValue = "EventGrid";
        private const string IotHubValue = "IotHub";

        /// <summary> EventHub. </summary>
        public static SynapseDataConnectionKind EventHub { get; } = new SynapseDataConnectionKind(EventHubValue);
        /// <summary> EventGrid. </summary>
        public static SynapseDataConnectionKind EventGrid { get; } = new SynapseDataConnectionKind(EventGridValue);
        /// <summary> IotHub. </summary>
        public static SynapseDataConnectionKind IotHub { get; } = new SynapseDataConnectionKind(IotHubValue);
        /// <summary> Determines if two <see cref="SynapseDataConnectionKind"/> values are the same. </summary>
        public static bool operator ==(SynapseDataConnectionKind left, SynapseDataConnectionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseDataConnectionKind"/> values are not the same. </summary>
        public static bool operator !=(SynapseDataConnectionKind left, SynapseDataConnectionKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseDataConnectionKind"/>. </summary>
        public static implicit operator SynapseDataConnectionKind(string value) => new SynapseDataConnectionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseDataConnectionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseDataConnectionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
