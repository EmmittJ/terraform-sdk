using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_spec in GooglePrivatecaCaPool.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// The resource name for an existing Cloud KMS key in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*&#39;.
    /// </summary>
    public TerraformValue<string>? CloudKmsKey
    {
        get => new TerraformReference<string>(this, "cloud_kms_key");
        set => SetArgument("cloud_kms_key", value);
    }

}


/// <summary>
/// Block type for issuance_policy in GooglePrivatecaCaPool.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "issuance_policy";

    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    public TerraformValue<string>? BackdateDuration
    {
        get => new TerraformReference<string>(this, "backdate_duration");
        set => SetArgument("backdate_duration", value);
    }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&#39;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    public TerraformValue<string>? MaximumLifetime
    {
        get => new TerraformReference<string>(this, "maximum_lifetime");
        set => SetArgument("maximum_lifetime", value);
    }

    /// <summary>
    /// AllowedIssuanceModes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedIssuanceModes block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedIssuanceModesBlock>? AllowedIssuanceModes
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedIssuanceModesBlock>>("allowed_issuance_modes");
        set => SetArgument("allowed_issuance_modes", value);
    }

    /// <summary>
    /// AllowedKeyTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlock>? AllowedKeyTypes
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlock>>("allowed_key_types");
        set => SetArgument("allowed_key_types", value);
    }

    /// <summary>
    /// BaselineValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineValues block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock>? BaselineValues
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock>>("baseline_values");
        set => SetArgument("baseline_values", value);
    }

    /// <summary>
    /// IdentityConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlock>? IdentityConstraints
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlock>>("identity_constraints");
        set => SetArgument("identity_constraints", value);
    }

}

/// <summary>
/// Block type for allowed_issuance_modes in GooglePrivatecaCaPoolIssuancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockAllowedIssuanceModesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_issuance_modes";

    /// <summary>
    /// When true, allows callers to create Certificates by specifying a CertificateConfig.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowConfigBasedIssuance is required")]
    public required TerraformValue<bool> AllowConfigBasedIssuance
    {
        get => new TerraformReference<bool>(this, "allow_config_based_issuance");
        set => SetArgument("allow_config_based_issuance", value);
    }

    /// <summary>
    /// When true, allows callers to create Certificates by specifying a CSR.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowCsrBasedIssuance is required")]
    public required TerraformValue<bool> AllowCsrBasedIssuance
    {
        get => new TerraformReference<bool>(this, "allow_csr_based_issuance");
        set => SetArgument("allow_csr_based_issuance", value);
    }

}

/// <summary>
/// Block type for allowed_key_types in GooglePrivatecaCaPoolIssuancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_key_types";

    /// <summary>
    /// EllipticCurve block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EllipticCurve block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockEllipticCurveBlock>? EllipticCurve
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockEllipticCurveBlock>>("elliptic_curve");
        set => SetArgument("elliptic_curve", value);
    }

    /// <summary>
    /// Rsa block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rsa block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockRsaBlock>? Rsa
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockRsaBlock>>("rsa");
        set => SetArgument("rsa", value);
    }

}

/// <summary>
/// Block type for elliptic_curve in GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockEllipticCurveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elliptic_curve";

    /// <summary>
    /// The algorithm used. Possible values: [&amp;quot;ECDSA_P256&amp;quot;, &amp;quot;ECDSA_P384&amp;quot;, &amp;quot;EDDSA_25519&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SignatureAlgorithm is required")]
    public required TerraformValue<string> SignatureAlgorithm
    {
        get => new TerraformReference<string>(this, "signature_algorithm");
        set => SetArgument("signature_algorithm", value);
    }

}

/// <summary>
/// Block type for rsa in GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockAllowedKeyTypesBlockRsaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rsa";

    /// <summary>
    /// The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service will not enforce an explicit upper bound on RSA modulus sizes.
    /// </summary>
    public TerraformValue<string>? MaxModulusSize
    {
        get => new TerraformReference<string>(this, "max_modulus_size");
        set => SetArgument("max_modulus_size", value);
    }

    /// <summary>
    /// The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service-level min RSA modulus size will continue to apply.
    /// </summary>
    public TerraformValue<string>? MinModulusSize
    {
        get => new TerraformReference<string>(this, "min_modulus_size");
        set => SetArgument("min_modulus_size", value);
    }

}

