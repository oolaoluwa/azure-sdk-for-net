// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Security.CodeTransparency
{
    /// <summary> Model factory for models. </summary>
    public static partial class SecurityCodeTransparencyModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CreateEntryResult"/>. </summary>
        /// <param name="operationId"> String representing the operation id submitted. </param>
        /// <returns> A new <see cref="CodeTransparency.CreateEntryResult"/> instance for mocking. </returns>
        public static CreateEntryResult CreateEntryResult(string operationId = null)
        {
            return new CreateEntryResult(operationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.GetOperationResult"/>. </summary>
        /// <param name="entryId"> ID of the transaction. Only if status is Succeeded. </param>
        /// <param name="error"> Error in json format. Only if Status is Failed. </param>
        /// <param name="operationId"> OperationId. </param>
        /// <param name="status"> Status of the operation. </param>
        /// <returns> A new <see cref="CodeTransparency.GetOperationResult"/> instance for mocking. </returns>
        public static GetOperationResult GetOperationResult(string entryId = null, string error = null, string operationId = null, OperationStatus status = default)
        {
            return new GetOperationResult(entryId, error, operationId, status, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.ListOperationResult"/>. </summary>
        /// <param name="operations"> List of operations. </param>
        /// <returns> A new <see cref="CodeTransparency.ListOperationResult"/> instance for mocking. </returns>
        public static ListOperationResult ListOperationResult(IEnumerable<GetOperationResult> operations = null)
        {
            operations ??= new List<GetOperationResult>();

            return new ListOperationResult(operations?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.ParametersResult"/>. </summary>
        /// <param name="serviceCertificate"></param>
        /// <param name="serviceId"></param>
        /// <param name="signatureAlgorithm"></param>
        /// <param name="treeAlgorithm"></param>
        /// <returns> A new <see cref="CodeTransparency.ParametersResult"/> instance for mocking. </returns>
        public static ParametersResult ParametersResult(string serviceCertificate = null, string serviceId = null, string signatureAlgorithm = null, string treeAlgorithm = null)
        {
            return new ParametersResult(serviceCertificate, serviceId, signatureAlgorithm, treeAlgorithm, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.DidDocument"/>. </summary>
        /// <param name="id"> String representing a DID issuer. </param>
        /// <param name="assertionMethod"> List of public keys used for receipt endorsement verification. </param>
        /// <returns> A new <see cref="CodeTransparency.DidDocument"/> instance for mocking. </returns>
        public static DidDocument DidDocument(string id = null, IEnumerable<DidDocumentKey> assertionMethod = null)
        {
            assertionMethod ??= new List<DidDocumentKey>();

            return new DidDocument(id, assertionMethod?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.DidDocumentKey"/>. </summary>
        /// <param name="id"> Key identifier. </param>
        /// <param name="controller"> Key controller - similar to DID issuer. </param>
        /// <param name="type"> Key type. </param>
        /// <param name="publicKeyJwk"> Serialized public key in JWK format. </param>
        /// <returns> A new <see cref="CodeTransparency.DidDocumentKey"/> instance for mocking. </returns>
        public static DidDocumentKey DidDocumentKey(string id = null, string controller = null, DidDocumentKeyType type = default, JsonWebKey publicKeyJwk = null)
        {
            return new DidDocumentKey(id, controller, type, publicKeyJwk, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.JsonWebKey"/>. </summary>
        /// <param name="alg">
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </param>
        /// <param name="crv"> The "crv" (curve) parameter identifies the curve type. </param>
        /// <param name="d"> RSA private exponent or ECC private key. </param>
        /// <param name="dp"> RSA Private Key Parameter. </param>
        /// <param name="dq"> RSA Private Key Parameter. </param>
        /// <param name="e"> RSA public exponent, in Base64. </param>
        /// <param name="k"> Symmetric key. </param>
        /// <param name="kid">
        /// The "kid" (key ID) parameter is used to match a specific key.  This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the "kid" value is
        /// unspecified.  When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values.  (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The "kid"
        /// value is a case-sensitive string.
        /// </param>
        /// <param name="kty">
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The "kty" value is a case-sensitive string.
        /// </param>
        /// <param name="n"> RSA modulus, in Base64. </param>
        /// <param name="p"> RSA secret prime. </param>
        /// <param name="q"> RSA secret prime, with p &lt; q. </param>
        /// <param name="qi"> RSA Private Key Parameter. </param>
        /// <param name="use">
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </param>
        /// <param name="x"> X coordinate for the Elliptic Curve point. </param>
        /// <param name="x5c">
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </param>
        /// <param name="y"> Y coordinate for the Elliptic Curve point. </param>
        /// <returns> A new <see cref="CodeTransparency.JsonWebKey"/> instance for mocking. </returns>
        public static JsonWebKey JsonWebKey(string alg = null, string crv = null, string d = null, string dp = null, string dq = null, string e = null, string k = null, string kid = null, string kty = null, string n = null, string p = null, string q = null, string qi = null, string use = null, string x = null, IEnumerable<string> x5c = null, string y = null)
        {
            x5c ??= new List<string>();

            return new JsonWebKey(
                alg,
                crv,
                d,
                dp,
                dq,
                e,
                k,
                kid,
                kty,
                n,
                p,
                q,
                qi,
                use,
                x,
                x5c?.ToList(),
                y,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfiguration"/>. </summary>
        /// <param name="policy"></param>
        /// <param name="authentication"></param>
        /// <param name="serviceIdentifier"> did:web identifier. </param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfiguration"/> instance for mocking. </returns>
        public static CodeTransparencyConfiguration CodeTransparencyConfiguration(CodeTransparencyConfigurationPolicy policy = null, CodeTransparencyConfigurationAuthentication authentication = null, string serviceIdentifier = null)
        {
            return new CodeTransparencyConfiguration(policy, authentication, serviceIdentifier, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationPolicy"/>. </summary>
        /// <param name="acceptedAlgorithms"></param>
        /// <param name="acceptedDidIssuers"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationPolicy"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationPolicy CodeTransparencyConfigurationPolicy(IEnumerable<string> acceptedAlgorithms = null, IEnumerable<string> acceptedDidIssuers = null)
        {
            acceptedAlgorithms ??= new List<string>();
            acceptedDidIssuers ??= new List<string>();

            return new CodeTransparencyConfigurationPolicy(acceptedAlgorithms?.ToList(), acceptedDidIssuers?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationAuthentication"/>. </summary>
        /// <param name="allowUnauthenticated"></param>
        /// <param name="jwt"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationAuthentication"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationAuthentication CodeTransparencyConfigurationAuthentication(bool allowUnauthenticated = default, CodeTransparencyConfigurationAuthenticationJwt jwt = null)
        {
            return new CodeTransparencyConfigurationAuthentication(allowUnauthenticated, jwt, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationAuthenticationJwt"/>. </summary>
        /// <param name="requiredClaims"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationAuthenticationJwt"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationAuthenticationJwt CodeTransparencyConfigurationAuthenticationJwt(IReadOnlyDictionary<string, string> requiredClaims = null)
        {
            requiredClaims ??= new Dictionary<string, string>();

            return new CodeTransparencyConfigurationAuthenticationJwt(requiredClaims, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.VersionResult"/>. </summary>
        /// <param name="scittVersion"> Version of the CodeTransparency service. </param>
        /// <returns> A new <see cref="CodeTransparency.VersionResult"/> instance for mocking. </returns>
        public static VersionResult VersionResult(string scittVersion = null)
        {
            return new VersionResult(scittVersion, serializedAdditionalRawData: null);
        }
    }
}
