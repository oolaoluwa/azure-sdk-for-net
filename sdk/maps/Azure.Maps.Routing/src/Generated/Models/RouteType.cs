// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Routing
{
    /// <summary> The RouteType. </summary>
    public readonly partial struct RouteType : IEquatable<RouteType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouteType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouteType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FastestValue = "fastest";
        private const string ShortestValue = "shortest";
        private const string EconomyValue = "eco";
        private const string ThrillingValue = "thrilling";

        /// <summary> The fastest route. </summary>
        public static RouteType Fastest { get; } = new RouteType(FastestValue);
        /// <summary> The shortest route by distance. </summary>
        public static RouteType Shortest { get; } = new RouteType(ShortestValue);
        /// <summary> A route balanced by economy and speed. </summary>
        public static RouteType Economy { get; } = new RouteType(EconomyValue);
        /// <summary> Includes interesting or challenging roads and uses as few motorways as possible. You can choose the level of turns included and also the degree of hilliness. See the hilliness and windingness parameters for how to set this. There is a limit of 900 km on routes planned with `routeType`=thrilling. </summary>
        public static RouteType Thrilling { get; } = new RouteType(ThrillingValue);
        /// <summary> Determines if two <see cref="RouteType"/> values are the same. </summary>
        public static bool operator ==(RouteType left, RouteType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouteType"/> values are not the same. </summary>
        public static bool operator !=(RouteType left, RouteType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RouteType"/>. </summary>
        public static implicit operator RouteType(string value) => new RouteType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouteType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouteType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
