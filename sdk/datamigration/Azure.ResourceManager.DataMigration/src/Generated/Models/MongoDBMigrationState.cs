// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MongoDBMigrationState. </summary>
    public readonly partial struct MongoDBMigrationState : IEquatable<MongoDBMigrationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDBMigrationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDBMigrationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string ValidatingInputValue = "ValidatingInput";
        private const string InitializingValue = "Initializing";
        private const string RestartingValue = "Restarting";
        private const string CopyingValue = "Copying";
        private const string InitialReplayValue = "InitialReplay";
        private const string ReplayingValue = "Replaying";
        private const string FinalizingValue = "Finalizing";
        private const string CompleteValue = "Complete";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> NotStarted. </summary>
        public static MongoDBMigrationState NotStarted { get; } = new MongoDBMigrationState(NotStartedValue);
        /// <summary> ValidatingInput. </summary>
        public static MongoDBMigrationState ValidatingInput { get; } = new MongoDBMigrationState(ValidatingInputValue);
        /// <summary> Initializing. </summary>
        public static MongoDBMigrationState Initializing { get; } = new MongoDBMigrationState(InitializingValue);
        /// <summary> Restarting. </summary>
        public static MongoDBMigrationState Restarting { get; } = new MongoDBMigrationState(RestartingValue);
        /// <summary> Copying. </summary>
        public static MongoDBMigrationState Copying { get; } = new MongoDBMigrationState(CopyingValue);
        /// <summary> InitialReplay. </summary>
        public static MongoDBMigrationState InitialReplay { get; } = new MongoDBMigrationState(InitialReplayValue);
        /// <summary> Replaying. </summary>
        public static MongoDBMigrationState Replaying { get; } = new MongoDBMigrationState(ReplayingValue);
        /// <summary> Finalizing. </summary>
        public static MongoDBMigrationState Finalizing { get; } = new MongoDBMigrationState(FinalizingValue);
        /// <summary> Complete. </summary>
        public static MongoDBMigrationState Complete { get; } = new MongoDBMigrationState(CompleteValue);
        /// <summary> Canceled. </summary>
        public static MongoDBMigrationState Canceled { get; } = new MongoDBMigrationState(CanceledValue);
        /// <summary> Failed. </summary>
        public static MongoDBMigrationState Failed { get; } = new MongoDBMigrationState(FailedValue);
        /// <summary> Determines if two <see cref="MongoDBMigrationState"/> values are the same. </summary>
        public static bool operator ==(MongoDBMigrationState left, MongoDBMigrationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDBMigrationState"/> values are not the same. </summary>
        public static bool operator !=(MongoDBMigrationState left, MongoDBMigrationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoDBMigrationState"/>. </summary>
        public static implicit operator MongoDBMigrationState(string value) => new MongoDBMigrationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDBMigrationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDBMigrationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
