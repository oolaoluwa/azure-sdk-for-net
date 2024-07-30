// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The language codes supported for input by ImageAnalysisSkill. </summary>
    public readonly partial struct ImageAnalysisSkillLanguage : IEquatable<ImageAnalysisSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageAnalysisSkillLanguage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageAnalysisSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArValue = "ar";
        private const string AzValue = "az";
        private const string BgValue = "bg";
        private const string BsValue = "bs";
        private const string CaValue = "ca";
        private const string CsValue = "cs";
        private const string CyValue = "cy";
        private const string DaValue = "da";
        private const string DeValue = "de";
        private const string ElValue = "el";
        private const string EnValue = "en";
        private const string EsValue = "es";
        private const string EtValue = "et";
        private const string EuValue = "eu";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string GaValue = "ga";
        private const string GlValue = "gl";
        private const string HeValue = "he";
        private const string HiValue = "hi";
        private const string HrValue = "hr";
        private const string HuValue = "hu";
        private const string IdValue = "id";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string KkValue = "kk";
        private const string KoValue = "ko";
        private const string LtValue = "lt";
        private const string LvValue = "lv";
        private const string MkValue = "mk";
        private const string MsValue = "ms";
        private const string NbValue = "nb";
        private const string NlValue = "nl";
        private const string PlValue = "pl";
        private const string PrsValue = "prs";
        private const string PtBRValue = "pt-BR";
        private const string PtValue = "pt";
        private const string PtPTValue = "pt-PT";
        private const string RoValue = "ro";
        private const string RuValue = "ru";
        private const string SkValue = "sk";
        private const string SlValue = "sl";
        private const string SrCyrlValue = "sr-Cyrl";
        private const string SrLatnValue = "sr-Latn";
        private const string SvValue = "sv";
        private const string ThValue = "th";
        private const string TrValue = "tr";
        private const string UkValue = "uk";
        private const string ViValue = "vi";
        private const string ZhValue = "zh";
        private const string ZhHansValue = "zh-Hans";
        private const string ZhHantValue = "zh-Hant";

        /// <summary> Arabic. </summary>
        public static ImageAnalysisSkillLanguage Ar { get; } = new ImageAnalysisSkillLanguage(ArValue);
        /// <summary> Azerbaijani. </summary>
        public static ImageAnalysisSkillLanguage Az { get; } = new ImageAnalysisSkillLanguage(AzValue);
        /// <summary> Bulgarian. </summary>
        public static ImageAnalysisSkillLanguage Bg { get; } = new ImageAnalysisSkillLanguage(BgValue);
        /// <summary> Bosnian Latin. </summary>
        public static ImageAnalysisSkillLanguage Bs { get; } = new ImageAnalysisSkillLanguage(BsValue);
        /// <summary> Catalan. </summary>
        public static ImageAnalysisSkillLanguage Ca { get; } = new ImageAnalysisSkillLanguage(CaValue);
        /// <summary> Czech. </summary>
        public static ImageAnalysisSkillLanguage Cs { get; } = new ImageAnalysisSkillLanguage(CsValue);
        /// <summary> Welsh. </summary>
        public static ImageAnalysisSkillLanguage Cy { get; } = new ImageAnalysisSkillLanguage(CyValue);
        /// <summary> Danish. </summary>
        public static ImageAnalysisSkillLanguage Da { get; } = new ImageAnalysisSkillLanguage(DaValue);
        /// <summary> German. </summary>
        public static ImageAnalysisSkillLanguage De { get; } = new ImageAnalysisSkillLanguage(DeValue);
        /// <summary> Greek. </summary>
        public static ImageAnalysisSkillLanguage El { get; } = new ImageAnalysisSkillLanguage(ElValue);
        /// <summary> English. </summary>
        public static ImageAnalysisSkillLanguage En { get; } = new ImageAnalysisSkillLanguage(EnValue);
        /// <summary> Spanish. </summary>
        public static ImageAnalysisSkillLanguage Es { get; } = new ImageAnalysisSkillLanguage(EsValue);
        /// <summary> Estonian. </summary>
        public static ImageAnalysisSkillLanguage Et { get; } = new ImageAnalysisSkillLanguage(EtValue);
        /// <summary> Basque. </summary>
        public static ImageAnalysisSkillLanguage Eu { get; } = new ImageAnalysisSkillLanguage(EuValue);
        /// <summary> Finnish. </summary>
        public static ImageAnalysisSkillLanguage Fi { get; } = new ImageAnalysisSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static ImageAnalysisSkillLanguage Fr { get; } = new ImageAnalysisSkillLanguage(FrValue);
        /// <summary> Irish. </summary>
        public static ImageAnalysisSkillLanguage Ga { get; } = new ImageAnalysisSkillLanguage(GaValue);
        /// <summary> Galician. </summary>
        public static ImageAnalysisSkillLanguage Gl { get; } = new ImageAnalysisSkillLanguage(GlValue);
        /// <summary> Hebrew. </summary>
        public static ImageAnalysisSkillLanguage He { get; } = new ImageAnalysisSkillLanguage(HeValue);
        /// <summary> Hindi. </summary>
        public static ImageAnalysisSkillLanguage Hi { get; } = new ImageAnalysisSkillLanguage(HiValue);
        /// <summary> Croatian. </summary>
        public static ImageAnalysisSkillLanguage Hr { get; } = new ImageAnalysisSkillLanguage(HrValue);
        /// <summary> Hungarian. </summary>
        public static ImageAnalysisSkillLanguage Hu { get; } = new ImageAnalysisSkillLanguage(HuValue);
        /// <summary> Indonesian. </summary>
        public static ImageAnalysisSkillLanguage Id { get; } = new ImageAnalysisSkillLanguage(IdValue);
        /// <summary> Italian. </summary>
        public static ImageAnalysisSkillLanguage It { get; } = new ImageAnalysisSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static ImageAnalysisSkillLanguage Ja { get; } = new ImageAnalysisSkillLanguage(JaValue);
        /// <summary> Kazakh. </summary>
        public static ImageAnalysisSkillLanguage Kk { get; } = new ImageAnalysisSkillLanguage(KkValue);
        /// <summary> Korean. </summary>
        public static ImageAnalysisSkillLanguage Ko { get; } = new ImageAnalysisSkillLanguage(KoValue);
        /// <summary> Lithuanian. </summary>
        public static ImageAnalysisSkillLanguage Lt { get; } = new ImageAnalysisSkillLanguage(LtValue);
        /// <summary> Latvian. </summary>
        public static ImageAnalysisSkillLanguage Lv { get; } = new ImageAnalysisSkillLanguage(LvValue);
        /// <summary> Macedonian. </summary>
        public static ImageAnalysisSkillLanguage Mk { get; } = new ImageAnalysisSkillLanguage(MkValue);
        /// <summary> Malay Malaysia. </summary>
        public static ImageAnalysisSkillLanguage Ms { get; } = new ImageAnalysisSkillLanguage(MsValue);
        /// <summary> Norwegian (Bokmal). </summary>
        public static ImageAnalysisSkillLanguage Nb { get; } = new ImageAnalysisSkillLanguage(NbValue);
        /// <summary> Dutch. </summary>
        public static ImageAnalysisSkillLanguage Nl { get; } = new ImageAnalysisSkillLanguage(NlValue);
        /// <summary> Polish. </summary>
        public static ImageAnalysisSkillLanguage Pl { get; } = new ImageAnalysisSkillLanguage(PlValue);
        /// <summary> Dari. </summary>
        public static ImageAnalysisSkillLanguage Prs { get; } = new ImageAnalysisSkillLanguage(PrsValue);
        /// <summary> Portuguese-Brazil. </summary>
        public static ImageAnalysisSkillLanguage PtBR { get; } = new ImageAnalysisSkillLanguage(PtBRValue);
        /// <summary> Portuguese-Portugal. </summary>
        public static ImageAnalysisSkillLanguage Pt { get; } = new ImageAnalysisSkillLanguage(PtValue);
        /// <summary> Portuguese-Portugal. </summary>
        public static ImageAnalysisSkillLanguage PtPT { get; } = new ImageAnalysisSkillLanguage(PtPTValue);
        /// <summary> Romanian. </summary>
        public static ImageAnalysisSkillLanguage Ro { get; } = new ImageAnalysisSkillLanguage(RoValue);
        /// <summary> Russian. </summary>
        public static ImageAnalysisSkillLanguage Ru { get; } = new ImageAnalysisSkillLanguage(RuValue);
        /// <summary> Slovak. </summary>
        public static ImageAnalysisSkillLanguage Sk { get; } = new ImageAnalysisSkillLanguage(SkValue);
        /// <summary> Slovenian. </summary>
        public static ImageAnalysisSkillLanguage Sl { get; } = new ImageAnalysisSkillLanguage(SlValue);
        /// <summary> Serbian - Cyrillic RS. </summary>
        public static ImageAnalysisSkillLanguage SrCyrl { get; } = new ImageAnalysisSkillLanguage(SrCyrlValue);
        /// <summary> Serbian - Latin RS. </summary>
        public static ImageAnalysisSkillLanguage SrLatn { get; } = new ImageAnalysisSkillLanguage(SrLatnValue);
        /// <summary> Swedish. </summary>
        public static ImageAnalysisSkillLanguage Sv { get; } = new ImageAnalysisSkillLanguage(SvValue);
        /// <summary> Thai. </summary>
        public static ImageAnalysisSkillLanguage Th { get; } = new ImageAnalysisSkillLanguage(ThValue);
        /// <summary> Turkish. </summary>
        public static ImageAnalysisSkillLanguage Tr { get; } = new ImageAnalysisSkillLanguage(TrValue);
        /// <summary> Ukrainian. </summary>
        public static ImageAnalysisSkillLanguage Uk { get; } = new ImageAnalysisSkillLanguage(UkValue);
        /// <summary> Vietnamese. </summary>
        public static ImageAnalysisSkillLanguage Vi { get; } = new ImageAnalysisSkillLanguage(ViValue);
        /// <summary> Chinese Simplified. </summary>
        public static ImageAnalysisSkillLanguage Zh { get; } = new ImageAnalysisSkillLanguage(ZhValue);
        /// <summary> Chinese Simplified. </summary>
        public static ImageAnalysisSkillLanguage ZhHans { get; } = new ImageAnalysisSkillLanguage(ZhHansValue);
        /// <summary> Chinese Traditional. </summary>
        public static ImageAnalysisSkillLanguage ZhHant { get; } = new ImageAnalysisSkillLanguage(ZhHantValue);
        /// <summary> Determines if two <see cref="ImageAnalysisSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(ImageAnalysisSkillLanguage left, ImageAnalysisSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageAnalysisSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(ImageAnalysisSkillLanguage left, ImageAnalysisSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageAnalysisSkillLanguage"/>. </summary>
        public static implicit operator ImageAnalysisSkillLanguage(string value) => new ImageAnalysisSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageAnalysisSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageAnalysisSkillLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
