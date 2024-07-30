// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The managed application artifact name. </summary>
    public readonly partial struct ArmApplicationDefinitionArtifactName : IEquatable<ArmApplicationDefinitionArtifactName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationDefinitionArtifactName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArmApplicationDefinitionArtifactName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ApplicationResourceTemplateValue = "ApplicationResourceTemplate";
        private const string CreateUiDefinitionValue = "CreateUiDefinition";
        private const string MainTemplateParametersValue = "MainTemplateParameters";

        /// <summary> NotSpecified. </summary>
        public static ArmApplicationDefinitionArtifactName NotSpecified { get; } = new ArmApplicationDefinitionArtifactName(NotSpecifiedValue);
        /// <summary> ApplicationResourceTemplate. </summary>
        public static ArmApplicationDefinitionArtifactName ApplicationResourceTemplate { get; } = new ArmApplicationDefinitionArtifactName(ApplicationResourceTemplateValue);
        /// <summary> CreateUiDefinition. </summary>
        public static ArmApplicationDefinitionArtifactName CreateUiDefinition { get; } = new ArmApplicationDefinitionArtifactName(CreateUiDefinitionValue);
        /// <summary> MainTemplateParameters. </summary>
        public static ArmApplicationDefinitionArtifactName MainTemplateParameters { get; } = new ArmApplicationDefinitionArtifactName(MainTemplateParametersValue);
        /// <summary> Determines if two <see cref="ArmApplicationDefinitionArtifactName"/> values are the same. </summary>
        public static bool operator ==(ArmApplicationDefinitionArtifactName left, ArmApplicationDefinitionArtifactName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArmApplicationDefinitionArtifactName"/> values are not the same. </summary>
        public static bool operator !=(ArmApplicationDefinitionArtifactName left, ArmApplicationDefinitionArtifactName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ArmApplicationDefinitionArtifactName"/>. </summary>
        public static implicit operator ArmApplicationDefinitionArtifactName(string value) => new ArmApplicationDefinitionArtifactName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArmApplicationDefinitionArtifactName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArmApplicationDefinitionArtifactName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
