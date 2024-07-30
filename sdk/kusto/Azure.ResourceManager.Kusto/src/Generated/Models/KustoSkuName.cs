// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> SKU name. </summary>
    public readonly partial struct KustoSkuName : IEquatable<KustoSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DevNoSlaStandardD11V2Value = "Dev(No SLA)_Standard_D11_v2";
        private const string DevNoSlaStandardE2aV4Value = "Dev(No SLA)_Standard_E2a_v4";
        private const string StandardD11V2Value = "Standard_D11_v2";
        private const string StandardD12V2Value = "Standard_D12_v2";
        private const string StandardD13V2Value = "Standard_D13_v2";
        private const string StandardD14V2Value = "Standard_D14_v2";
        private const string StandardD32dV4Value = "Standard_D32d_v4";
        private const string StandardD16dV5Value = "Standard_D16d_v5";
        private const string StandardD32dV5Value = "Standard_D32d_v5";
        private const string StandardDS13V21TBPSValue = "Standard_DS13_v2+1TB_PS";
        private const string StandardDS13V22TBPSValue = "Standard_DS13_v2+2TB_PS";
        private const string StandardDS14V23TBPSValue = "Standard_DS14_v2+3TB_PS";
        private const string StandardDS14V24TBPSValue = "Standard_DS14_v2+4TB_PS";
        private const string StandardL4sValue = "Standard_L4s";
        private const string StandardL8sValue = "Standard_L8s";
        private const string StandardL16sValue = "Standard_L16s";
        private const string StandardL8sV2Value = "Standard_L8s_v2";
        private const string StandardL16sV2Value = "Standard_L16s_v2";
        private const string StandardL8sV3Value = "Standard_L8s_v3";
        private const string StandardL16sV3Value = "Standard_L16s_v3";
        private const string StandardL32sV3Value = "Standard_L32s_v3";
        private const string StandardL8asV3Value = "Standard_L8as_v3";
        private const string StandardL16asV3Value = "Standard_L16as_v3";
        private const string StandardL32asV3Value = "Standard_L32as_v3";
        private const string StandardE64iV3Value = "Standard_E64i_v3";
        private const string StandardE80idsV4Value = "Standard_E80ids_v4";
        private const string StandardE2aV4Value = "Standard_E2a_v4";
        private const string StandardE4aV4Value = "Standard_E4a_v4";
        private const string StandardE8aV4Value = "Standard_E8a_v4";
        private const string StandardE16aV4Value = "Standard_E16a_v4";
        private const string StandardE8asV41TBPSValue = "Standard_E8as_v4+1TB_PS";
        private const string StandardE8asV42TBPSValue = "Standard_E8as_v4+2TB_PS";
        private const string StandardE16asV43TBPSValue = "Standard_E16as_v4+3TB_PS";
        private const string StandardE16asV44TBPSValue = "Standard_E16as_v4+4TB_PS";
        private const string StandardE8asV51TBPSValue = "Standard_E8as_v5+1TB_PS";
        private const string StandardE8asV52TBPSValue = "Standard_E8as_v5+2TB_PS";
        private const string StandardE16asV53TBPSValue = "Standard_E16as_v5+3TB_PS";
        private const string StandardE16asV54TBPSValue = "Standard_E16as_v5+4TB_PS";
        private const string StandardE2adsV5Value = "Standard_E2ads_v5";
        private const string StandardE4adsV5Value = "Standard_E4ads_v5";
        private const string StandardE8adsV5Value = "Standard_E8ads_v5";
        private const string StandardE16adsV5Value = "Standard_E16ads_v5";
        private const string StandardEC8asV51TBPSValue = "Standard_EC8as_v5+1TB_PS";
        private const string StandardEC8asV52TBPSValue = "Standard_EC8as_v5+2TB_PS";
        private const string StandardEC16asV53TBPSValue = "Standard_EC16as_v5+3TB_PS";
        private const string StandardEC16asV54TBPSValue = "Standard_EC16as_v5+4TB_PS";
        private const string StandardEC8adsV5Value = "Standard_EC8ads_v5";
        private const string StandardEC16adsV5Value = "Standard_EC16ads_v5";
        private const string StandardE8sV41TBPSValue = "Standard_E8s_v4+1TB_PS";
        private const string StandardE8sV42TBPSValue = "Standard_E8s_v4+2TB_PS";
        private const string StandardE16sV43TBPSValue = "Standard_E16s_v4+3TB_PS";
        private const string StandardE16sV44TBPSValue = "Standard_E16s_v4+4TB_PS";
        private const string StandardE8sV51TBPSValue = "Standard_E8s_v5+1TB_PS";
        private const string StandardE8sV52TBPSValue = "Standard_E8s_v5+2TB_PS";
        private const string StandardE16sV53TBPSValue = "Standard_E16s_v5+3TB_PS";
        private const string StandardE16sV54TBPSValue = "Standard_E16s_v5+4TB_PS";
        private const string StandardE2dV4Value = "Standard_E2d_v4";
        private const string StandardE4dV4Value = "Standard_E4d_v4";
        private const string StandardE8dV4Value = "Standard_E8d_v4";
        private const string StandardE16dV4Value = "Standard_E16d_v4";
        private const string StandardE2dV5Value = "Standard_E2d_v5";
        private const string StandardE4dV5Value = "Standard_E4d_v5";
        private const string StandardE8dV5Value = "Standard_E8d_v5";
        private const string StandardE16dV5Value = "Standard_E16d_v5";

        /// <summary> Dev(No SLA)_Standard_D11_v2. </summary>
        public static KustoSkuName DevNoSlaStandardD11V2 { get; } = new KustoSkuName(DevNoSlaStandardD11V2Value);
        /// <summary> Dev(No SLA)_Standard_E2a_v4. </summary>
        public static KustoSkuName DevNoSlaStandardE2aV4 { get; } = new KustoSkuName(DevNoSlaStandardE2aV4Value);
        /// <summary> Standard_D11_v2. </summary>
        public static KustoSkuName StandardD11V2 { get; } = new KustoSkuName(StandardD11V2Value);
        /// <summary> Standard_D12_v2. </summary>
        public static KustoSkuName StandardD12V2 { get; } = new KustoSkuName(StandardD12V2Value);
        /// <summary> Standard_D13_v2. </summary>
        public static KustoSkuName StandardD13V2 { get; } = new KustoSkuName(StandardD13V2Value);
        /// <summary> Standard_D14_v2. </summary>
        public static KustoSkuName StandardD14V2 { get; } = new KustoSkuName(StandardD14V2Value);
        /// <summary> Standard_D32d_v4. </summary>
        public static KustoSkuName StandardD32dV4 { get; } = new KustoSkuName(StandardD32dV4Value);
        /// <summary> Standard_D16d_v5. </summary>
        public static KustoSkuName StandardD16dV5 { get; } = new KustoSkuName(StandardD16dV5Value);
        /// <summary> Standard_D32d_v5. </summary>
        public static KustoSkuName StandardD32dV5 { get; } = new KustoSkuName(StandardD32dV5Value);
        /// <summary> Standard_DS13_v2+1TB_PS. </summary>
        public static KustoSkuName StandardDS13V21TBPS { get; } = new KustoSkuName(StandardDS13V21TBPSValue);
        /// <summary> Standard_DS13_v2+2TB_PS. </summary>
        public static KustoSkuName StandardDS13V22TBPS { get; } = new KustoSkuName(StandardDS13V22TBPSValue);
        /// <summary> Standard_DS14_v2+3TB_PS. </summary>
        public static KustoSkuName StandardDS14V23TBPS { get; } = new KustoSkuName(StandardDS14V23TBPSValue);
        /// <summary> Standard_DS14_v2+4TB_PS. </summary>
        public static KustoSkuName StandardDS14V24TBPS { get; } = new KustoSkuName(StandardDS14V24TBPSValue);
        /// <summary> Standard_L4s. </summary>
        public static KustoSkuName StandardL4s { get; } = new KustoSkuName(StandardL4sValue);
        /// <summary> Standard_L8s. </summary>
        public static KustoSkuName StandardL8s { get; } = new KustoSkuName(StandardL8sValue);
        /// <summary> Standard_L16s. </summary>
        public static KustoSkuName StandardL16s { get; } = new KustoSkuName(StandardL16sValue);
        /// <summary> Standard_L8s_v2. </summary>
        public static KustoSkuName StandardL8sV2 { get; } = new KustoSkuName(StandardL8sV2Value);
        /// <summary> Standard_L16s_v2. </summary>
        public static KustoSkuName StandardL16sV2 { get; } = new KustoSkuName(StandardL16sV2Value);
        /// <summary> Standard_L8s_v3. </summary>
        public static KustoSkuName StandardL8sV3 { get; } = new KustoSkuName(StandardL8sV3Value);
        /// <summary> Standard_L16s_v3. </summary>
        public static KustoSkuName StandardL16sV3 { get; } = new KustoSkuName(StandardL16sV3Value);
        /// <summary> Standard_L32s_v3. </summary>
        public static KustoSkuName StandardL32sV3 { get; } = new KustoSkuName(StandardL32sV3Value);
        /// <summary> Standard_L8as_v3. </summary>
        public static KustoSkuName StandardL8asV3 { get; } = new KustoSkuName(StandardL8asV3Value);
        /// <summary> Standard_L16as_v3. </summary>
        public static KustoSkuName StandardL16asV3 { get; } = new KustoSkuName(StandardL16asV3Value);
        /// <summary> Standard_L32as_v3. </summary>
        public static KustoSkuName StandardL32asV3 { get; } = new KustoSkuName(StandardL32asV3Value);
        /// <summary> Standard_E64i_v3. </summary>
        public static KustoSkuName StandardE64iV3 { get; } = new KustoSkuName(StandardE64iV3Value);
        /// <summary> Standard_E80ids_v4. </summary>
        public static KustoSkuName StandardE80idsV4 { get; } = new KustoSkuName(StandardE80idsV4Value);
        /// <summary> Standard_E2a_v4. </summary>
        public static KustoSkuName StandardE2aV4 { get; } = new KustoSkuName(StandardE2aV4Value);
        /// <summary> Standard_E4a_v4. </summary>
        public static KustoSkuName StandardE4aV4 { get; } = new KustoSkuName(StandardE4aV4Value);
        /// <summary> Standard_E8a_v4. </summary>
        public static KustoSkuName StandardE8aV4 { get; } = new KustoSkuName(StandardE8aV4Value);
        /// <summary> Standard_E16a_v4. </summary>
        public static KustoSkuName StandardE16aV4 { get; } = new KustoSkuName(StandardE16aV4Value);
        /// <summary> Standard_E8as_v4+1TB_PS. </summary>
        public static KustoSkuName StandardE8asV41TBPS { get; } = new KustoSkuName(StandardE8asV41TBPSValue);
        /// <summary> Standard_E8as_v4+2TB_PS. </summary>
        public static KustoSkuName StandardE8asV42TBPS { get; } = new KustoSkuName(StandardE8asV42TBPSValue);
        /// <summary> Standard_E16as_v4+3TB_PS. </summary>
        public static KustoSkuName StandardE16asV43TBPS { get; } = new KustoSkuName(StandardE16asV43TBPSValue);
        /// <summary> Standard_E16as_v4+4TB_PS. </summary>
        public static KustoSkuName StandardE16asV44TBPS { get; } = new KustoSkuName(StandardE16asV44TBPSValue);
        /// <summary> Standard_E8as_v5+1TB_PS. </summary>
        public static KustoSkuName StandardE8asV51TBPS { get; } = new KustoSkuName(StandardE8asV51TBPSValue);
        /// <summary> Standard_E8as_v5+2TB_PS. </summary>
        public static KustoSkuName StandardE8asV52TBPS { get; } = new KustoSkuName(StandardE8asV52TBPSValue);
        /// <summary> Standard_E16as_v5+3TB_PS. </summary>
        public static KustoSkuName StandardE16asV53TBPS { get; } = new KustoSkuName(StandardE16asV53TBPSValue);
        /// <summary> Standard_E16as_v5+4TB_PS. </summary>
        public static KustoSkuName StandardE16asV54TBPS { get; } = new KustoSkuName(StandardE16asV54TBPSValue);
        /// <summary> Standard_E2ads_v5. </summary>
        public static KustoSkuName StandardE2adsV5 { get; } = new KustoSkuName(StandardE2adsV5Value);
        /// <summary> Standard_E4ads_v5. </summary>
        public static KustoSkuName StandardE4adsV5 { get; } = new KustoSkuName(StandardE4adsV5Value);
        /// <summary> Standard_E8ads_v5. </summary>
        public static KustoSkuName StandardE8adsV5 { get; } = new KustoSkuName(StandardE8adsV5Value);
        /// <summary> Standard_E16ads_v5. </summary>
        public static KustoSkuName StandardE16adsV5 { get; } = new KustoSkuName(StandardE16adsV5Value);
        /// <summary> Standard_EC8as_v5+1TB_PS. </summary>
        public static KustoSkuName StandardEC8asV51TBPS { get; } = new KustoSkuName(StandardEC8asV51TBPSValue);
        /// <summary> Standard_EC8as_v5+2TB_PS. </summary>
        public static KustoSkuName StandardEC8asV52TBPS { get; } = new KustoSkuName(StandardEC8asV52TBPSValue);
        /// <summary> Standard_EC16as_v5+3TB_PS. </summary>
        public static KustoSkuName StandardEC16asV53TBPS { get; } = new KustoSkuName(StandardEC16asV53TBPSValue);
        /// <summary> Standard_EC16as_v5+4TB_PS. </summary>
        public static KustoSkuName StandardEC16asV54TBPS { get; } = new KustoSkuName(StandardEC16asV54TBPSValue);
        /// <summary> Standard_EC8ads_v5. </summary>
        public static KustoSkuName StandardEC8adsV5 { get; } = new KustoSkuName(StandardEC8adsV5Value);
        /// <summary> Standard_EC16ads_v5. </summary>
        public static KustoSkuName StandardEC16adsV5 { get; } = new KustoSkuName(StandardEC16adsV5Value);
        /// <summary> Standard_E8s_v4+1TB_PS. </summary>
        public static KustoSkuName StandardE8sV41TBPS { get; } = new KustoSkuName(StandardE8sV41TBPSValue);
        /// <summary> Standard_E8s_v4+2TB_PS. </summary>
        public static KustoSkuName StandardE8sV42TBPS { get; } = new KustoSkuName(StandardE8sV42TBPSValue);
        /// <summary> Standard_E16s_v4+3TB_PS. </summary>
        public static KustoSkuName StandardE16sV43TBPS { get; } = new KustoSkuName(StandardE16sV43TBPSValue);
        /// <summary> Standard_E16s_v4+4TB_PS. </summary>
        public static KustoSkuName StandardE16sV44TBPS { get; } = new KustoSkuName(StandardE16sV44TBPSValue);
        /// <summary> Standard_E8s_v5+1TB_PS. </summary>
        public static KustoSkuName StandardE8sV51TBPS { get; } = new KustoSkuName(StandardE8sV51TBPSValue);
        /// <summary> Standard_E8s_v5+2TB_PS. </summary>
        public static KustoSkuName StandardE8sV52TBPS { get; } = new KustoSkuName(StandardE8sV52TBPSValue);
        /// <summary> Standard_E16s_v5+3TB_PS. </summary>
        public static KustoSkuName StandardE16sV53TBPS { get; } = new KustoSkuName(StandardE16sV53TBPSValue);
        /// <summary> Standard_E16s_v5+4TB_PS. </summary>
        public static KustoSkuName StandardE16sV54TBPS { get; } = new KustoSkuName(StandardE16sV54TBPSValue);
        /// <summary> Standard_E2d_v4. </summary>
        public static KustoSkuName StandardE2dV4 { get; } = new KustoSkuName(StandardE2dV4Value);
        /// <summary> Standard_E4d_v4. </summary>
        public static KustoSkuName StandardE4dV4 { get; } = new KustoSkuName(StandardE4dV4Value);
        /// <summary> Standard_E8d_v4. </summary>
        public static KustoSkuName StandardE8dV4 { get; } = new KustoSkuName(StandardE8dV4Value);
        /// <summary> Standard_E16d_v4. </summary>
        public static KustoSkuName StandardE16dV4 { get; } = new KustoSkuName(StandardE16dV4Value);
        /// <summary> Standard_E2d_v5. </summary>
        public static KustoSkuName StandardE2dV5 { get; } = new KustoSkuName(StandardE2dV5Value);
        /// <summary> Standard_E4d_v5. </summary>
        public static KustoSkuName StandardE4dV5 { get; } = new KustoSkuName(StandardE4dV5Value);
        /// <summary> Standard_E8d_v5. </summary>
        public static KustoSkuName StandardE8dV5 { get; } = new KustoSkuName(StandardE8dV5Value);
        /// <summary> Standard_E16d_v5. </summary>
        public static KustoSkuName StandardE16dV5 { get; } = new KustoSkuName(StandardE16dV5Value);
        /// <summary> Determines if two <see cref="KustoSkuName"/> values are the same. </summary>
        public static bool operator ==(KustoSkuName left, KustoSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoSkuName"/> values are not the same. </summary>
        public static bool operator !=(KustoSkuName left, KustoSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoSkuName"/>. </summary>
        public static implicit operator KustoSkuName(string value) => new KustoSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
