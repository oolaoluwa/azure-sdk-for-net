// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// Contact Point Use
    /// See: 	http://hl7.org/fhir/ValueSet/contact-point-use
    /// </summary>
    public readonly partial struct ContactPointUse : IEquatable<ContactPointUse>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContactPointUse"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContactPointUse(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HomeValue = "home";
        private const string WorkValue = "work";
        private const string TempValue = "temp";
        private const string OldValue = "old";
        private const string MobileValue = "mobile";

        /// <summary> Home. </summary>
        public static ContactPointUse Home { get; } = new ContactPointUse(HomeValue);
        /// <summary> Work. </summary>
        public static ContactPointUse Work { get; } = new ContactPointUse(WorkValue);
        /// <summary> Temp. </summary>
        public static ContactPointUse Temp { get; } = new ContactPointUse(TempValue);
        /// <summary> Old. </summary>
        public static ContactPointUse Old { get; } = new ContactPointUse(OldValue);
        /// <summary> Mobile. </summary>
        public static ContactPointUse Mobile { get; } = new ContactPointUse(MobileValue);
        /// <summary> Determines if two <see cref="ContactPointUse"/> values are the same. </summary>
        public static bool operator ==(ContactPointUse left, ContactPointUse right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContactPointUse"/> values are not the same. </summary>
        public static bool operator !=(ContactPointUse left, ContactPointUse right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContactPointUse"/>. </summary>
        public static implicit operator ContactPointUse(string value) => new ContactPointUse(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContactPointUse other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContactPointUse other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
