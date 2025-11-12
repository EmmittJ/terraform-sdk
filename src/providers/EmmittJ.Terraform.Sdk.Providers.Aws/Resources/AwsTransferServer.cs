using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferServerEndpointDetailsBlock() : TerraformBlock("endpoint_details")
{
    /// <summary>
    /// The address_allocation_ids attribute.
    /// </summary>
    [TerraformProperty("address_allocation_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AddressAllocationIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcEndpointId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcId { get; set; }

}

/// <summary>
/// Block type for protocol_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferServerProtocolDetailsBlock() : TerraformBlock("protocol_details")
{
    /// <summary>
    /// The as2_transports attribute.
    /// </summary>
    [TerraformProperty("as2_transports")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> As2Transports { get; set; }

    /// <summary>
    /// The passive_ip attribute.
    /// </summary>
    [TerraformProperty("passive_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PassiveIp { get; set; }

    /// <summary>
    /// The set_stat_option attribute.
    /// </summary>
    [TerraformProperty("set_stat_option")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SetStatOption { get; set; }

    /// <summary>
    /// The tls_session_resumption_mode attribute.
    /// </summary>
    [TerraformProperty("tls_session_resumption_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TlsSessionResumptionMode { get; set; }

}

/// <summary>
/// Block type for s3_storage_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferServerS3StorageOptionsBlock() : TerraformBlock("s3_storage_options")
{
    /// <summary>
    /// The directory_listing_optimization attribute.
    /// </summary>
    [TerraformProperty("directory_listing_optimization")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DirectoryListingOptimization { get; set; }

}

/// <summary>
/// Block type for workflow_details in .
/// Nesting mode: list
/// </summary>
public partial class AwsTransferServerWorkflowDetailsBlock() : TerraformBlock("workflow_details")
{
}

/// <summary>
/// Manages a aws_transfer_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsTransferServer : TerraformResource
{
    public AwsTransferServer(string name) : base("aws_transfer_server", name)
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformProperty("directory_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DirectoryId { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointType { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The function attribute.
    /// </summary>
    [TerraformProperty("function")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Function { get; set; }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    [TerraformProperty("host_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [TerraformProperty("identity_provider_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityProviderType { get; set; }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    [TerraformProperty("invocation_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InvocationRole { get; set; }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformProperty("logging_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoggingRole { get; set; }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    [TerraformProperty("post_authentication_login_banner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostAuthenticationLoginBanner { get; set; }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    [TerraformProperty("pre_authentication_login_banner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreAuthenticationLoginBanner { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Protocols { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityPolicyName { get; set; }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    [TerraformProperty("sftp_authentication_methods")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SftpAuthenticationMethods { get; set; }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    [TerraformProperty("structured_log_destinations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? StructuredLogDestinations { get; set; }

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
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// Block for endpoint_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointDetails block(s) allowed")]
    [TerraformProperty("endpoint_details")]
    public TerraformList<AwsTransferServerEndpointDetailsBlock> EndpointDetails { get; set; } = new();

    /// <summary>
    /// Block for protocol_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtocolDetails block(s) allowed")]
    [TerraformProperty("protocol_details")]
    public TerraformList<AwsTransferServerProtocolDetailsBlock> ProtocolDetails { get; set; } = new();

    /// <summary>
    /// Block for s3_storage_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageOptions block(s) allowed")]
    [TerraformProperty("s3_storage_options")]
    public TerraformList<AwsTransferServerS3StorageOptionsBlock> S3StorageOptions { get; set; } = new();

    /// <summary>
    /// Block for workflow_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkflowDetails block(s) allowed")]
    [TerraformProperty("workflow_details")]
    public TerraformList<AwsTransferServerWorkflowDetailsBlock> WorkflowDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("host_key_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostKeyFingerprint { get; }

}
