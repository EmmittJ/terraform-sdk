using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for identity_constraints in GooglePrivatecaCertificateTemplate.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplateIdentityConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_constraints";

    /// <summary>
    /// Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectAltNamesPassthrough is required")]
    public required TerraformValue<bool> AllowSubjectAltNamesPassthrough
    {
        get => GetArgument<TerraformValue<bool>>("allow_subject_alt_names_passthrough");
        set => SetArgument("allow_subject_alt_names_passthrough", value);
    }

    /// <summary>
    /// Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowSubjectPassthrough is required")]
    public required TerraformValue<bool> AllowSubjectPassthrough
    {
        get => GetArgument<TerraformValue<bool>>("allow_subject_passthrough");
        set => SetArgument("allow_subject_passthrough", value);
    }

    /// <summary>
    /// CelExpression block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CelExpression block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplateIdentityConstraintsBlockCelExpressionBlock>? CelExpression
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplateIdentityConstraintsBlockCelExpressionBlock>>("cel_expression");
        set => SetArgument("cel_expression", value);
    }

}

/// <summary>
/// Block type for cel_expression in GooglePrivatecaCertificateTemplateIdentityConstraintsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplateIdentityConstraintsBlockCelExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cel_expression";

    /// <summary>
    /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for passthrough_extensions in GooglePrivatecaCertificateTemplate.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "passthrough_extensions";

    /// <summary>
    /// Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.
    /// </summary>
    public TerraformList<string>? KnownExtensions
    {
        get => GetArgument<TerraformList<string>>("known_extensions");
        set => SetArgument("known_extensions", value);
    }

    /// <summary>
    /// AdditionalExtensions block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlockAdditionalExtensionsBlock>? AdditionalExtensions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlockAdditionalExtensionsBlock>>("additional_extensions");
        set => SetArgument("additional_extensions", value);
    }

}

/// <summary>
/// Block type for additional_extensions in GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePassthroughExtensionsBlockAdditionalExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_extensions";

    /// <summary>
    /// Required. The parts of an OID path. The most significant parts of the path come first.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}


/// <summary>
/// Block type for predefined_values in GooglePrivatecaCertificateTemplate.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predefined_values";

    /// <summary>
    /// Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &amp;quot;Authority Information Access&amp;quot; extension in the certificate.
    /// </summary>
    public TerraformList<string>? AiaOcspServers
    {
        get => GetArgument<TerraformList<string>>("aia_ocsp_servers");
        set => SetArgument("aia_ocsp_servers", value);
    }

    /// <summary>
    /// AdditionalExtensions block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlock>? AdditionalExtensions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlock>>("additional_extensions");
        set => SetArgument("additional_extensions", value);
    }

    /// <summary>
    /// CaOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CaOptions block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockCaOptionsBlock>? CaOptions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockCaOptionsBlock>>("ca_options");
        set => SetArgument("ca_options", value);
    }

    /// <summary>
    /// KeyUsage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyUsage block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock>? KeyUsage
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// NameConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NameConstraints block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockNameConstraintsBlock>? NameConstraints
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockNameConstraintsBlock>>("name_constraints");
        set => SetArgument("name_constraints", value);
    }

    /// <summary>
    /// PolicyIds block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockPolicyIdsBlock>? PolicyIds
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockPolicyIdsBlock>>("policy_ids");
        set => SetArgument("policy_ids", value);
    }

}

/// <summary>
/// Block type for additional_extensions in GooglePrivatecaCertificateTemplatePredefinedValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_extensions";

    /// <summary>
    /// Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).
    /// </summary>
    public TerraformValue<bool>? Critical
    {
        get => GetArgument<TerraformValue<bool>>("critical");
        set => SetArgument("critical", value);
    }

    /// <summary>
    /// Required. The value of this X.509 extension.
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
    public required TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlockObjectIdBlock> ObjectId
    {
        get => GetRequiredArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlockObjectIdBlock>>("object_id");
        set => SetArgument("object_id", value);
    }

}

