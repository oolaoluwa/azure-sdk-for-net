// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Font style. </summary>
    public readonly partial struct DocumentFontStyle : IEquatable<DocumentFontStyle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentFontStyle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentFontStyle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "normal";
        private const string ItalicValue = "italic";

        /// <summary> Characters are represented normally. </summary>
        public static DocumentFontStyle Normal { get; } = new DocumentFontStyle(NormalValue);
        /// <summary> Characters are visually slanted to the right. </summary>
        public static DocumentFontStyle Italic { get; } = new DocumentFontStyle(ItalicValue);
        /// <summary> Determines if two <see cref="DocumentFontStyle"/> values are the same. </summary>
        public static bool operator ==(DocumentFontStyle left, DocumentFontStyle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentFontStyle"/> values are not the same. </summary>
        public static bool operator !=(DocumentFontStyle left, DocumentFontStyle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentFontStyle"/>. </summary>
        public static implicit operator DocumentFontStyle(string value) => new DocumentFontStyle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentFontStyle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentFontStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
