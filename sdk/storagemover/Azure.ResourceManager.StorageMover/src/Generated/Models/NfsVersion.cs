// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The NFS protocol version. </summary>
    public readonly partial struct NfsVersion : IEquatable<NfsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NfsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NfsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NFSautoValue = "NFSauto";
        private const string NFSv3Value = "NFSv3";
        private const string NFSv4Value = "NFSv4";

        /// <summary> NFSauto. </summary>
        public static NfsVersion NFSauto { get; } = new NfsVersion(NFSautoValue);
        /// <summary> NFSv3. </summary>
        public static NfsVersion NFSv3 { get; } = new NfsVersion(NFSv3Value);
        /// <summary> NFSv4. </summary>
        public static NfsVersion NFSv4 { get; } = new NfsVersion(NFSv4Value);
        /// <summary> Determines if two <see cref="NfsVersion"/> values are the same. </summary>
        public static bool operator ==(NfsVersion left, NfsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NfsVersion"/> values are not the same. </summary>
        public static bool operator !=(NfsVersion left, NfsVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NfsVersion"/>. </summary>
        public static implicit operator NfsVersion(string value) => new NfsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NfsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NfsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