/// <summary>
/// Block type for baseline_values in GooglePrivatecaCaPoolIssuancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "baseline_values";

    /// <summary>
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    public TerraformList<string>? AiaOcspServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "aia_ocsp_servers").ResolveNodes(ctx));
        set => SetArgument("aia_ocsp_servers", value);
    }

    /// <summary>
    /// AdditionalExtensions block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlock>? AdditionalExtensions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlock>>("additional_extensions");
        set => SetArgument("additional_extensions", value);
    }

    /// <summary>
    /// CaOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CaOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaOptions block(s) allowed")]
    public required TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockCaOptionsBlock> CaOptions
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockCaOptionsBlock>>("ca_options");
        set => SetArgument("ca_options", value);
    }

    /// <summary>
    /// KeyUsage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyUsage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyUsage block(s) allowed")]
    public required TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock> KeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// NameConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NameConstraints block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockNameConstraintsBlock>? NameConstraints
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockNameConstraintsBlock>>("name_constraints");
        set => SetArgument("name_constraints", value);
    }

    /// <summary>
    /// PolicyIds block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockPolicyIdsBlock>? PolicyIds
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockPolicyIdsBlock>>("policy_ids");
        set => SetArgument("policy_ids", value);
    }

}

/// <summary>
/// Block type for additional_extensions in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_extensions";

    /// <summary>
    /// Indicates whether or not this extension is critical (i.e., if the client does not know how to
    /// handle this extension, the client should consider this to be an error).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Critical is required")]
    public required TerraformValue<bool> Critical
    {
        get => new TerraformReference<bool>(this, "critical");
        set => SetArgument("critical", value);
    }

    /// <summary>
    /// The value of this X.509 extension. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// ObjectId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ObjectId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectId block(s) allowed")]
    public required TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlockObjectIdBlock> ObjectId
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlockObjectIdBlock>>("object_id");
        set => SetArgument("object_id", value);
    }

}

/// <summary>
/// Block type for object_id in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockAdditionalExtensionsBlockObjectIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_id";

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "object_id_path").ResolveNodes(ctx));
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for ca_options in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockCaOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ca_options";

    /// <summary>
    /// When true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to true.
    /// </summary>
    public TerraformValue<bool>? IsCa
    {
        get => new TerraformReference<bool>(this, "is_ca");
        set => SetArgument("is_ca", value);
    }

    /// <summary>
    /// Refers to the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    public TerraformValue<double>? MaxIssuerPathLength
    {
        get => new TerraformReference<double>(this, "max_issuer_path_length");
        set => SetArgument("max_issuer_path_length", value);
    }

    /// <summary>
    /// When true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to false.
    /// If both &#39;is_ca&#39; and &#39;non_ca&#39; are unset, the extension will be omitted from the CA certificate.
    /// </summary>
    public TerraformValue<bool>? NonCa
    {
        get => new TerraformReference<bool>(this, "non_ca");
        set => SetArgument("non_ca", value);
    }

    /// <summary>
    /// When true, the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension will be set to 0.
    /// if both &#39;max_issuer_path_length&#39; and &#39;zero_max_issuer_path_length&#39; are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    public TerraformValue<bool>? ZeroMaxIssuerPathLength
    {
        get => new TerraformReference<bool>(this, "zero_max_issuer_path_length");
        set => SetArgument("zero_max_issuer_path_length", value);
    }

}

/// <summary>
/// Block type for key_usage in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_usage";

    /// <summary>
    /// BaseKeyUsage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseKeyUsage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BaseKeyUsage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseKeyUsage block(s) allowed")]
    public required TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockBaseKeyUsageBlock> BaseKeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockBaseKeyUsageBlock>>("base_key_usage");
        set => SetArgument("base_key_usage", value);
    }

    /// <summary>
    /// ExtendedKeyUsage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtendedKeyUsage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExtendedKeyUsage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedKeyUsage block(s) allowed")]
    public required TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockExtendedKeyUsageBlock> ExtendedKeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockExtendedKeyUsageBlock>>("extended_key_usage");
        set => SetArgument("extended_key_usage", value);
    }

    /// <summary>
    /// UnknownExtendedKeyUsages block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>? UnknownExtendedKeyUsages
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>>("unknown_extended_key_usages");
        set => SetArgument("unknown_extended_key_usages", value);
    }

}

