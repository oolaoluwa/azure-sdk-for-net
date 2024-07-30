// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> AutoRebuild setting for the derived image. </summary>
    public readonly partial struct AutoRebuildSetting : IEquatable<AutoRebuildSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutoRebuildSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutoRebuildSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string OnBaseImageUpdateValue = "OnBaseImageUpdate";

        /// <summary> Disabled. </summary>
        public static AutoRebuildSetting Disabled { get; } = new AutoRebuildSetting(DisabledValue);
        /// <summary> OnBaseImageUpdate. </summary>
        public static AutoRebuildSetting OnBaseImageUpdate { get; } = new AutoRebuildSetting(OnBaseImageUpdateValue);
        /// <summary> Determines if two <see cref="AutoRebuildSetting"/> values are the same. </summary>
        public static bool operator ==(AutoRebuildSetting left, AutoRebuildSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutoRebuildSetting"/> values are not the same. </summary>
        public static bool operator !=(AutoRebuildSetting left, AutoRebuildSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutoRebuildSetting"/>. </summary>
        public static implicit operator AutoRebuildSetting(string value) => new AutoRebuildSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutoRebuildSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutoRebuildSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
