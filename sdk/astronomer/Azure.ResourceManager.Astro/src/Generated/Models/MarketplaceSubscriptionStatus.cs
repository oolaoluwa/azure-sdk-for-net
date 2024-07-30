// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Astro.Models
{
    /// <summary> Marketplace subscription status of a resource. </summary>
    public readonly partial struct MarketplaceSubscriptionStatus : IEquatable<MarketplaceSubscriptionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MarketplaceSubscriptionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MarketplaceSubscriptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingFulfillmentStartValue = "PendingFulfillmentStart";
        private const string SubscribedValue = "Subscribed";
        private const string SuspendedValue = "Suspended";
        private const string UnsubscribedValue = "Unsubscribed";

        /// <summary> Purchased but not yet activated. </summary>
        public static MarketplaceSubscriptionStatus PendingFulfillmentStart { get; } = new MarketplaceSubscriptionStatus(PendingFulfillmentStartValue);
        /// <summary> Marketplace subscription is activated. </summary>
        public static MarketplaceSubscriptionStatus Subscribed { get; } = new MarketplaceSubscriptionStatus(SubscribedValue);
        /// <summary> This state indicates that a customer's payment for the Marketplace service was not received. </summary>
        public static MarketplaceSubscriptionStatus Suspended { get; } = new MarketplaceSubscriptionStatus(SuspendedValue);
        /// <summary> Customer has cancelled the subscription. </summary>
        public static MarketplaceSubscriptionStatus Unsubscribed { get; } = new MarketplaceSubscriptionStatus(UnsubscribedValue);
        /// <summary> Determines if two <see cref="MarketplaceSubscriptionStatus"/> values are the same. </summary>
        public static bool operator ==(MarketplaceSubscriptionStatus left, MarketplaceSubscriptionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MarketplaceSubscriptionStatus"/> values are not the same. </summary>
        public static bool operator !=(MarketplaceSubscriptionStatus left, MarketplaceSubscriptionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MarketplaceSubscriptionStatus"/>. </summary>
        public static implicit operator MarketplaceSubscriptionStatus(string value) => new MarketplaceSubscriptionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MarketplaceSubscriptionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MarketplaceSubscriptionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
