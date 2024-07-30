// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The current status of the individual node. </summary>
    public readonly partial struct DataBoxEdgeNodeStatus : IEquatable<DataBoxEdgeNodeStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeNodeStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeNodeStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string UpValue = "Up";
        private const string DownValue = "Down";
        private const string RebootingValue = "Rebooting";
        private const string ShuttingDownValue = "ShuttingDown";

        /// <summary> Unknown. </summary>
        public static DataBoxEdgeNodeStatus Unknown { get; } = new DataBoxEdgeNodeStatus(UnknownValue);
        /// <summary> Up. </summary>
        public static DataBoxEdgeNodeStatus Up { get; } = new DataBoxEdgeNodeStatus(UpValue);
        /// <summary> Down. </summary>
        public static DataBoxEdgeNodeStatus Down { get; } = new DataBoxEdgeNodeStatus(DownValue);
        /// <summary> Rebooting. </summary>
        public static DataBoxEdgeNodeStatus Rebooting { get; } = new DataBoxEdgeNodeStatus(RebootingValue);
        /// <summary> ShuttingDown. </summary>
        public static DataBoxEdgeNodeStatus ShuttingDown { get; } = new DataBoxEdgeNodeStatus(ShuttingDownValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeNodeStatus"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeNodeStatus left, DataBoxEdgeNodeStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeNodeStatus"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeNodeStatus left, DataBoxEdgeNodeStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeNodeStatus"/>. </summary>
        public static implicit operator DataBoxEdgeNodeStatus(string value) => new DataBoxEdgeNodeStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeNodeStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeNodeStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
