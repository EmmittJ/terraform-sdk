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
        get => GetRequiredArgument<TerraformValue<string>>("key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    public required TerraformValue<string> SigningAlgorithm
    {
        get => GetRequiredArgument<TerraformValue<string>>("signing_algorithm");
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
        get => GetArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => GetArgument<TerraformValue<string>>("country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The distinguished_name_qualifier attribute.
    /// </summary>
    public TerraformValue<string>? DistinguishedNameQualifier
    {
        get => GetArgument<TerraformValue<string>>("distinguished_name_qualifier");
        set => SetArgument("distinguished_name_qualifier", value);
    }

    /// <summary>
    /// The generation_qualifier attribute.
    /// </summary>
    public TerraformValue<string>? GenerationQualifier
    {
        get => GetArgument<TerraformValue<string>>("generation_qualifier");
        set => SetArgument("generation_qualifier", value);
    }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    public TerraformValue<string>? GivenName
    {
        get => GetArgument<TerraformValue<string>>("given_name");
        set => SetArgument("given_name", value);
    }

    /// <summary>
    /// The initials attribute.
    /// </summary>
    public TerraformValue<string>? Initials
    {
        get => GetArgument<TerraformValue<string>>("initials");
        set => SetArgument("initials", value);
    }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    public TerraformValue<string>? Organization
    {
        get => GetArgument<TerraformValue<string>>("organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The organizational_unit attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnit
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit");
        set => SetArgument("organizational_unit", value);
    }

    /// <summary>
    /// The pseudonym attribute.
    /// </summary>
    public TerraformValue<string>? Pseudonym
    {
        get => GetArgument<TerraformValue<string>>("pseudonym");
        set => SetArgument("pseudonym", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The surname attribute.
    /// </summary>
    public TerraformValue<string>? Surname
    {
        get => GetArgument<TerraformValue<string>>("surname");
        set => SetArgument("surname", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
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
        get => GetArgument<TerraformValue<string>>("custom_cname");
        set => SetArgument("custom_cname", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The expiration_in_days attribute.
    /// </summary>
    public TerraformValue<double>? ExpirationInDays
    {
        get => GetArgument<TerraformValue<double>>("expiration_in_days");
        set => SetArgument("expiration_in_days", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? S3BucketName
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_object_acl attribute.
    /// </summary>
    public TerraformValue<string> S3ObjectAcl
    {
        get => GetArgument<TerraformValue<string>>("s3_object_acl") ?? CreateReference("s3_object_acl");
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
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ocsp_custom_cname attribute.
    /// </summary>
    public TerraformValue<string>? OcspCustomCname
    {
        get => GetArgument<TerraformValue<string>>("ocsp_custom_cname");
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
        get => GetArgument<TerraformValue<string>>("create");
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    public TerraformValue<string> KeyStorageSecurityStandard
    {
        get => GetArgument<TerraformValue<string>>("key_storage_security_standard") ?? CreateReference("key_storage_security_standard");
        set => SetArgument("key_storage_security_standard", value);
    }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    public TerraformValue<double>? PermanentDeletionTimeInDays
    {
        get => GetArgument<TerraformValue<double>>("permanent_deletion_time_in_days");
        set => SetArgument("permanent_deletion_time_in_days", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    public TerraformValue<string> UsageMode
    {
        get => GetArgument<TerraformValue<string>>("usage_mode") ?? CreateReference("usage_mode");
        set => SetArgument("usage_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
        => CreateReference("certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string> CertificateChain
        => CreateReference("certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    public TerraformValue<string> CertificateSigningRequest
        => CreateReference("certificate_signing_request");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformValue<string> NotAfter
        => CreateReference("not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
        => CreateReference("not_before");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    public TerraformValue<string> Serial
        => CreateReference("serial");

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
