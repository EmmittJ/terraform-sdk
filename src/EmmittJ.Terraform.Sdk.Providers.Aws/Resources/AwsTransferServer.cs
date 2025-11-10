using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerEndpointDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The address_allocation_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AddressAllocationIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("address_allocation_ids");
        set => WithProperty("address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => WithProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Block type for protocol_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerProtocolDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The as2_transports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? As2Transports
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("as2_transports");
        set => WithProperty("as2_transports", value);
    }

    /// <summary>
    /// The passive_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PassiveIp
    {
        get => GetProperty<TerraformProperty<string>>("passive_ip");
        set => WithProperty("passive_ip", value);
    }

    /// <summary>
    /// The set_stat_option attribute.
    /// </summary>
    public TerraformProperty<string>? SetStatOption
    {
        get => GetProperty<TerraformProperty<string>>("set_stat_option");
        set => WithProperty("set_stat_option", value);
    }

    /// <summary>
    /// The tls_session_resumption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSessionResumptionMode
    {
        get => GetProperty<TerraformProperty<string>>("tls_session_resumption_mode");
        set => WithProperty("tls_session_resumption_mode", value);
    }

}

/// <summary>
/// Block type for s3_storage_options in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerS3StorageOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The directory_listing_optimization attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryListingOptimization
    {
        get => GetProperty<TerraformProperty<string>>("directory_listing_optimization");
        set => WithProperty("directory_listing_optimization", value);
    }

}

/// <summary>
/// Block type for workflow_details in .
/// Nesting mode: list
/// </summary>
public class AwsTransferServerWorkflowDetailsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_transfer_server resource.
/// </summary>
public class AwsTransferServer : TerraformResource
{
    public AwsTransferServer(string name) : base("aws_transfer_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("host_key_fingerprint");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public TerraformProperty<string>? Function
    {
        get => GetProperty<TerraformProperty<string>>("function");
        set => this.WithProperty("function", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformProperty<string>? HostKey
    {
        get => GetProperty<TerraformProperty<string>>("host_key");
        set => this.WithProperty("host_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityProviderType
    {
        get => GetProperty<TerraformProperty<string>>("identity_provider_type");
        set => this.WithProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationRole
    {
        get => GetProperty<TerraformProperty<string>>("invocation_role");
        set => this.WithProperty("invocation_role", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string>? LoggingRole
    {
        get => GetProperty<TerraformProperty<string>>("logging_role");
        set => this.WithProperty("logging_role", value);
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string>? PostAuthenticationLoginBanner
    {
        get => GetProperty<TerraformProperty<string>>("post_authentication_login_banner");
        set => this.WithProperty("post_authentication_login_banner", value);
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string>? PreAuthenticationLoginBanner
    {
        get => GetProperty<TerraformProperty<string>>("pre_authentication_login_banner");
        set => this.WithProperty("pre_authentication_login_banner", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protocols");
        set => this.WithProperty("protocols", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("security_policy_name");
        set => this.WithProperty("security_policy_name", value);
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public TerraformProperty<string>? SftpAuthenticationMethods
    {
        get => GetProperty<TerraformProperty<string>>("sftp_authentication_methods");
        set => this.WithProperty("sftp_authentication_methods", value);
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public HashSet<TerraformProperty<string>>? StructuredLogDestinations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("structured_log_destinations");
        set => this.WithProperty("structured_log_destinations", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

    /// <summary>
    /// Block for endpoint_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointDetails block(s) allowed")]
    public List<AwsTransferServerEndpointDetailsBlock>? EndpointDetails
    {
        get => GetProperty<List<AwsTransferServerEndpointDetailsBlock>>("endpoint_details");
        set => this.WithProperty("endpoint_details", value);
    }

    /// <summary>
    /// Block for protocol_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtocolDetails block(s) allowed")]
    public List<AwsTransferServerProtocolDetailsBlock>? ProtocolDetails
    {
        get => GetProperty<List<AwsTransferServerProtocolDetailsBlock>>("protocol_details");
        set => this.WithProperty("protocol_details", value);
    }

    /// <summary>
    /// Block for s3_storage_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageOptions block(s) allowed")]
    public List<AwsTransferServerS3StorageOptionsBlock>? S3StorageOptions
    {
        get => GetProperty<List<AwsTransferServerS3StorageOptionsBlock>>("s3_storage_options");
        set => this.WithProperty("s3_storage_options", value);
    }

    /// <summary>
    /// Block for workflow_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkflowDetails block(s) allowed")]
    public List<AwsTransferServerWorkflowDetailsBlock>? WorkflowDetails
    {
        get => GetProperty<List<AwsTransferServerWorkflowDetailsBlock>>("workflow_details");
        set => this.WithProperty("workflow_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression HostKeyFingerprint => this["host_key_fingerprint"];

}
