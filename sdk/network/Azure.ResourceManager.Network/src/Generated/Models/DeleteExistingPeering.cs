// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Flag if need to remove current existing peerings. </summary>
    public readonly partial struct DeleteExistingPeering : IEquatable<DeleteExistingPeering>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeleteExistingPeering"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeleteExistingPeering(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FalseValue = "False";
        private const string TrueValue = "True";

        /// <summary> False. </summary>
        public static DeleteExistingPeering False { get; } = new DeleteExistingPeering(FalseValue);
        /// <summary> True. </summary>
        public static DeleteExistingPeering True { get; } = new DeleteExistingPeering(TrueValue);
        /// <summary> Determines if two <see cref="DeleteExistingPeering"/> values are the same. </summary>
        public static bool operator ==(DeleteExistingPeering left, DeleteExistingPeering right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeleteExistingPeering"/> values are not the same. </summary>
        public static bool operator !=(DeleteExistingPeering left, DeleteExistingPeering right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeleteExistingPeering"/>. </summary>
        public static implicit operator DeleteExistingPeering(string value) => new DeleteExistingPeering(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeleteExistingPeering other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeleteExistingPeering other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
