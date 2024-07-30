// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Application Group Policy types. </summary>
    internal readonly partial struct ApplicationGroupPolicyType : IEquatable<ApplicationGroupPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGroupPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGroupPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThrottlingPolicyValue = "ThrottlingPolicy";

        /// <summary> ThrottlingPolicy. </summary>
        public static ApplicationGroupPolicyType ThrottlingPolicy { get; } = new ApplicationGroupPolicyType(ThrottlingPolicyValue);
        /// <summary> Determines if two <see cref="ApplicationGroupPolicyType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGroupPolicyType left, ApplicationGroupPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGroupPolicyType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGroupPolicyType left, ApplicationGroupPolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGroupPolicyType"/>. </summary>
        public static implicit operator ApplicationGroupPolicyType(string value) => new ApplicationGroupPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGroupPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGroupPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
