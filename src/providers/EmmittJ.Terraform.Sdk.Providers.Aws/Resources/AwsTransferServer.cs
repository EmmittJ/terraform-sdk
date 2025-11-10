using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerEndpointDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The address_allocation_ids attribute.
    /// </summary>
    [TerraformPropertyName("address_allocation_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AddressAllocationIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VpcEndpointId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_endpoint_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcId { get; set; }

}

/// <summary>
/// Block type for protocol_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerProtocolDetailsBlock : ITerraformBlock
{
    /// <summary>
    /// The as2_transports attribute.
    /// </summary>
    [TerraformPropertyName("as2_transports")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> As2Transports { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "as2_transports");

    /// <summary>
    /// The passive_ip attribute.
    /// </summary>
    [TerraformPropertyName("passive_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PassiveIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "passive_ip");

    /// <summary>
    /// The set_stat_option attribute.
    /// </summary>
    [TerraformPropertyName("set_stat_option")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SetStatOption { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "set_stat_option");

    /// <summary>
    /// The tls_session_resumption_mode attribute.
    /// </summary>
    [TerraformPropertyName("tls_session_resumption_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TlsSessionResumptionMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tls_session_resumption_mode");

}

/// <summary>
/// Block type for s3_storage_options in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerS3StorageOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The directory_listing_optimization attribute.
    /// </summary>
    [TerraformPropertyName("directory_listing_optimization")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DirectoryListingOptimization { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "directory_listing_optimization");

}

/// <summary>
/// Block type for workflow_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerWorkflowDetailsBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_transfer_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferServer : TerraformResource
{
    public AwsTransferServer(string name) : base("aws_transfer_server", name)
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Certificate { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DirectoryId { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Domain { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointType { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The function attribute.
    /// </summary>
    [TerraformPropertyName("function")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Function { get; set; }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    [TerraformPropertyName("host_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_provider_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityProviderType { get; set; }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    [TerraformPropertyName("invocation_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InvocationRole { get; set; }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoggingRole { get; set; }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    [TerraformPropertyName("post_authentication_login_banner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostAuthenticationLoginBanner { get; set; }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    [TerraformPropertyName("pre_authentication_login_banner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreAuthenticationLoginBanner { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Protocols { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "protocols");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityPolicyName { get; set; }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    [TerraformPropertyName("sftp_authentication_methods")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SftpAuthenticationMethods { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sftp_authentication_methods");

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    [TerraformPropertyName("structured_log_destinations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? StructuredLogDestinations { get; set; }

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
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

    /// <summary>
    /// Block for endpoint_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointDetails block(s) allowed")]
    [TerraformPropertyName("endpoint_details")]
    public TerraformList<TerraformBlock<AwsTransferServerEndpointDetailsBlock>>? EndpointDetails { get; set; } = new();

    /// <summary>
    /// Block for protocol_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtocolDetails block(s) allowed")]
    [TerraformPropertyName("protocol_details")]
    public TerraformList<TerraformBlock<AwsTransferServerProtocolDetailsBlock>>? ProtocolDetails { get; set; } = new();

    /// <summary>
    /// Block for s3_storage_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageOptions block(s) allowed")]
    [TerraformPropertyName("s3_storage_options")]
    public TerraformList<TerraformBlock<AwsTransferServerS3StorageOptionsBlock>>? S3StorageOptions { get; set; } = new();

    /// <summary>
    /// Block for workflow_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkflowDetails block(s) allowed")]
    [TerraformPropertyName("workflow_details")]
    public TerraformList<TerraformBlock<AwsTransferServerWorkflowDetailsBlock>>? WorkflowDetails { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("host_key_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostKeyFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_key_fingerprint");

}
