// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </summary>
    public readonly partial struct RenderingServerSize : IEquatable<RenderingServerSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RenderingServerSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RenderingServerSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Standard rendering session size. </summary>
        public static RenderingServerSize Standard { get; } = new RenderingServerSize(StandardValue);
        /// <summary> Premium rendering session size. </summary>
        public static RenderingServerSize Premium { get; } = new RenderingServerSize(PremiumValue);
        /// <summary> Determines if two <see cref="RenderingServerSize"/> values are the same. </summary>
        public static bool operator ==(RenderingServerSize left, RenderingServerSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RenderingServerSize"/> values are not the same. </summary>
        public static bool operator !=(RenderingServerSize left, RenderingServerSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RenderingServerSize"/>. </summary>
        public static implicit operator RenderingServerSize(string value) => new RenderingServerSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RenderingServerSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RenderingServerSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
