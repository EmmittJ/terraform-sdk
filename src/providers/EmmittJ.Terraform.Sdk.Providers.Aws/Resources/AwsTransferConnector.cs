using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for as2_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferConnectorAs2ConfigBlock() : TerraformBlock("as2_config")
{
    /// <summary>
    /// The compression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compression is required")]
    [TerraformProperty("compression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Compression { get; set; }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    [TerraformProperty("encryption_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EncryptionAlgorithm { get; set; }

    /// <summary>
    /// The local_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalProfileId is required")]
    [TerraformProperty("local_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocalProfileId { get; set; }

    /// <summary>
    /// The mdn_response attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MdnResponse is required")]
    [TerraformProperty("mdn_response")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MdnResponse { get; set; }

    /// <summary>
    /// The mdn_signing_algorithm attribute.
    /// </summary>
    [TerraformProperty("mdn_signing_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MdnSigningAlgorithm { get; set; }

    /// <summary>
    /// The message_subject attribute.
    /// </summary>
    [TerraformProperty("message_subject")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageSubject { get; set; }

    /// <summary>
    /// The partner_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerProfileId is required")]
    [TerraformProperty("partner_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PartnerProfileId { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformProperty("signing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for sftp_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferConnectorSftpConfigBlock() : TerraformBlock("sftp_config")
{
    /// <summary>
    /// The trusted_host_keys attribute.
    /// </summary>
    [TerraformProperty("trusted_host_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TrustedHostKeys { get; set; }

    /// <summary>
    /// The user_secret_id attribute.
    /// </summary>
    [TerraformProperty("user_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserSecretId { get; set; }

}

/// <summary>
/// Manages a aws_transfer_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsTransferConnector : TerraformResource
{
    public AwsTransferConnector(string name) : base("aws_transfer_connector", name)
    {
    }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    [TerraformProperty("access_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformProperty("logging_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoggingRole { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformProperty("security_policy_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityPolicyName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// Block for as2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 As2Config block(s) allowed")]
    [TerraformProperty("as2_config")]
    public TerraformList<AwsTransferConnectorAs2ConfigBlock> As2Config { get; set; } = new();

    /// <summary>
    /// Block for sftp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SftpConfig block(s) allowed")]
    [TerraformProperty("sftp_config")]
    public TerraformList<AwsTransferConnectorSftpConfigBlock> SftpConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The connector_id attribute.
    /// </summary>
    [TerraformProperty("connector_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectorId { get; }

}
