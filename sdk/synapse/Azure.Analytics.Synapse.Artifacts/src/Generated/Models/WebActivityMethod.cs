// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The list of HTTP methods supported by a WebActivity. </summary>
    public readonly partial struct WebActivityMethod : IEquatable<WebActivityMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebActivityMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebActivityMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GETValue = "GET";
        private const string PostValue = "POST";
        private const string PUTValue = "PUT";
        private const string DeleteValue = "DELETE";

        /// <summary> GET. </summary>
        public static WebActivityMethod GET { get; } = new WebActivityMethod(GETValue);
        /// <summary> POST. </summary>
        public static WebActivityMethod Post { get; } = new WebActivityMethod(PostValue);
        /// <summary> PUT. </summary>
        public static WebActivityMethod PUT { get; } = new WebActivityMethod(PUTValue);
        /// <summary> DELETE. </summary>
        public static WebActivityMethod Delete { get; } = new WebActivityMethod(DeleteValue);
        /// <summary> Determines if two <see cref="WebActivityMethod"/> values are the same. </summary>
        public static bool operator ==(WebActivityMethod left, WebActivityMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebActivityMethod"/> values are not the same. </summary>
        public static bool operator !=(WebActivityMethod left, WebActivityMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebActivityMethod"/>. </summary>
        public static implicit operator WebActivityMethod(string value) => new WebActivityMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebActivityMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebActivityMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
