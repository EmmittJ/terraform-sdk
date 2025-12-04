using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GooglePrivatecaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// SubjectConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubjectConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubjectConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectConfig block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlock> SubjectConfig
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlock>>("subject_config");
        set => SetArgument("subject_config", value);
    }

    /// <summary>
    /// SubjectKeyId block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectKeyId block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectKeyIdBlock>? SubjectKeyId
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectKeyIdBlock>>("subject_key_id");
        set => SetArgument("subject_key_id", value);
    }

    /// <summary>
    /// X509Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "X509Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 X509Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 X509Config block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock> X509Config
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock>>("x509_config");
        set => SetArgument("x509_config", value);
    }

}

/// <summary>
/// Block type for subject_config in GooglePrivatecaCertificateAuthorityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_config";

    /// <summary>
    /// Subject block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectBlock> Subject
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectBlock>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// SubjectAltName block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAltName block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectAltNameBlock>? SubjectAltName
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectAltNameBlock>>("subject_alt_name");
        set => SetArgument("subject_alt_name", value);
    }

}

/// <summary>
/// Block type for subject in GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject";

    /// <summary>
    /// The common name of the distinguished name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommonName is required")]
    public required TerraformValue<string> CommonName
    {
        get => GetArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The country code of the subject.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The locality or city of the subject.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The organization of the subject.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The organizational unit of the subject.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnit
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The postal code of the subject.
    /// </summary>
    public TerraformValue<string>? PostalCode
    {
        get => GetArgument<TerraformValue<string>>("postal_code");
        set => SetArgument("postal_code", value);
    }

    /// <summary>
    /// The province, territory, or regional state of the subject.
    /// </summary>
    public TerraformValue<string>? Province
    {
        get => GetArgument<TerraformValue<string>>("province");
        set => SetArgument("province", value);
    }

    /// <summary>
    /// The street address of the subject.
    /// </summary>
    public TerraformValue<string>? StreetAddress
    {
        get => GetArgument<TerraformValue<string>>("street_address");
        set => SetArgument("street_address", value);
    }

}

/// <summary>
/// Block type for subject_alt_name in GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockSubjectConfigBlockSubjectAltNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alt_name";

    /// <summary>
    /// Contains only valid, fully-qualified host names.
    /// </summary>
    public TerraformList<string>? DnsNames
    {
        get => GetArgument<TerraformList<string>>("dns_names");
        set => SetArgument("dns_names", value);
    }

    /// <summary>
    /// Contains only valid RFC 2822 E-mail addresses.
    /// </summary>
    public TerraformList<string>? EmailAddresses
    {
        get => GetArgument<TerraformList<string>>("email_addresses");
        set => SetArgument("email_addresses", value);
    }

    /// <summary>
    /// Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.
    /// </summary>
    public TerraformList<string>? IpAddresses
    {
        get => GetArgument<TerraformList<string>>("ip_addresses");
        set => SetArgument("ip_addresses", value);
    }

    /// <summary>
    /// Contains only valid RFC 3986 URIs.
    /// </summary>
    public TerraformList<string>? Uris
    {
        get => GetArgument<TerraformList<string>>("uris");
        set => SetArgument("uris", value);
    }

}

/// <summary>
/// Block type for subject_key_id in GooglePrivatecaCertificateAuthorityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockSubjectKeyIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_key_id";

    /// <summary>
    /// The value of the KeyId in lowercase hexadecimal.
    /// </summary>
    public TerraformValue<string>? KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

}

/// <summary>
/// Block type for x509_config in GooglePrivatecaCertificateAuthorityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "x509_config";

    /// <summary>
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    public TerraformList<string>? AiaOcspServers
    {
        get => GetArgument<TerraformList<string>>("aia_ocsp_servers");
        set => SetArgument("aia_ocsp_servers", value);
    }

    /// <summary>
    /// AdditionalExtensions block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlock>? AdditionalExtensions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlock>>("additional_extensions");
        set => SetArgument("additional_extensions", value);
    }

    /// <summary>
    /// CaOptions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaOptions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CaOptions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaOptions block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockCaOptionsBlock> CaOptions
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockCaOptionsBlock>>("ca_options");
        set => SetArgument("ca_options", value);
    }

    /// <summary>
    /// KeyUsage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyUsage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyUsage block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock> KeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// NameConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NameConstraints block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockNameConstraintsBlock>? NameConstraints
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockNameConstraintsBlock>>("name_constraints");
        set => SetArgument("name_constraints", value);
    }

    /// <summary>
    /// PolicyIds block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockPolicyIdsBlock>? PolicyIds
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockPolicyIdsBlock>>("policy_ids");
        set => SetArgument("policy_ids", value);
    }

}

