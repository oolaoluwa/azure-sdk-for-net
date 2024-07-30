// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Configures Unknown output handling settings of the license. </summary>
    public readonly partial struct ContentKeyPolicyPlayReadyUnknownOutputPassingOption : IEquatable<ContentKeyPolicyPlayReadyUnknownOutputPassingOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadyUnknownOutputPassingOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentKeyPolicyPlayReadyUnknownOutputPassingOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NotAllowedValue = "NotAllowed";
        private const string AllowedValue = "Allowed";
        private const string AllowedWithVideoConstrictionValue = "AllowedWithVideoConstriction";

        /// <summary> Represents a ContentKeyPolicyPlayReadyUnknownOutputPassingOption that is unavailable in current API version. </summary>
        public static ContentKeyPolicyPlayReadyUnknownOutputPassingOption Unknown { get; } = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(UnknownValue);
        /// <summary> Passing the video portion of protected content to an Unknown Output is not allowed. </summary>
        public static ContentKeyPolicyPlayReadyUnknownOutputPassingOption NotAllowed { get; } = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(NotAllowedValue);
        /// <summary> Passing the video portion of protected content to an Unknown Output is allowed. </summary>
        public static ContentKeyPolicyPlayReadyUnknownOutputPassingOption Allowed { get; } = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(AllowedValue);
        /// <summary> Passing the video portion of protected content to an Unknown Output is allowed but with constrained resolution. </summary>
        public static ContentKeyPolicyPlayReadyUnknownOutputPassingOption AllowedWithVideoConstriction { get; } = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(AllowedWithVideoConstrictionValue);
        /// <summary> Determines if two <see cref="ContentKeyPolicyPlayReadyUnknownOutputPassingOption"/> values are the same. </summary>
        public static bool operator ==(ContentKeyPolicyPlayReadyUnknownOutputPassingOption left, ContentKeyPolicyPlayReadyUnknownOutputPassingOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentKeyPolicyPlayReadyUnknownOutputPassingOption"/> values are not the same. </summary>
        public static bool operator !=(ContentKeyPolicyPlayReadyUnknownOutputPassingOption left, ContentKeyPolicyPlayReadyUnknownOutputPassingOption right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentKeyPolicyPlayReadyUnknownOutputPassingOption"/>. </summary>
        public static implicit operator ContentKeyPolicyPlayReadyUnknownOutputPassingOption(string value) => new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentKeyPolicyPlayReadyUnknownOutputPassingOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentKeyPolicyPlayReadyUnknownOutputPassingOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
