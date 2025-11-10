using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for as2_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorAs2ConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    [TerraformPropertyName("compression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Compression { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    [TerraformPropertyName("encryption_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    [TerraformPropertyName("local_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocalProfileId { get; set; }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    [TerraformPropertyName("mdn_response")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MdnResponse { get; set; }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("mdn_signing_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MdnSigningAlgorithm { get; set; }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    [TerraformPropertyName("message_subject")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageSubject { get; set; }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    [TerraformPropertyName("partner_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PartnerProfileId { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformPropertyName("signing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for sftp_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorSftpConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The trusted_host_keys attribute.
    /// </summary>
    [TerraformPropertyName("trusted_host_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TrustedHostKeys { get; set; }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("user_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserSecretId { get; set; }

}

/// <summary>
/// Manages a aws_transfer_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferConnector : TerraformResource
{
    public AwsTransferConnector(string name) : base("aws_transfer_connector", name)
    {
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    [TerraformPropertyName("access_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoggingRole { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecurityPolicyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_policy_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

    /// <summary>
    /// Block for as2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    [TerraformPropertyName("as2_config")]
    public TerraformList<TerraformBlock<AwsTransferConnectorAs2ConfigBlock>>? As2Config { get; set; } = new();

    /// <summary>
    /// Block for sftp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    [TerraformPropertyName("sftp_config")]
    public TerraformList<TerraformBlock<AwsTransferConnectorSftpConfigBlock>>? SftpConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    [TerraformPropertyName("connector_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connector_id");

}
