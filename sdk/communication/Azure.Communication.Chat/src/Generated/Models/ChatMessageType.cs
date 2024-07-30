// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Chat
{
    /// <summary> The chat message type. </summary>
    public readonly partial struct ChatMessageType : IEquatable<ChatMessageType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChatMessageType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChatMessageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string HtmlValue = "html";
        private const string TopicUpdatedValue = "topicUpdated";
        private const string ParticipantAddedValue = "participantAdded";
        private const string ParticipantRemovedValue = "participantRemoved";

        /// <summary> text. </summary>
        public static ChatMessageType Text { get; } = new ChatMessageType(TextValue);
        /// <summary> html. </summary>
        public static ChatMessageType Html { get; } = new ChatMessageType(HtmlValue);
        /// <summary> topicUpdated. </summary>
        public static ChatMessageType TopicUpdated { get; } = new ChatMessageType(TopicUpdatedValue);
        /// <summary> participantAdded. </summary>
        public static ChatMessageType ParticipantAdded { get; } = new ChatMessageType(ParticipantAddedValue);
        /// <summary> participantRemoved. </summary>
        public static ChatMessageType ParticipantRemoved { get; } = new ChatMessageType(ParticipantRemovedValue);
        /// <summary> Determines if two <see cref="ChatMessageType"/> values are the same. </summary>
        public static bool operator ==(ChatMessageType left, ChatMessageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChatMessageType"/> values are not the same. </summary>
        public static bool operator !=(ChatMessageType left, ChatMessageType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChatMessageType"/>. </summary>
        public static implicit operator ChatMessageType(string value) => new ChatMessageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatMessageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChatMessageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
