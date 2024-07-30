// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> The reason why the given name is not available. </summary>
    public readonly partial struct CommunicationNameAvailabilityReason : IEquatable<CommunicationNameAvailabilityReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommunicationNameAvailabilityReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommunicationNameAvailabilityReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static CommunicationNameAvailabilityReason Invalid { get; } = new CommunicationNameAvailabilityReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static CommunicationNameAvailabilityReason AlreadyExists { get; } = new CommunicationNameAvailabilityReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="CommunicationNameAvailabilityReason"/> values are the same. </summary>
        public static bool operator ==(CommunicationNameAvailabilityReason left, CommunicationNameAvailabilityReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommunicationNameAvailabilityReason"/> values are not the same. </summary>
        public static bool operator !=(CommunicationNameAvailabilityReason left, CommunicationNameAvailabilityReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommunicationNameAvailabilityReason"/>. </summary>
        public static implicit operator CommunicationNameAvailabilityReason(string value) => new CommunicationNameAvailabilityReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommunicationNameAvailabilityReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommunicationNameAvailabilityReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
