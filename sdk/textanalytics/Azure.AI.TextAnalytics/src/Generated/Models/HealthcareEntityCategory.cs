// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary> Healthcare Entity Category. </summary>
    public readonly partial struct HealthcareEntityCategory : IEquatable<HealthcareEntityCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HealthcareEntityCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BodyStructureValue = "BodyStructure";
        private const string AgeValue = "Age";
        private const string GenderValue = "Gender";
        private const string EthnicityValue = "Ethnicity";
        private const string ExaminationNameValue = "ExaminationName";
        private const string DateValue = "Date";
        private const string DirectionValue = "Direction";
        private const string FrequencyValue = "Frequency";
        private const string MeasurementValueValue = "MeasurementValue";
        private const string MeasurementUnitValue = "MeasurementUnit";
        private const string RelationalOperatorValue = "RelationalOperator";
        private const string TimeValue = "Time";
        private const string CourseValue = "Course";
        private const string GeneOrProteinValue = "GeneOrProtein";
        private const string VariantValue = "Variant";
        private const string ExpressionValue = "Expression";
        private const string MutationTypeValue = "MutationType";
        private const string AdministrativeEventValue = "AdministrativeEvent";
        private const string CareEnvironmentValue = "CareEnvironment";
        private const string HealthcareProfessionValue = "HealthcareProfession";
        private const string DiagnosisValue = "Diagnosis";
        private const string SymptomOrSignValue = "SymptomOrSign";
        private const string ConditionQualifierValue = "ConditionQualifier";
        private const string ConditionScaleValue = "ConditionScale";
        private const string MedicationClassValue = "MedicationClass";
        private const string MedicationNameValue = "MedicationName";
        private const string DosageValue = "Dosage";
        private const string MedicationFormValue = "MedicationForm";
        private const string MedicationRouteValue = "MedicationRoute";
        private const string FamilyRelationValue = "FamilyRelation";
        private const string TreatmentNameValue = "TreatmentName";
        private const string AllergenValue = "Allergen";
        private const string EmploymentValue = "Employment";
        private const string LivingStatusValue = "LivingStatus";
        private const string SubstanceUseValue = "SubstanceUse";
        private const string SubstanceUseAmountValue = "SubstanceUseAmount";

        /// <summary> BodyStructure. </summary>
        public static HealthcareEntityCategory BodyStructure { get; } = new HealthcareEntityCategory(BodyStructureValue);
        /// <summary> Age. </summary>
        public static HealthcareEntityCategory Age { get; } = new HealthcareEntityCategory(AgeValue);
        /// <summary> Gender. </summary>
        public static HealthcareEntityCategory Gender { get; } = new HealthcareEntityCategory(GenderValue);
        /// <summary> Ethnicity. </summary>
        public static HealthcareEntityCategory Ethnicity { get; } = new HealthcareEntityCategory(EthnicityValue);
        /// <summary> ExaminationName. </summary>
        public static HealthcareEntityCategory ExaminationName { get; } = new HealthcareEntityCategory(ExaminationNameValue);
        /// <summary> Date. </summary>
        public static HealthcareEntityCategory Date { get; } = new HealthcareEntityCategory(DateValue);
        /// <summary> Direction. </summary>
        public static HealthcareEntityCategory Direction { get; } = new HealthcareEntityCategory(DirectionValue);
        /// <summary> Frequency. </summary>
        public static HealthcareEntityCategory Frequency { get; } = new HealthcareEntityCategory(FrequencyValue);
        /// <summary> MeasurementValue. </summary>
        public static HealthcareEntityCategory MeasurementValue { get; } = new HealthcareEntityCategory(MeasurementValueValue);
        /// <summary> MeasurementUnit. </summary>
        public static HealthcareEntityCategory MeasurementUnit { get; } = new HealthcareEntityCategory(MeasurementUnitValue);
        /// <summary> RelationalOperator. </summary>
        public static HealthcareEntityCategory RelationalOperator { get; } = new HealthcareEntityCategory(RelationalOperatorValue);
        /// <summary> Time. </summary>
        public static HealthcareEntityCategory Time { get; } = new HealthcareEntityCategory(TimeValue);
        /// <summary> Course. </summary>
        public static HealthcareEntityCategory Course { get; } = new HealthcareEntityCategory(CourseValue);
        /// <summary> GeneOrProtein. </summary>
        public static HealthcareEntityCategory GeneOrProtein { get; } = new HealthcareEntityCategory(GeneOrProteinValue);
        /// <summary> Variant. </summary>
        public static HealthcareEntityCategory Variant { get; } = new HealthcareEntityCategory(VariantValue);
        /// <summary> Expression. </summary>
        public static HealthcareEntityCategory Expression { get; } = new HealthcareEntityCategory(ExpressionValue);
        /// <summary> MutationType. </summary>
        public static HealthcareEntityCategory MutationType { get; } = new HealthcareEntityCategory(MutationTypeValue);
        /// <summary> AdministrativeEvent. </summary>
        public static HealthcareEntityCategory AdministrativeEvent { get; } = new HealthcareEntityCategory(AdministrativeEventValue);
        /// <summary> CareEnvironment. </summary>
        public static HealthcareEntityCategory CareEnvironment { get; } = new HealthcareEntityCategory(CareEnvironmentValue);
        /// <summary> HealthcareProfession. </summary>
        public static HealthcareEntityCategory HealthcareProfession { get; } = new HealthcareEntityCategory(HealthcareProfessionValue);
        /// <summary> Diagnosis. </summary>
        public static HealthcareEntityCategory Diagnosis { get; } = new HealthcareEntityCategory(DiagnosisValue);
        /// <summary> SymptomOrSign. </summary>
        public static HealthcareEntityCategory SymptomOrSign { get; } = new HealthcareEntityCategory(SymptomOrSignValue);
        /// <summary> ConditionQualifier. </summary>
        public static HealthcareEntityCategory ConditionQualifier { get; } = new HealthcareEntityCategory(ConditionQualifierValue);
        /// <summary> ConditionScale. </summary>
        public static HealthcareEntityCategory ConditionScale { get; } = new HealthcareEntityCategory(ConditionScaleValue);
        /// <summary> MedicationClass. </summary>
        public static HealthcareEntityCategory MedicationClass { get; } = new HealthcareEntityCategory(MedicationClassValue);
        /// <summary> MedicationName. </summary>
        public static HealthcareEntityCategory MedicationName { get; } = new HealthcareEntityCategory(MedicationNameValue);
        /// <summary> Dosage. </summary>
        public static HealthcareEntityCategory Dosage { get; } = new HealthcareEntityCategory(DosageValue);
        /// <summary> MedicationForm. </summary>
        public static HealthcareEntityCategory MedicationForm { get; } = new HealthcareEntityCategory(MedicationFormValue);
        /// <summary> MedicationRoute. </summary>
        public static HealthcareEntityCategory MedicationRoute { get; } = new HealthcareEntityCategory(MedicationRouteValue);
        /// <summary> FamilyRelation. </summary>
        public static HealthcareEntityCategory FamilyRelation { get; } = new HealthcareEntityCategory(FamilyRelationValue);
        /// <summary> TreatmentName. </summary>
        public static HealthcareEntityCategory TreatmentName { get; } = new HealthcareEntityCategory(TreatmentNameValue);
        /// <summary> Allergen. </summary>
        public static HealthcareEntityCategory Allergen { get; } = new HealthcareEntityCategory(AllergenValue);
        /// <summary> Employment. </summary>
        public static HealthcareEntityCategory Employment { get; } = new HealthcareEntityCategory(EmploymentValue);
        /// <summary> LivingStatus. </summary>
        public static HealthcareEntityCategory LivingStatus { get; } = new HealthcareEntityCategory(LivingStatusValue);
        /// <summary> SubstanceUse. </summary>
        public static HealthcareEntityCategory SubstanceUse { get; } = new HealthcareEntityCategory(SubstanceUseValue);
        /// <summary> SubstanceUseAmount. </summary>
        public static HealthcareEntityCategory SubstanceUseAmount { get; } = new HealthcareEntityCategory(SubstanceUseAmountValue);
        /// <summary> Determines if two <see cref="HealthcareEntityCategory"/> values are the same. </summary>
        public static bool operator ==(HealthcareEntityCategory left, HealthcareEntityCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HealthcareEntityCategory"/> values are not the same. </summary>
        public static bool operator !=(HealthcareEntityCategory left, HealthcareEntityCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HealthcareEntityCategory"/>. </summary>
        public static implicit operator HealthcareEntityCategory(string value) => new HealthcareEntityCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HealthcareEntityCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HealthcareEntityCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
