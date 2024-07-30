// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Specifies the fabric name - Azure or AD. </summary>
    public readonly partial struct BackupFabricName : IEquatable<BackupFabricName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupFabricName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupFabricName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AzureValue = "Azure";

        /// <summary> Invalid. </summary>
        public static BackupFabricName Invalid { get; } = new BackupFabricName(InvalidValue);
        /// <summary> Azure. </summary>
        public static BackupFabricName Azure { get; } = new BackupFabricName(AzureValue);
        /// <summary> Determines if two <see cref="BackupFabricName"/> values are the same. </summary>
        public static bool operator ==(BackupFabricName left, BackupFabricName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupFabricName"/> values are not the same. </summary>
        public static bool operator !=(BackupFabricName left, BackupFabricName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupFabricName"/>. </summary>
        public static implicit operator BackupFabricName(string value) => new BackupFabricName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupFabricName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupFabricName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