/// <summary>
/// Block type for base_key_usage in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockBaseKeyUsageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "base_key_usage";

    /// <summary>
    /// The key may be used to sign certificates.
    /// </summary>
    public TerraformValue<bool>? CertSign
    {
        get => new TerraformReference<bool>(this, "cert_sign");
        set => SetArgument("cert_sign", value);
    }

    /// <summary>
    /// The key may be used for cryptographic commitments. Note that this may also be referred to as &amp;quot;non-repudiation&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? ContentCommitment
    {
        get => new TerraformReference<bool>(this, "content_commitment");
        set => SetArgument("content_commitment", value);
    }

    /// <summary>
    /// The key may be used sign certificate revocation lists.
    /// </summary>
    public TerraformValue<bool>? CrlSign
    {
        get => new TerraformReference<bool>(this, "crl_sign");
        set => SetArgument("crl_sign", value);
    }

    /// <summary>
    /// The key may be used to encipher data.
    /// </summary>
    public TerraformValue<bool>? DataEncipherment
    {
        get => new TerraformReference<bool>(this, "data_encipherment");
        set => SetArgument("data_encipherment", value);
    }

    /// <summary>
    /// The key may be used to decipher only.
    /// </summary>
    public TerraformValue<bool>? DecipherOnly
    {
        get => new TerraformReference<bool>(this, "decipher_only");
        set => SetArgument("decipher_only", value);
    }

    /// <summary>
    /// The key may be used for digital signatures.
    /// </summary>
    public TerraformValue<bool>? DigitalSignature
    {
        get => new TerraformReference<bool>(this, "digital_signature");
        set => SetArgument("digital_signature", value);
    }

    /// <summary>
    /// The key may be used to encipher only.
    /// </summary>
    public TerraformValue<bool>? EncipherOnly
    {
        get => new TerraformReference<bool>(this, "encipher_only");
        set => SetArgument("encipher_only", value);
    }

    /// <summary>
    /// The key may be used in a key agreement protocol.
    /// </summary>
    public TerraformValue<bool>? KeyAgreement
    {
        get => new TerraformReference<bool>(this, "key_agreement");
        set => SetArgument("key_agreement", value);
    }

    /// <summary>
    /// The key may be used to encipher other keys.
    /// </summary>
    public TerraformValue<bool>? KeyEncipherment
    {
        get => new TerraformReference<bool>(this, "key_encipherment");
        set => SetArgument("key_encipherment", value);
    }

}

/// <summary>
/// Block type for extended_key_usage in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockExtendedKeyUsageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extended_key_usage";

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &amp;quot;TLS WWW client authentication&amp;quot;, though regularly used for non-WWW TLS.
    /// </summary>
    public TerraformValue<bool>? ClientAuth
    {
        get => new TerraformReference<bool>(this, "client_auth");
        set => SetArgument("client_auth", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &amp;quot;Signing of downloadable executable code client authentication&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? CodeSigning
    {
        get => new TerraformReference<bool>(this, "code_signing");
        set => SetArgument("code_signing", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &amp;quot;Email protection&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? EmailProtection
    {
        get => new TerraformReference<bool>(this, "email_protection");
        set => SetArgument("email_protection", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &amp;quot;Signing OCSP responses&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? OcspSigning
    {
        get => new TerraformReference<bool>(this, "ocsp_signing");
        set => SetArgument("ocsp_signing", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &amp;quot;TLS WWW server authentication&amp;quot;, though regularly used for non-WWW TLS.
    /// </summary>
    public TerraformValue<bool>? ServerAuth
    {
        get => new TerraformReference<bool>(this, "server_auth");
        set => SetArgument("server_auth", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &amp;quot;Binding the hash of an object to a time&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? TimeStamping
    {
        get => new TerraformReference<bool>(this, "time_stamping");
        set => SetArgument("time_stamping", value);
    }

}

/// <summary>
/// Block type for unknown_extended_key_usages in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unknown_extended_key_usages";

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "object_id_path").ResolveNodes(ctx));
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for name_constraints in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockNameConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "name_constraints";

    /// <summary>
    /// Indicates whether or not the name constraints are marked critical.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Critical is required")]
    public required TerraformValue<bool> Critical
    {
        get => new TerraformReference<bool>(this, "critical");
        set => SetArgument("critical", value);
    }

    /// <summary>
    /// Contains excluded DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, &#39;example.com&#39;, &#39;www.example.com&#39;, &#39;www.sub.example.com&#39;
    /// would satisfy &#39;example.com&#39; while &#39;example1.com&#39; does not.
    /// </summary>
    public TerraformList<string>? ExcludedDnsNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_dns_names").ResolveNodes(ctx));
        set => SetArgument("excluded_dns_names", value);
    }

    /// <summary>
    /// Contains the excluded email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. &#39;.example.com&#39;) to indicate
    /// all email addresses in that domain.
    /// </summary>
    public TerraformList<string>? ExcludedEmailAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_email_addresses").ResolveNodes(ctx));
        set => SetArgument("excluded_email_addresses", value);
    }

    /// <summary>
    /// Contains the excluded IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    public TerraformList<string>? ExcludedIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("excluded_ip_ranges", value);
    }

    /// <summary>
    /// Contains the excluded URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like &#39;.example.com&#39;)
    /// </summary>
    public TerraformList<string>? ExcludedUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_uris").ResolveNodes(ctx));
        set => SetArgument("excluded_uris", value);
    }

    /// <summary>
    /// Contains permitted DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, &#39;example.com&#39;, &#39;www.example.com&#39;, &#39;www.sub.example.com&#39;
    /// would satisfy &#39;example.com&#39; while &#39;example1.com&#39; does not.
    /// </summary>
    public TerraformList<string>? PermittedDnsNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "permitted_dns_names").ResolveNodes(ctx));
        set => SetArgument("permitted_dns_names", value);
    }

    /// <summary>
    /// Contains the permitted email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. &#39;.example.com&#39;) to indicate
    /// all email addresses in that domain.
    /// </summary>
    public TerraformList<string>? PermittedEmailAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "permitted_email_addresses").ResolveNodes(ctx));
        set => SetArgument("permitted_email_addresses", value);
    }

    /// <summary>
    /// Contains the permitted IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    public TerraformList<string>? PermittedIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "permitted_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("permitted_ip_ranges", value);
    }

    /// <summary>
    /// Contains the permitted URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like &#39;.example.com&#39;)
    /// </summary>
    public TerraformList<string>? PermittedUris
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "permitted_uris").ResolveNodes(ctx));
        set => SetArgument("permitted_uris", value);
    }

}

