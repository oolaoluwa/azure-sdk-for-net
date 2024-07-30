// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TranscriptionStatusDetails. </summary>
    public readonly partial struct TranscriptionStatusDetails : IEquatable<TranscriptionStatusDetails>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TranscriptionStatusDetails"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TranscriptionStatusDetails(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SubscriptionStartedValue = "subscriptionStarted";
        private const string StreamConnectionReestablishedValue = "streamConnectionReestablished";
        private const string StreamConnectionUnsuccessfulValue = "streamConnectionUnsuccessful";
        private const string StreamUrlMissingValue = "streamUrlMissing";
        private const string ServiceShutdownValue = "serviceShutdown";
        private const string StreamConnectionInterruptedValue = "streamConnectionInterrupted";
        private const string SpeechServicesConnectionErrorValue = "speechServicesConnectionError";
        private const string SubscriptionStoppedValue = "subscriptionStopped";
        private const string UnspecifiedErrorValue = "unspecifiedError";
        private const string AuthenticationFailureValue = "authenticationFailure";
        private const string BadRequestValue = "badRequest";
        private const string TooManyRequestsValue = "tooManyRequests";
        private const string ForbiddenValue = "forbidden";
        private const string ServiceTimeoutValue = "serviceTimeout";
        private const string TranscriptionLocaleUpdatedValue = "transcriptionLocaleUpdated";

        /// <summary> subscriptionStarted. </summary>
        public static TranscriptionStatusDetails SubscriptionStarted { get; } = new TranscriptionStatusDetails(SubscriptionStartedValue);
        /// <summary> streamConnectionReestablished. </summary>
        public static TranscriptionStatusDetails StreamConnectionReestablished { get; } = new TranscriptionStatusDetails(StreamConnectionReestablishedValue);
        /// <summary> streamConnectionUnsuccessful. </summary>
        public static TranscriptionStatusDetails StreamConnectionUnsuccessful { get; } = new TranscriptionStatusDetails(StreamConnectionUnsuccessfulValue);
        /// <summary> streamUrlMissing. </summary>
        public static TranscriptionStatusDetails StreamUrlMissing { get; } = new TranscriptionStatusDetails(StreamUrlMissingValue);
        /// <summary> serviceShutdown. </summary>
        public static TranscriptionStatusDetails ServiceShutdown { get; } = new TranscriptionStatusDetails(ServiceShutdownValue);
        /// <summary> streamConnectionInterrupted. </summary>
        public static TranscriptionStatusDetails StreamConnectionInterrupted { get; } = new TranscriptionStatusDetails(StreamConnectionInterruptedValue);
        /// <summary> speechServicesConnectionError. </summary>
        public static TranscriptionStatusDetails SpeechServicesConnectionError { get; } = new TranscriptionStatusDetails(SpeechServicesConnectionErrorValue);
        /// <summary> subscriptionStopped. </summary>
        public static TranscriptionStatusDetails SubscriptionStopped { get; } = new TranscriptionStatusDetails(SubscriptionStoppedValue);
        /// <summary> unspecifiedError. </summary>
        public static TranscriptionStatusDetails UnspecifiedError { get; } = new TranscriptionStatusDetails(UnspecifiedErrorValue);
        /// <summary> authenticationFailure. </summary>
        public static TranscriptionStatusDetails AuthenticationFailure { get; } = new TranscriptionStatusDetails(AuthenticationFailureValue);
        /// <summary> badRequest. </summary>
        public static TranscriptionStatusDetails BadRequest { get; } = new TranscriptionStatusDetails(BadRequestValue);
        /// <summary> tooManyRequests. </summary>
        public static TranscriptionStatusDetails TooManyRequests { get; } = new TranscriptionStatusDetails(TooManyRequestsValue);
        /// <summary> forbidden. </summary>
        public static TranscriptionStatusDetails Forbidden { get; } = new TranscriptionStatusDetails(ForbiddenValue);
        /// <summary> serviceTimeout. </summary>
        public static TranscriptionStatusDetails ServiceTimeout { get; } = new TranscriptionStatusDetails(ServiceTimeoutValue);
        /// <summary> transcriptionLocaleUpdated. </summary>
        public static TranscriptionStatusDetails TranscriptionLocaleUpdated { get; } = new TranscriptionStatusDetails(TranscriptionLocaleUpdatedValue);
        /// <summary> Determines if two <see cref="TranscriptionStatusDetails"/> values are the same. </summary>
        public static bool operator ==(TranscriptionStatusDetails left, TranscriptionStatusDetails right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TranscriptionStatusDetails"/> values are not the same. </summary>
        public static bool operator !=(TranscriptionStatusDetails left, TranscriptionStatusDetails right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TranscriptionStatusDetails"/>. </summary>
        public static implicit operator TranscriptionStatusDetails(string value) => new TranscriptionStatusDetails(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TranscriptionStatusDetails other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TranscriptionStatusDetails other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
