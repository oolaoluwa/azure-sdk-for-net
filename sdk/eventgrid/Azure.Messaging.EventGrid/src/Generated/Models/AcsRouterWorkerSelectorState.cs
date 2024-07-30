// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Router Job Worker Selector State. </summary>
    public readonly partial struct AcsRouterWorkerSelectorState : IEquatable<AcsRouterWorkerSelectorState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerSelectorState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcsRouterWorkerSelectorState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string ExpiredValue = "expired";

        /// <summary> Router Job Worker Selector is Active. </summary>
        public static AcsRouterWorkerSelectorState Active { get; } = new AcsRouterWorkerSelectorState(ActiveValue);
        /// <summary> Router Job Worker Selector has Expire. </summary>
        public static AcsRouterWorkerSelectorState Expired { get; } = new AcsRouterWorkerSelectorState(ExpiredValue);
        /// <summary> Determines if two <see cref="AcsRouterWorkerSelectorState"/> values are the same. </summary>
        public static bool operator ==(AcsRouterWorkerSelectorState left, AcsRouterWorkerSelectorState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcsRouterWorkerSelectorState"/> values are not the same. </summary>
        public static bool operator !=(AcsRouterWorkerSelectorState left, AcsRouterWorkerSelectorState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AcsRouterWorkerSelectorState"/>. </summary>
        public static implicit operator AcsRouterWorkerSelectorState(string value) => new AcsRouterWorkerSelectorState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcsRouterWorkerSelectorState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcsRouterWorkerSelectorState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