/// <summary>
/// Block type for policy_ids in GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockBaselineValuesBlockPolicyIdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_ids";

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "object_id_path").ResolveNodes(ctx));
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for identity_constraints in GooglePrivatecaCaPoolIssuancePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_constraints";

    /// <summary>
    /// If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectAltNamesPassthrough is required")]
    public required TerraformValue<bool> AllowSubjectAltNamesPassthrough
    {
        get => new TerraformReference<bool>(this, "allow_subject_alt_names_passthrough");
        set => SetArgument("allow_subject_alt_names_passthrough", value);
    }

    /// <summary>
    /// If this is set, the Subject field may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    public required TerraformValue<bool> AllowSubjectPassthrough
    {
        get => new TerraformReference<bool>(this, "allow_subject_passthrough");
        set => SetArgument("allow_subject_passthrough", value);
    }

    /// <summary>
    /// CelExpression block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CelExpression block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlockCelExpressionBlock>? CelExpression
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlockCelExpressionBlock>>("cel_expression");
        set => SetArgument("cel_expression", value);
    }

}

/// <summary>
/// Block type for cel_expression in GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolIssuancePolicyBlockIdentityConstraintsBlockCelExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cel_expression";

    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for publishing_options in GooglePrivatecaCaPool.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCaPoolPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publishing_options";

    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&#39;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM. Possible values: [&amp;quot;PEM&amp;quot;, &amp;quot;DER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EncodingFormat
    {
        get => new TerraformReference<string>(this, "encoding_format");
        set => SetArgument("encoding_format", value);
    }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CA certificate and includes its URL in the &amp;quot;Authority Information Access&amp;quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCaCert is required")]
    public required TerraformValue<bool> PublishCaCert
    {
        get => new TerraformReference<bool>(this, "publish_ca_cert");
        set => SetArgument("publish_ca_cert", value);
    }

    /// <summary>
    /// When true, publishes each CertificateAuthority&#39;s CRL and includes its URL in the &amp;quot;CRL Distribution Points&amp;quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishCrl is required")]
    public required TerraformValue<bool> PublishCrl
    {
        get => new TerraformReference<bool>(this, "publish_crl");
        set => SetArgument("publish_crl", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePrivatecaCaPool.
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCaPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_privateca_ca_pool Terraform resource.
/// Manages a google_privateca_ca_pool resource.
/// </summary>
public partial class GooglePrivatecaCaPool(string name) : TerraformResource("google_privateca_ca_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels with user-defined metadata.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;:
    /// &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name for this CaPool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Tier of this CaPool. Possible values: [&amp;quot;ENTERPRISE&amp;quot;, &amp;quot;DEVOPS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// IssuancePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssuancePolicy block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlock>? IssuancePolicy
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolIssuancePolicyBlock>>("issuance_policy");
        set => SetArgument("issuance_policy", value);
    }

    /// <summary>
    /// PublishingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishingOptions block(s) allowed")]
    public TerraformList<GooglePrivatecaCaPoolPublishingOptionsBlock>? PublishingOptions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCaPoolPublishingOptionsBlock>>("publishing_options");
        set => SetArgument("publishing_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePrivatecaCaPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePrivatecaCaPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
