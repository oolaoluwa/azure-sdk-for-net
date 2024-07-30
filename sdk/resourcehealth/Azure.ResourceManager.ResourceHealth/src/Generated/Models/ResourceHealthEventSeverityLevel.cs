// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The severity level of this active event. </summary>
    public readonly partial struct ResourceHealthEventSeverityLevel : IEquatable<ResourceHealthEventSeverityLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthEventSeverityLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceHealthEventSeverityLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InformationValue = "Information";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";

        /// <summary> Information. </summary>
        public static ResourceHealthEventSeverityLevel Information { get; } = new ResourceHealthEventSeverityLevel(InformationValue);
        /// <summary> Warning. </summary>
        public static ResourceHealthEventSeverityLevel Warning { get; } = new ResourceHealthEventSeverityLevel(WarningValue);
        /// <summary> Error. </summary>
        public static ResourceHealthEventSeverityLevel Error { get; } = new ResourceHealthEventSeverityLevel(ErrorValue);
        /// <summary> Determines if two <see cref="ResourceHealthEventSeverityLevel"/> values are the same. </summary>
        public static bool operator ==(ResourceHealthEventSeverityLevel left, ResourceHealthEventSeverityLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceHealthEventSeverityLevel"/> values are not the same. </summary>
        public static bool operator !=(ResourceHealthEventSeverityLevel left, ResourceHealthEventSeverityLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceHealthEventSeverityLevel"/>. </summary>
        public static implicit operator ResourceHealthEventSeverityLevel(string value) => new ResourceHealthEventSeverityLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceHealthEventSeverityLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceHealthEventSeverityLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
