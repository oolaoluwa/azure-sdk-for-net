// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Prediction model life cycle.  When prediction is in PendingModelConfirmation status, it is allowed to update the status to PendingFeaturing or Active through API. </summary>
    public readonly partial struct PredictionModelLifeCycle : IEquatable<PredictionModelLifeCycle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PredictionModelLifeCycle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PredictionModelLifeCycle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "New";
        private const string ProvisioningValue = "Provisioning";
        private const string ProvisioningFailedValue = "ProvisioningFailed";
        private const string PendingDiscoveringValue = "PendingDiscovering";
        private const string DiscoveringValue = "Discovering";
        private const string PendingFeaturingValue = "PendingFeaturing";
        private const string FeaturingValue = "Featuring";
        private const string FeaturingFailedValue = "FeaturingFailed";
        private const string PendingTrainingValue = "PendingTraining";
        private const string TrainingValue = "Training";
        private const string TrainingFailedValue = "TrainingFailed";
        private const string EvaluatingValue = "Evaluating";
        private const string EvaluatingFailedValue = "EvaluatingFailed";
        private const string PendingModelConfirmationValue = "PendingModelConfirmation";
        private const string ActiveValue = "Active";
        private const string DeletedValue = "Deleted";
        private const string HumanInterventionValue = "HumanIntervention";
        private const string FailedValue = "Failed";

        /// <summary> New. </summary>
        public static PredictionModelLifeCycle New { get; } = new PredictionModelLifeCycle(NewValue);
        /// <summary> Provisioning. </summary>
        public static PredictionModelLifeCycle Provisioning { get; } = new PredictionModelLifeCycle(ProvisioningValue);
        /// <summary> ProvisioningFailed. </summary>
        public static PredictionModelLifeCycle ProvisioningFailed { get; } = new PredictionModelLifeCycle(ProvisioningFailedValue);
        /// <summary> PendingDiscovering. </summary>
        public static PredictionModelLifeCycle PendingDiscovering { get; } = new PredictionModelLifeCycle(PendingDiscoveringValue);
        /// <summary> Discovering. </summary>
        public static PredictionModelLifeCycle Discovering { get; } = new PredictionModelLifeCycle(DiscoveringValue);
        /// <summary> PendingFeaturing. </summary>
        public static PredictionModelLifeCycle PendingFeaturing { get; } = new PredictionModelLifeCycle(PendingFeaturingValue);
        /// <summary> Featuring. </summary>
        public static PredictionModelLifeCycle Featuring { get; } = new PredictionModelLifeCycle(FeaturingValue);
        /// <summary> FeaturingFailed. </summary>
        public static PredictionModelLifeCycle FeaturingFailed { get; } = new PredictionModelLifeCycle(FeaturingFailedValue);
        /// <summary> PendingTraining. </summary>
        public static PredictionModelLifeCycle PendingTraining { get; } = new PredictionModelLifeCycle(PendingTrainingValue);
        /// <summary> Training. </summary>
        public static PredictionModelLifeCycle Training { get; } = new PredictionModelLifeCycle(TrainingValue);
        /// <summary> TrainingFailed. </summary>
        public static PredictionModelLifeCycle TrainingFailed { get; } = new PredictionModelLifeCycle(TrainingFailedValue);
        /// <summary> Evaluating. </summary>
        public static PredictionModelLifeCycle Evaluating { get; } = new PredictionModelLifeCycle(EvaluatingValue);
        /// <summary> EvaluatingFailed. </summary>
        public static PredictionModelLifeCycle EvaluatingFailed { get; } = new PredictionModelLifeCycle(EvaluatingFailedValue);
        /// <summary> PendingModelConfirmation. </summary>
        public static PredictionModelLifeCycle PendingModelConfirmation { get; } = new PredictionModelLifeCycle(PendingModelConfirmationValue);
        /// <summary> Active. </summary>
        public static PredictionModelLifeCycle Active { get; } = new PredictionModelLifeCycle(ActiveValue);
        /// <summary> Deleted. </summary>
        public static PredictionModelLifeCycle Deleted { get; } = new PredictionModelLifeCycle(DeletedValue);
        /// <summary> HumanIntervention. </summary>
        public static PredictionModelLifeCycle HumanIntervention { get; } = new PredictionModelLifeCycle(HumanInterventionValue);
        /// <summary> Failed. </summary>
        public static PredictionModelLifeCycle Failed { get; } = new PredictionModelLifeCycle(FailedValue);
        /// <summary> Determines if two <see cref="PredictionModelLifeCycle"/> values are the same. </summary>
        public static bool operator ==(PredictionModelLifeCycle left, PredictionModelLifeCycle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PredictionModelLifeCycle"/> values are not the same. </summary>
        public static bool operator !=(PredictionModelLifeCycle left, PredictionModelLifeCycle right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PredictionModelLifeCycle"/>. </summary>
        public static implicit operator PredictionModelLifeCycle(string value) => new PredictionModelLifeCycle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PredictionModelLifeCycle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PredictionModelLifeCycle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
