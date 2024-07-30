// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The sync type. </summary>
    public readonly partial struct SourceControlSyncType : IEquatable<SourceControlSyncType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceControlSyncType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PartialSyncValue = "PartialSync";
        private const string FullSyncValue = "FullSync";

        /// <summary> PartialSync. </summary>
        public static SourceControlSyncType PartialSync { get; } = new SourceControlSyncType(PartialSyncValue);
        /// <summary> FullSync. </summary>
        public static SourceControlSyncType FullSync { get; } = new SourceControlSyncType(FullSyncValue);
        /// <summary> Determines if two <see cref="SourceControlSyncType"/> values are the same. </summary>
        public static bool operator ==(SourceControlSyncType left, SourceControlSyncType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceControlSyncType"/> values are not the same. </summary>
        public static bool operator !=(SourceControlSyncType left, SourceControlSyncType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SourceControlSyncType"/>. </summary>
        public static implicit operator SourceControlSyncType(string value) => new SourceControlSyncType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceControlSyncType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceControlSyncType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
