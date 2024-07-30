// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Status code of the application gateway custom error. </summary>
    public readonly partial struct ApplicationGatewayCustomErrorStatusCode : IEquatable<ApplicationGatewayCustomErrorStatusCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayCustomErrorStatusCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayCustomErrorStatusCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpStatus400Value = "HttpStatus400";
        private const string HttpStatus403Value = "HttpStatus403";
        private const string HttpStatus404Value = "HttpStatus404";
        private const string HttpStatus405Value = "HttpStatus405";
        private const string HttpStatus408Value = "HttpStatus408";
        private const string HttpStatus500Value = "HttpStatus500";
        private const string HttpStatus502Value = "HttpStatus502";
        private const string HttpStatus503Value = "HttpStatus503";
        private const string HttpStatus504Value = "HttpStatus504";

        /// <summary> HttpStatus400. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus400 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus400Value);
        /// <summary> HttpStatus403. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus403 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus403Value);
        /// <summary> HttpStatus404. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus404 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus404Value);
        /// <summary> HttpStatus405. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus405 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus405Value);
        /// <summary> HttpStatus408. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus408 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus408Value);
        /// <summary> HttpStatus500. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus500 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus500Value);
        /// <summary> HttpStatus502. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus502 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus502Value);
        /// <summary> HttpStatus503. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus503 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus503Value);
        /// <summary> HttpStatus504. </summary>
        public static ApplicationGatewayCustomErrorStatusCode HttpStatus504 { get; } = new ApplicationGatewayCustomErrorStatusCode(HttpStatus504Value);
        /// <summary> Determines if two <see cref="ApplicationGatewayCustomErrorStatusCode"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayCustomErrorStatusCode left, ApplicationGatewayCustomErrorStatusCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayCustomErrorStatusCode"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayCustomErrorStatusCode left, ApplicationGatewayCustomErrorStatusCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayCustomErrorStatusCode"/>. </summary>
        public static implicit operator ApplicationGatewayCustomErrorStatusCode(string value) => new ApplicationGatewayCustomErrorStatusCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayCustomErrorStatusCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayCustomErrorStatusCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
