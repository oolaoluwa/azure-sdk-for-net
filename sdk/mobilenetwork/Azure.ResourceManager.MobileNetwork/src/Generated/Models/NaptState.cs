// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Whether network address and port translation is enabled. </summary>
    public readonly partial struct NaptState : IEquatable<NaptState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NaptState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NaptState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> NAPT is enabled. </summary>
        public static NaptState Enabled { get; } = new NaptState(EnabledValue);
        /// <summary> NAPT is disabled. </summary>
        public static NaptState Disabled { get; } = new NaptState(DisabledValue);
        /// <summary> Determines if two <see cref="NaptState"/> values are the same. </summary>
        public static bool operator ==(NaptState left, NaptState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NaptState"/> values are not the same. </summary>
        public static bool operator !=(NaptState left, NaptState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NaptState"/>. </summary>
        public static implicit operator NaptState(string value) => new NaptState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NaptState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NaptState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
