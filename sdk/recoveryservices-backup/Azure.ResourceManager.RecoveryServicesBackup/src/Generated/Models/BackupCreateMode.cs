// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Create mode to indicate recovery of existing soft deleted data source or creation of new data source. </summary>
    public readonly partial struct BackupCreateMode : IEquatable<BackupCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string DefaultValue = "Default";
        private const string RecoverValue = "Recover";

        /// <summary> Invalid. </summary>
        public static BackupCreateMode Invalid { get; } = new BackupCreateMode(InvalidValue);
        /// <summary> Default. </summary>
        public static BackupCreateMode Default { get; } = new BackupCreateMode(DefaultValue);
        /// <summary> Recover. </summary>
        public static BackupCreateMode Recover { get; } = new BackupCreateMode(RecoverValue);
        /// <summary> Determines if two <see cref="BackupCreateMode"/> values are the same. </summary>
        public static bool operator ==(BackupCreateMode left, BackupCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupCreateMode"/> values are not the same. </summary>
        public static bool operator !=(BackupCreateMode left, BackupCreateMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupCreateMode"/>. </summary>
        public static implicit operator BackupCreateMode(string value) => new BackupCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
