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
        set => SetProperty("address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        set => SetProperty("vpc_id", value);
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
        set => SetProperty("as2_transports", value);
    }

    /// <summary>
    /// The passive_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PassiveIp
    {
        set => SetProperty("passive_ip", value);
    }

    /// <summary>
    /// The set_stat_option attribute.
    /// </summary>
    public TerraformProperty<string>? SetStatOption
    {
        set => SetProperty("set_stat_option", value);
    }

    /// <summary>
    /// The tls_session_resumption_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSessionResumptionMode
    {
        set => SetProperty("tls_session_resumption_mode", value);
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
        set => SetProperty("directory_listing_optimization", value);
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
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTransferServer : TerraformResource
{
    public AwsTransferServer(string name) : base("aws_transfer_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("host_key_fingerprint");
        SetOutput("certificate");
        SetOutput("directory_id");
        SetOutput("domain");
        SetOutput("endpoint_type");
        SetOutput("force_destroy");
        SetOutput("function");
        SetOutput("host_key");
        SetOutput("id");
        SetOutput("identity_provider_type");
        SetOutput("invocation_role");
        SetOutput("logging_role");
        SetOutput("post_authentication_login_banner");
        SetOutput("pre_authentication_login_banner");
        SetOutput("protocols");
        SetOutput("region");
        SetOutput("security_policy_name");
        SetOutput("sftp_authentication_methods");
        SetOutput("structured_log_destinations");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("url");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string> Certificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate");
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string> EndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_type");
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public TerraformProperty<string> Function
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function");
        set => SetProperty("function", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformProperty<string> HostKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_key");
        set => SetProperty("host_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformProperty<string> IdentityProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_provider_type");
        set => SetProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformProperty<string> InvocationRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("invocation_role");
        set => SetProperty("invocation_role", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformProperty<string> LoggingRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logging_role");
        set => SetProperty("logging_role", value);
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string> PostAuthenticationLoginBanner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("post_authentication_login_banner");
        set => SetProperty("post_authentication_login_banner", value);
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public TerraformProperty<string> PreAuthenticationLoginBanner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pre_authentication_login_banner");
        set => SetProperty("pre_authentication_login_banner", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Protocols
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("protocols");
        set => SetProperty("protocols", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformProperty<string> SecurityPolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_policy_name");
        set => SetProperty("security_policy_name", value);
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public TerraformProperty<string> SftpAuthenticationMethods
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sftp_authentication_methods");
        set => SetProperty("sftp_authentication_methods", value);
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public HashSet<TerraformProperty<string>> StructuredLogDestinations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("structured_log_destinations");
        set => SetProperty("structured_log_destinations", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// Block for endpoint_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointDetails block(s) allowed")]
    public List<AwsTransferServerEndpointDetailsBlock>? EndpointDetails
    {
        set => SetProperty("endpoint_details", value);
    }

    /// <summary>
    /// Block for protocol_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtocolDetails block(s) allowed")]
    public List<AwsTransferServerProtocolDetailsBlock>? ProtocolDetails
    {
        set => SetProperty("protocol_details", value);
    }

    /// <summary>
    /// Block for s3_storage_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageOptions block(s) allowed")]
    public List<AwsTransferServerS3StorageOptionsBlock>? S3StorageOptions
    {
        set => SetProperty("s3_storage_options", value);
    }

    /// <summary>
    /// Block for workflow_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkflowDetails block(s) allowed")]
    public List<AwsTransferServerWorkflowDetailsBlock>? WorkflowDetails
    {
        set => SetProperty("workflow_details", value);
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
