// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryWebhookAction. </summary>
    public readonly partial struct ContainerRegistryWebhookAction : IEquatable<ContainerRegistryWebhookAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryWebhookAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PushValue = "push";
        private const string DeleteValue = "delete";
        private const string QuarantineValue = "quarantine";
        private const string ChartPushValue = "chart_push";
        private const string ChartDeleteValue = "chart_delete";

        /// <summary> push. </summary>
        public static ContainerRegistryWebhookAction Push { get; } = new ContainerRegistryWebhookAction(PushValue);
        /// <summary> delete. </summary>
        public static ContainerRegistryWebhookAction Delete { get; } = new ContainerRegistryWebhookAction(DeleteValue);
        /// <summary> quarantine. </summary>
        public static ContainerRegistryWebhookAction Quarantine { get; } = new ContainerRegistryWebhookAction(QuarantineValue);
        /// <summary> chart_push. </summary>
        public static ContainerRegistryWebhookAction ChartPush { get; } = new ContainerRegistryWebhookAction(ChartPushValue);
        /// <summary> chart_delete. </summary>
        public static ContainerRegistryWebhookAction ChartDelete { get; } = new ContainerRegistryWebhookAction(ChartDeleteValue);
        /// <summary> Determines if two <see cref="ContainerRegistryWebhookAction"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryWebhookAction left, ContainerRegistryWebhookAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryWebhookAction"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryWebhookAction left, ContainerRegistryWebhookAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContainerRegistryWebhookAction"/>. </summary>
        public static implicit operator ContainerRegistryWebhookAction(string value) => new ContainerRegistryWebhookAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryWebhookAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryWebhookAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