/// <summary>
/// Block type for additional_extensions in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("critical");
        set => SetArgument("critical", value);
    }

    /// <summary>
    /// The value of this X.509 extension. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// ObjectId block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ObjectId block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectId block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlockObjectIdBlock> ObjectId
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlockObjectIdBlock>>("object_id");
        set => SetArgument("object_id", value);
    }

}

/// <summary>
/// Block type for object_id in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockAdditionalExtensionsBlockObjectIdBlock : TerraformBlock
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
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for ca_options in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockCaOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ca_options";

    /// <summary>
    /// When true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to true.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsCa is required")]
    public required TerraformValue<bool> IsCa
    {
        get => GetArgument<TerraformValue<bool>>("is_ca");
        set => SetArgument("is_ca", value);
    }

    /// <summary>
    /// Refers to the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. Setting the value to 0
    /// requires setting &#39;zero_max_issuer_path_length = true&#39;.
    /// </summary>
    public TerraformValue<double>? MaxIssuerPathLength
    {
        get => GetArgument<TerraformValue<double>>("max_issuer_path_length");
        set => SetArgument("max_issuer_path_length", value);
    }

    /// <summary>
    /// When true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to false.
    /// If both &#39;is_ca&#39; and &#39;non_ca&#39; are unset, the extension will be omitted from the CA certificate.
    /// </summary>
    public TerraformValue<bool>? NonCa
    {
        get => GetArgument<TerraformValue<bool>>("non_ca");
        set => SetArgument("non_ca", value);
    }

    /// <summary>
    /// When true, the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension will be set to 0.
    /// If both &#39;max_issuer_path_length&#39; and &#39;zero_max_issuer_path_length&#39; are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    public TerraformValue<bool>? ZeroMaxIssuerPathLength
    {
        get => GetArgument<TerraformValue<bool>>("zero_max_issuer_path_length");
        set => SetArgument("zero_max_issuer_path_length", value);
    }

}

/// <summary>
/// Block type for key_usage in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock : TerraformBlock
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
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockBaseKeyUsageBlock> BaseKeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockBaseKeyUsageBlock>>("base_key_usage");
        set => SetArgument("base_key_usage", value);
    }

    /// <summary>
    /// ExtendedKeyUsage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtendedKeyUsage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExtendedKeyUsage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedKeyUsage block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockExtendedKeyUsageBlock> ExtendedKeyUsage
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockExtendedKeyUsageBlock>>("extended_key_usage");
        set => SetArgument("extended_key_usage", value);
    }

    /// <summary>
    /// UnknownExtendedKeyUsages block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>? UnknownExtendedKeyUsages
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>>("unknown_extended_key_usages");
        set => SetArgument("unknown_extended_key_usages", value);
    }

}

