using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_authority_configuration in AwsAcmpcaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_authority_configuration";

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    public required TerraformValue<string> KeyAlgorithm
    {
        get => new TerraformReference<string>(this, "key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => new TerraformReference<string>(this, "signing_algorithm");
        set => SetArgument("signing_algorithm", value);
    }

    /// <summary>
    /// Subject block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    public required TerraformList<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlockSubjectBlock> Subject
    {
        get => GetRequiredArgument<TerraformList<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlockSubjectBlock>>("subject");
        set => SetArgument("subject", value);
    }

}

/// <summary>
/// Block type for subject in AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlockSubjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject";

    /// <summary>
    /// The common_name attribute.
    /// </summary>
    public TerraformValue<string>? CommonName
    {
        get => new TerraformReference<string>(this, "common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The distinguished_name_qualifier attribute.
    /// </summary>
    public TerraformValue<string>? DistinguishedNameQualifier
    {
        get => new TerraformReference<string>(this, "distinguished_name_qualifier");
        set => SetArgument("distinguished_name_qualifier", value);
    }

    /// <summary>
    /// The generation_qualifier attribute.
    /// </summary>
    public TerraformValue<string>? GenerationQualifier
    {
        get => new TerraformReference<string>(this, "generation_qualifier");
        set => SetArgument("generation_qualifier", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    public TerraformValue<string>? GivenName
    {
        get => new TerraformReference<string>(this, "given_name");
        set => SetArgument("given_name", value);
    }

    /// <summary>
    /// The initials attribute.
    /// </summary>
    public TerraformValue<string>? Initials
    {
        get => new TerraformReference<string>(this, "initials");
        set => SetArgument("initials", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => new TerraformReference<string>(this, "locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnit
    {
        get => new TerraformReference<string>(this, "organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The pseudonym attribute.
    /// </summary>
    public TerraformValue<string>? Pseudonym
    {
        get => new TerraformReference<string>(this, "pseudonym");
        set => SetArgument("pseudonym", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The surname attribute.
    /// </summary>
    public TerraformValue<string>? Surname
    {
        get => new TerraformReference<string>(this, "surname");
        set => SetArgument("surname", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for revocation_configuration in AwsAcmpcaCertificateAuthority.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "revocation_configuration";

    /// <summary>
    /// CrlConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrlConfiguration block(s) allowed")]
    public TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockCrlConfigurationBlock>? CrlConfiguration
    {
        get => GetArgument<TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockCrlConfigurationBlock>>("crl_configuration");
        set => SetArgument("crl_configuration", value);
    }

    /// <summary>
    /// OcspConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OcspConfiguration block(s) allowed")]
    public TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockOcspConfigurationBlock>? OcspConfiguration
    {
        get => GetArgument<TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockOcspConfigurationBlock>>("ocsp_configuration");
        set => SetArgument("ocsp_configuration", value);
    }

}

/// <summary>
/// Block type for crl_configuration in AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockCrlConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crl_configuration";

    /// <summary>
    /// The custom_cname attribute.
    /// </summary>
    public TerraformValue<string>? CustomCname
    {
        get => new TerraformReference<string>(this, "custom_cname");
        set => SetArgument("custom_cname", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The expiration_in_days attribute.
    /// </summary>
    public TerraformValue<double>? ExpirationInDays
    {
        get => new TerraformReference<double>(this, "expiration_in_days");
        set => SetArgument("expiration_in_days", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_object_acl attribute.
    /// </summary>
    public TerraformValue<string> S3ObjectAcl
    {
        get => new TerraformReference<string>(this, "s3_object_acl");
        set => SetArgument("s3_object_acl", value);
    }

}

/// <summary>
/// Block type for ocsp_configuration in AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlockOcspConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ocsp_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ocsp_custom_cname attribute.
    /// </summary>
    public TerraformValue<string>? OcspCustomCname
    {
        get => new TerraformReference<string>(this, "ocsp_custom_cname");
        set => SetArgument("ocsp_custom_cname", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAcmpcaCertificateAuthority.
/// Nesting mode: single
/// </summary>
public class AwsAcmpcaCertificateAuthorityTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_acmpca_certificate_authority Terraform resource.
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
public partial class AwsAcmpcaCertificateAuthority(string name) : TerraformResource("aws_acmpca_certificate_authority", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformValue<string> KeyStorageSecurityStandard
    {
        get => new TerraformReference<string>(this, "key_storage_security_standard");
        set => SetArgument("key_storage_security_standard", value);
    }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    public TerraformValue<double>? PermanentDeletionTimeInDays
    {
        get => new TerraformReference<double>(this, "permanent_deletion_time_in_days");
        set => SetArgument("permanent_deletion_time_in_days", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformValue<string> UsageMode
    {
        get => new TerraformReference<string>(this, "usage_mode");
        set => SetArgument("usage_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
    }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformValue<string> CertificateSigningRequest
    {
        get => new TerraformReference<string>(this, "certificate_signing_request");
    }

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformValue<string> NotAfter
    {
        get => new TerraformReference<string>(this, "not_after");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
    }

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformValue<string> Serial
    {
        get => new TerraformReference<string>(this, "serial");
    }

    /// <summary>
    /// CertificateAuthorityConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfiguration block(s) allowed")]
    public required TerraformList<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock> CertificateAuthorityConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock>>("certificate_authority_configuration");
        set => SetArgument("certificate_authority_configuration", value);
    }

    /// <summary>
    /// RevocationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RevocationConfiguration block(s) allowed")]
    public TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>? RevocationConfiguration
    {
        get => GetArgument<TerraformList<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>>("revocation_configuration");
        set => SetArgument("revocation_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAcmpcaCertificateAuthorityTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAcmpcaCertificateAuthorityTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
