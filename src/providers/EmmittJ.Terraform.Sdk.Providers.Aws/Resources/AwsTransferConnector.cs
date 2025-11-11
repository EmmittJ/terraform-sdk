using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for as2_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorAs2ConfigBlock
{
    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    [TerraformPropertyName("compression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Compression { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    [TerraformPropertyName("encryption_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    [TerraformPropertyName("local_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LocalProfileId { get; set; }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    [TerraformPropertyName("mdn_response")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MdnResponse { get; set; }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("mdn_signing_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MdnSigningAlgorithm { get; set; }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    [TerraformPropertyName("message_subject")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MessageSubject { get; set; }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    [TerraformPropertyName("partner_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PartnerProfileId { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformPropertyName("signing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for sftp_config in .
/// Nesting mode: list
/// </summary>
public class AwsTransferConnectorSftpConfigBlock
{
    /// <summary>
    /// The trusted_host_keys attribute.
    /// </summary>
    [TerraformPropertyName("trusted_host_keys")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? TrustedHostKeys { get; set; }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("user_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserSecretId { get; set; }

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
    public required TerraformValue<string> AccessRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoggingRole { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecurityPolicyName { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

    /// <summary>
    /// Block for as2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    [TerraformPropertyName("as2_config")]
    public TerraformList<TerraformBlock<AwsTransferConnectorAs2ConfigBlock>>? As2Config { get; set; }

    /// <summary>
    /// Block for sftp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    [TerraformPropertyName("sftp_config")]
    public TerraformList<TerraformBlock<AwsTransferConnectorSftpConfigBlock>>? SftpConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    [TerraformPropertyName("connector_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectorId => new TerraformReference(this, "connector_id");

}