/// <summary>
/// Block type for base_key_usage in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockBaseKeyUsageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("cert_sign");
        set => SetArgument("cert_sign", value);
    }

    /// <summary>
    /// The key may be used for cryptographic commitments. Note that this may also be referred to as &amp;quot;non-repudiation&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? ContentCommitment
    {
        get => GetArgument<TerraformValue<bool>>("content_commitment");
        set => SetArgument("content_commitment", value);
    }

    /// <summary>
    /// The key may be used sign certificate revocation lists.
    /// </summary>
    public TerraformValue<bool>? CrlSign
    {
        get => GetArgument<TerraformValue<bool>>("crl_sign");
        set => SetArgument("crl_sign", value);
    }

    /// <summary>
    /// The key may be used to encipher data.
    /// </summary>
    public TerraformValue<bool>? DataEncipherment
    {
        get => GetArgument<TerraformValue<bool>>("data_encipherment");
        set => SetArgument("data_encipherment", value);
    }

    /// <summary>
    /// The key may be used to decipher only.
    /// </summary>
    public TerraformValue<bool>? DecipherOnly
    {
        get => GetArgument<TerraformValue<bool>>("decipher_only");
        set => SetArgument("decipher_only", value);
    }

    /// <summary>
    /// The key may be used for digital signatures.
    /// </summary>
    public TerraformValue<bool>? DigitalSignature
    {
        get => GetArgument<TerraformValue<bool>>("digital_signature");
        set => SetArgument("digital_signature", value);
    }

    /// <summary>
    /// The key may be used to encipher only.
    /// </summary>
    public TerraformValue<bool>? EncipherOnly
    {
        get => GetArgument<TerraformValue<bool>>("encipher_only");
        set => SetArgument("encipher_only", value);
    }

    /// <summary>
    /// The key may be used in a key agreement protocol.
    /// </summary>
    public TerraformValue<bool>? KeyAgreement
    {
        get => GetArgument<TerraformValue<bool>>("key_agreement");
        set => SetArgument("key_agreement", value);
    }

    /// <summary>
    /// The key may be used to encipher other keys.
    /// </summary>
    public TerraformValue<bool>? KeyEncipherment
    {
        get => GetArgument<TerraformValue<bool>>("key_encipherment");
        set => SetArgument("key_encipherment", value);
    }

}

/// <summary>
/// Block type for extended_key_usage in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockExtendedKeyUsageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("client_auth");
        set => SetArgument("client_auth", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &amp;quot;Signing of downloadable executable code client authentication&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? CodeSigning
    {
        get => GetArgument<TerraformValue<bool>>("code_signing");
        set => SetArgument("code_signing", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &amp;quot;Email protection&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? EmailProtection
    {
        get => GetArgument<TerraformValue<bool>>("email_protection");
        set => SetArgument("email_protection", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &amp;quot;Signing OCSP responses&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? OcspSigning
    {
        get => GetArgument<TerraformValue<bool>>("ocsp_signing");
        set => SetArgument("ocsp_signing", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &amp;quot;TLS WWW server authentication&amp;quot;, though regularly used for non-WWW TLS.
    /// </summary>
    public TerraformValue<bool>? ServerAuth
    {
        get => GetArgument<TerraformValue<bool>>("server_auth");
        set => SetArgument("server_auth", value);
    }

    /// <summary>
    /// Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &amp;quot;Binding the hash of an object to a time&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? TimeStamping
    {
        get => GetArgument<TerraformValue<bool>>("time_stamping");
        set => SetArgument("time_stamping", value);
    }

}

/// <summary>
/// Block type for unknown_extended_key_usages in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock : TerraformBlock
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
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for name_constraints in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockNameConstraintsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("critical");
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
        get => GetArgument<TerraformList<string>>("excluded_dns_names");
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
        get => GetArgument<TerraformList<string>>("excluded_email_addresses");
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
        get => GetArgument<TerraformList<string>>("excluded_ip_ranges");
        set => SetArgument("excluded_ip_ranges", value);
    }

    /// <summary>
    /// Contains the excluded URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like &#39;.example.com&#39;)
    /// </summary>
    public TerraformList<string>? ExcludedUris
    {
        get => GetArgument<TerraformList<string>>("excluded_uris");
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
        get => GetArgument<TerraformList<string>>("permitted_dns_names");
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
        get => GetArgument<TerraformList<string>>("permitted_email_addresses");
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
        get => GetArgument<TerraformList<string>>("permitted_ip_ranges");
        set => SetArgument("permitted_ip_ranges", value);
    }

    /// <summary>
    /// Contains the permitted URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like &#39;.example.com&#39;)
    /// </summary>
    public TerraformList<string>? PermittedUris
    {
        get => GetArgument<TerraformList<string>>("permitted_uris");
        set => SetArgument("permitted_uris", value);
    }

}

/// <summary>
/// Block type for policy_ids in GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityConfigBlockX509ConfigBlockPolicyIdsBlock : TerraformBlock
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
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}


/// <summary>
/// Block type for key_spec in GooglePrivatecaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityKeySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_spec";

    /// <summary>
    /// The algorithm to use for creating a managed Cloud KMS key for a for a simplified
    /// experience. All managed keys will be have their ProtectionLevel as HSM. Possible values: [&amp;quot;SIGN_HASH_ALGORITHM_UNSPECIFIED&amp;quot;, &amp;quot;RSA_PSS_2048_SHA256&amp;quot;, &amp;quot;RSA_PSS_3072_SHA256&amp;quot;, &amp;quot;RSA_PSS_4096_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_2048_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_3072_SHA256&amp;quot;, &amp;quot;RSA_PKCS1_4096_SHA256&amp;quot;, &amp;quot;EC_P256_SHA256&amp;quot;, &amp;quot;EC_P384_SHA384&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The resource name for an existing Cloud KMS CryptoKeyVersion in the format
    /// &#39;projects/*/locations/*/keyRings/*/cryptoKeys/*/cryptoKeyVersions/*&#39;.
    /// </summary>
    public TerraformValue<string>? CloudKmsKeyVersion
    {
        get => GetArgument<TerraformValue<string>>("cloud_kms_key_version");
        set => SetArgument("cloud_kms_key_version", value);
    }

}


/// <summary>
/// Block type for subordinate_config in GooglePrivatecaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthoritySubordinateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subordinate_config";

    /// <summary>
    /// This can refer to a CertificateAuthority that was used to create a
    /// subordinate CertificateAuthority. This field is used for information
    /// and usability purposes only. The resource name is in the format
    /// &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    public TerraformValue<string>? CertificateAuthority
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority");
        set => SetArgument("certificate_authority", value);
    }

    /// <summary>
    /// PemIssuerChain block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PemIssuerChain block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthoritySubordinateConfigBlockPemIssuerChainBlock>? PemIssuerChain
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthoritySubordinateConfigBlockPemIssuerChainBlock>>("pem_issuer_chain");
        set => SetArgument("pem_issuer_chain", value);
    }

}

