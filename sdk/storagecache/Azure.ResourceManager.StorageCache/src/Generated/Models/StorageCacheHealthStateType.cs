// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> List of cache health states. Down is when the cluster is not responding.  Degraded is when its functioning but has some alerts. Transitioning when it is creating or deleting. Unknown will be returned in old api versions when a new value is added in future versions. WaitingForKey is when the create is waiting for the system assigned identity to be given access to the encryption key in the encryption settings. </summary>
    public readonly partial struct StorageCacheHealthStateType : IEquatable<StorageCacheHealthStateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageCacheHealthStateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageCacheHealthStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string HealthyValue = "Healthy";
        private const string DegradedValue = "Degraded";
        private const string DownValue = "Down";
        private const string TransitioningValue = "Transitioning";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string UpgradingValue = "Upgrading";
        private const string FlushingValue = "Flushing";
        private const string WaitingForKeyValue = "WaitingForKey";
        private const string StartFailedValue = "StartFailed";
        private const string UpgradeFailedValue = "UpgradeFailed";

        /// <summary> Unknown. </summary>
        public static StorageCacheHealthStateType Unknown { get; } = new StorageCacheHealthStateType(UnknownValue);
        /// <summary> Healthy. </summary>
        public static StorageCacheHealthStateType Healthy { get; } = new StorageCacheHealthStateType(HealthyValue);
        /// <summary> Degraded. </summary>
        public static StorageCacheHealthStateType Degraded { get; } = new StorageCacheHealthStateType(DegradedValue);
        /// <summary> Down. </summary>
        public static StorageCacheHealthStateType Down { get; } = new StorageCacheHealthStateType(DownValue);
        /// <summary> Transitioning. </summary>
        public static StorageCacheHealthStateType Transitioning { get; } = new StorageCacheHealthStateType(TransitioningValue);
        /// <summary> Stopping. </summary>
        public static StorageCacheHealthStateType Stopping { get; } = new StorageCacheHealthStateType(StoppingValue);
        /// <summary> Stopped. </summary>
        public static StorageCacheHealthStateType Stopped { get; } = new StorageCacheHealthStateType(StoppedValue);
        /// <summary> Upgrading. </summary>
        public static StorageCacheHealthStateType Upgrading { get; } = new StorageCacheHealthStateType(UpgradingValue);
        /// <summary> Flushing. </summary>
        public static StorageCacheHealthStateType Flushing { get; } = new StorageCacheHealthStateType(FlushingValue);
        /// <summary> WaitingForKey. </summary>
        public static StorageCacheHealthStateType WaitingForKey { get; } = new StorageCacheHealthStateType(WaitingForKeyValue);
        /// <summary> StartFailed. </summary>
        public static StorageCacheHealthStateType StartFailed { get; } = new StorageCacheHealthStateType(StartFailedValue);
        /// <summary> UpgradeFailed. </summary>
        public static StorageCacheHealthStateType UpgradeFailed { get; } = new StorageCacheHealthStateType(UpgradeFailedValue);
        /// <summary> Determines if two <see cref="StorageCacheHealthStateType"/> values are the same. </summary>
        public static bool operator ==(StorageCacheHealthStateType left, StorageCacheHealthStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageCacheHealthStateType"/> values are not the same. </summary>
        public static bool operator !=(StorageCacheHealthStateType left, StorageCacheHealthStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageCacheHealthStateType"/>. </summary>
        public static implicit operator StorageCacheHealthStateType(string value) => new StorageCacheHealthStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageCacheHealthStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageCacheHealthStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