/// <summary>
/// Block type for object_id in GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockAdditionalExtensionsBlockObjectIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_id";

    /// <summary>
    /// Required. The parts of an OID path. The most significant parts of the path come first.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for ca_options in GooglePrivatecaCertificateTemplatePredefinedValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockCaOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ca_options";

    /// <summary>
    /// Optional. Refers to the &amp;quot;CA&amp;quot; X.509 extension, which is a boolean value. When this value is true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to true.
    /// </summary>
    public TerraformValue<bool>? IsCa
    {
        get => GetArgument<TerraformValue<bool>>("is_ca");
        set => SetArgument("is_ca", value);
    }

    /// <summary>
    /// Optional. Refers to the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    public TerraformValue<double>? MaxIssuerPathLength
    {
        get => GetArgument<TerraformValue<double>>("max_issuer_path_length");
        set => SetArgument("max_issuer_path_length", value);
    }

    /// <summary>
    /// Optional. When true, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to null and omitted from the CA certificate.
    /// If both &#39;is_ca&#39; and &#39;null_ca&#39; are unset, the &amp;quot;CA&amp;quot; in Basic Constraints extension will be set to false.
    /// Note that the behavior when &#39;is_ca = false&#39; for this resource is different from the behavior in the Certificate Authority, Certificate and CaPool resources.
    /// </summary>
    public TerraformValue<bool>? NullCa
    {
        get => GetArgument<TerraformValue<bool>>("null_ca");
        set => SetArgument("null_ca", value);
    }

    /// <summary>
    /// Optional. When true, the &amp;quot;path length constraint&amp;quot; in Basic Constraints extension will be set to 0.
    /// if both &#39;max_issuer_path_length&#39; and &#39;zero_max_issuer_path_length&#39; are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    public TerraformValue<bool>? ZeroMaxIssuerPathLength
    {
        get => GetArgument<TerraformValue<bool>>("zero_max_issuer_path_length");
        set => SetArgument("zero_max_issuer_path_length", value);
    }

}

/// <summary>
/// Block type for key_usage in GooglePrivatecaCertificateTemplatePredefinedValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_usage";

    /// <summary>
    /// BaseKeyUsage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseKeyUsage block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockBaseKeyUsageBlock>? BaseKeyUsage
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockBaseKeyUsageBlock>>("base_key_usage");
        set => SetArgument("base_key_usage", value);
    }

    /// <summary>
    /// ExtendedKeyUsage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedKeyUsage block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockExtendedKeyUsageBlock>? ExtendedKeyUsage
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockExtendedKeyUsageBlock>>("extended_key_usage");
        set => SetArgument("extended_key_usage", value);
    }

    /// <summary>
    /// UnknownExtendedKeyUsages block (nesting mode: list).
    /// </summary>
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>? UnknownExtendedKeyUsages
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock>>("unknown_extended_key_usages");
        set => SetArgument("unknown_extended_key_usages", value);
    }

}

/// <summary>
/// Block type for base_key_usage in GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockBaseKeyUsageBlock : TerraformBlock
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
/// Block type for extended_key_usage in GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockExtendedKeyUsageBlock : TerraformBlock
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
/// Block type for unknown_extended_key_usages in GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockKeyUsageBlockUnknownExtendedKeyUsagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unknown_extended_key_usages";

    /// <summary>
    /// Required. The parts of an OID path. The most significant parts of the path come first.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}

/// <summary>
/// Block type for name_constraints in GooglePrivatecaCertificateTemplatePredefinedValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockNameConstraintsBlock : TerraformBlock
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
/// Block type for policy_ids in GooglePrivatecaCertificateTemplatePredefinedValuesBlock.
/// Nesting mode: list
/// </summary>
public class GooglePrivatecaCertificateTemplatePredefinedValuesBlockPolicyIdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_ids";

    /// <summary>
    /// Required. The parts of an OID path. The most significant parts of the path come first.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectIdPath is required")]
    public TerraformList<double>? ObjectIdPath
    {
        get => GetArgument<TerraformList<double>>("object_id_path");
        set => SetArgument("object_id_path", value);
    }

}


/// <summary>
/// Block type for timeouts in GooglePrivatecaCertificateTemplate.
/// Nesting mode: single
/// </summary>
public class GooglePrivatecaCertificateTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_privateca_certificate_template Terraform resource.
/// Manages a google_privateca_certificate_template resource.
/// </summary>
public partial class GooglePrivatecaCertificateTemplate(string name) : TerraformResource("google_privateca_certificate_template", name)
{
    /// <summary>
    /// Optional. A human-readable description of scenarios this template is intended for.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Optional. Labels with user-defined metadata.
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&#39;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&#39;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    public TerraformValue<string>? MaximumLifetime
    {
        get => GetArgument<TerraformValue<string>>("maximum_lifetime");
        set => SetArgument("maximum_lifetime", value);
    }

    /// <summary>
    /// The resource name for this CertificateTemplate in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Output only. The time at which this CertificateTemplate was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. The time at which this CertificateTemplate was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// IdentityConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdentityConstraints block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>? IdentityConstraints
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplateIdentityConstraintsBlock>>("identity_constraints");
        set => SetArgument("identity_constraints", value);
    }

    /// <summary>
    /// PassthroughExtensions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassthroughExtensions block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>? PassthroughExtensions
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePassthroughExtensionsBlock>>("passthrough_extensions");
        set => SetArgument("passthrough_extensions", value);
    }

    /// <summary>
    /// PredefinedValues block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PredefinedValues block(s) allowed")]
    public TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>? PredefinedValues
    {
        get => GetArgument<TerraformList<GooglePrivatecaCertificateTemplatePredefinedValuesBlock>>("predefined_values");
        set => SetArgument("predefined_values", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GooglePrivatecaCertificateTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GooglePrivatecaCertificateTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
