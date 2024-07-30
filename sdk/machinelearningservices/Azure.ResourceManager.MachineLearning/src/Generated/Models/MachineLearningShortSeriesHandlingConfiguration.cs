// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The parameter defining how if AutoML should handle short time series. </summary>
    public readonly partial struct MachineLearningShortSeriesHandlingConfiguration : IEquatable<MachineLearningShortSeriesHandlingConfiguration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningShortSeriesHandlingConfiguration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningShortSeriesHandlingConfiguration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string AutoValue = "Auto";
        private const string PadValue = "Pad";
        private const string DropValue = "Drop";

        /// <summary> Represents no/null value. </summary>
        public static MachineLearningShortSeriesHandlingConfiguration None { get; } = new MachineLearningShortSeriesHandlingConfiguration(NoneValue);
        /// <summary> Short series will be padded if there are no long series, otherwise short series will be dropped. </summary>
        public static MachineLearningShortSeriesHandlingConfiguration Auto { get; } = new MachineLearningShortSeriesHandlingConfiguration(AutoValue);
        /// <summary> All the short series will be padded. </summary>
        public static MachineLearningShortSeriesHandlingConfiguration Pad { get; } = new MachineLearningShortSeriesHandlingConfiguration(PadValue);
        /// <summary> All the short series will be dropped. </summary>
        public static MachineLearningShortSeriesHandlingConfiguration Drop { get; } = new MachineLearningShortSeriesHandlingConfiguration(DropValue);
        /// <summary> Determines if two <see cref="MachineLearningShortSeriesHandlingConfiguration"/> values are the same. </summary>
        public static bool operator ==(MachineLearningShortSeriesHandlingConfiguration left, MachineLearningShortSeriesHandlingConfiguration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningShortSeriesHandlingConfiguration"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningShortSeriesHandlingConfiguration left, MachineLearningShortSeriesHandlingConfiguration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningShortSeriesHandlingConfiguration"/>. </summary>
        public static implicit operator MachineLearningShortSeriesHandlingConfiguration(string value) => new MachineLearningShortSeriesHandlingConfiguration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningShortSeriesHandlingConfiguration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningShortSeriesHandlingConfiguration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