/// <summary>
/// Block type for pem_issuer_chain in GooglePrivatecaCertificateAuthoritySubordinateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthoritySubordinateConfigBlockPemIssuerChainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pem_issuer_chain";

    /// <summary>
    /// Expected to be in leaf-to-root order according to RFC 5246.
    /// </summary>
    public TerraformList<string>? PemCertificates
    {
        get => GetArgument<TerraformList<string>>("pem_certificates");
        set => SetArgument("pem_certificates", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePrivatecaCertificateAuthority.
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateAuthorityTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_defined_access_urls in GooglePrivatecaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_defined_access_urls";

    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CA certificate is published that is specified by users.
    /// </summary>
    public TerraformList<string>? AiaIssuingCertificateUrls
    {
        get => GetArgument<TerraformList<string>>("aia_issuing_certificate_urls");
        set => SetArgument("aia_issuing_certificate_urls", value);
    }

    /// <summary>
    /// A list of URLs where this CertificateAuthority&#39;s CRLs are published that is specified by users.
    /// </summary>
    public TerraformList<string>? CrlAccessUrls
    {
        get => GetArgument<TerraformList<string>>("crl_access_urls");
        set => SetArgument("crl_access_urls", value);
    }

}


/// <summary>
/// Represents a google_privateca_certificate_authority Terraform resource.
/// Manages a google_privateca_certificate_authority resource.
/// </summary>
public partial class GooglePrivatecaCertificateAuthority(string name) : TerraformResource("google_privateca_certificate_authority", name)
{
    /// <summary>
    /// The user provided Resource ID for this Certificate Authority.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityId is required")]
    public required TerraformValue<string> CertificateAuthorityId
    {
        get => GetArgument<TerraformValue<string>>("certificate_authority_id");
        set => SetArgument("certificate_authority_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the CertificateAuthority.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the CertificateAuthority will fail.
    /// When the field is set to false, deleting the CertificateAuthority is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// Desired state of the CertificateAuthority. Set this field to &#39;STAGED&#39; to create a &#39;STAGED&#39; root CA.
    /// Possible values: ENABLED, DISABLED, STAGED.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// The name of a Cloud Storage bucket where this CertificateAuthority will publish content,
    /// such as the CA certificate and CRLs. This must be a bucket name, without any prefixes
    /// (such as &#39;gs://&#39;) or suffixes (such as &#39;.googleapis.com&#39;). For example, to use a bucket named
    /// my-bucket, you would simply specify &#39;my-bucket&#39;. If not specified, a managed bucket will be
    /// created.
    /// </summary>
    public TerraformValue<string>? GcsBucket
    {
        get => GetArgument<TerraformValue<string>>("gcs_bucket");
        set => SetArgument("gcs_bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// This field allows the CA to be deleted even if the CA has active certs. Active certs include both unrevoked and unexpired certs.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformValue<bool>? IgnoreActiveCertificatesOnDeletion
    {
        get => GetArgument<TerraformValue<bool>>("ignore_active_certificates_on_deletion");
        set => SetArgument("ignore_active_certificates_on_deletion", value);
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
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Lifetime
    {
        get => GetArgument<TerraformValue<string>>("lifetime");
        set => SetArgument("lifetime", value);
    }

    /// <summary>
    /// Location of the CertificateAuthority. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The signed CA certificate issued from the subordinated CA&#39;s CSR. This is needed when activating the subordiante CA with a third party issuer.
    /// </summary>
    public TerraformValue<string>? PemCaCertificate
    {
        get => GetArgument<TerraformValue<string>>("pem_ca_certificate");
        set => SetArgument("pem_ca_certificate", value);
    }

    /// <summary>
    /// The name of the CaPool this Certificate Authority belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pool is required")]
    public required TerraformValue<string> Pool
    {
        get => GetArgument<TerraformValue<string>>("pool");
        set => SetArgument("pool", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If this flag is set, the Certificate Authority will be deleted as soon as
    /// possible without a 30-day grace period where undeletion would have been
    /// allowed. If you proceed, there will be no way to recover this CA.
    /// Use with care. Defaults to &#39;false&#39;.
    /// </summary>
    public TerraformValue<bool>? SkipGracePeriod
    {
        get => GetArgument<TerraformValue<bool>>("skip_grace_period");
        set => SetArgument("skip_grace_period", value);
    }

    /// <summary>
    /// The Type of this CertificateAuthority.
    /// 
    /// ~&amp;gt; **Note:** For &#39;SUBORDINATE&#39; Certificate Authorities, they need to
    /// be activated before they can issue certificates. Default value: &amp;quot;SELF_SIGNED&amp;quot; Possible values: [&amp;quot;SELF_SIGNED&amp;quot;, &amp;quot;SUBORDINATE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// URLs for accessing content published by this CA, such as the CA certificate and CRLs.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessUrls
        => AsReference("access_urls");

    /// <summary>
    /// The time at which this CertificateAuthority was created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource name for this CertificateAuthority in the format
    /// projects/*/locations/*/certificateAuthorities/*.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// This CertificateAuthority&#39;s certificate chain, including the current
    /// CertificateAuthority&#39;s certificate. Ordered such that the root issuer is the final
    /// element (consistent with RFC 5246). For a self-signed CA, this will only list the current
    /// CertificateAuthority&#39;s certificate.
    /// </summary>
    public TerraformList<string> PemCaCertificates
        => AsReference("pem_ca_certificates");

    /// <summary>
    /// The State for this CertificateAuthority.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The time at which this CertificateAuthority was updated.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// KeySpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeySpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeySpec block(s) allowed")]
    public required TerraformList<GooglePrivatecaCertificateAuthorityKeySpecBlock> KeySpec
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateAuthorityKeySpecBlock>>("key_spec");
        set => SetArgument("key_spec", value);
    }

    /// <summary>
    /// SubordinateConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubordinateConfig block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>? SubordinateConfig
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthoritySubordinateConfigBlock>>("subordinate_config");
        set => SetArgument("subordinate_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePrivatecaCertificateAuthorityTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePrivatecaCertificateAuthorityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserDefinedAccessUrls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserDefinedAccessUrls block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>? UserDefinedAccessUrls
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateAuthorityUserDefinedAccessUrlsBlock>>("user_defined_access_urls");
        set => SetArgument("user_defined_access_urls", value);
    }

}
