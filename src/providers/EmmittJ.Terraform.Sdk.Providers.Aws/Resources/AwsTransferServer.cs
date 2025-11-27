using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint_details in AwsTransferServer.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerEndpointDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_details";

    /// <summary>
    /// The address_allocation_ids attribute.
    /// </summary>
    public TerraformSet<string>? AddressAllocationIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_allocation_ids").ResolveNodes(ctx));
        set => SetArgument("address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointId
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Block type for protocol_details in AwsTransferServer.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerProtocolDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocol_details";

    /// <summary>
    /// The as2_transports attribute.
    /// </summary>
    public TerraformSet<string> As2Transports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "as2_transports").ResolveNodes(ctx));
        set => SetArgument("as2_transports", value);
    }

    /// <summary>
    /// The passive_ip attribute.
    /// </summary>
    public TerraformValue<string> PassiveIp
    {
        get => new TerraformReference<string>(this, "passive_ip");
        set => SetArgument("passive_ip", value);
    }

    /// <summary>
    /// The set_stat_option attribute.
    /// </summary>
    public TerraformValue<string> SetStatOption
    {
        get => new TerraformReference<string>(this, "set_stat_option");
        set => SetArgument("set_stat_option", value);
    }

    /// <summary>
    /// The tls_session_resumption_mode attribute.
    /// </summary>
    public TerraformValue<string> TlsSessionResumptionMode
    {
        get => new TerraformReference<string>(this, "tls_session_resumption_mode");
        set => SetArgument("tls_session_resumption_mode", value);
    }

}


/// <summary>
/// Block type for s3_storage_options in AwsTransferServer.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerS3StorageOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_storage_options";

    /// <summary>
    /// The directory_listing_optimization attribute.
    /// </summary>
    public TerraformValue<string> DirectoryListingOptimization
    {
        get => new TerraformReference<string>(this, "directory_listing_optimization");
        set => SetArgument("directory_listing_optimization", value);
    }

}


/// <summary>
/// Block type for workflow_details in AwsTransferServer.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerWorkflowDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workflow_details";

    /// <summary>
    /// OnPartialUpload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnPartialUpload block(s) allowed")]
    public TerraformList<AwsTransferServerWorkflowDetailsBlockOnPartialUploadBlock>? OnPartialUpload
    {
        get => GetArgument<TerraformList<AwsTransferServerWorkflowDetailsBlockOnPartialUploadBlock>>("on_partial_upload");
        set => SetArgument("on_partial_upload", value);
    }

    /// <summary>
    /// OnUpload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnUpload block(s) allowed")]
    public TerraformList<AwsTransferServerWorkflowDetailsBlockOnUploadBlock>? OnUpload
    {
        get => GetArgument<TerraformList<AwsTransferServerWorkflowDetailsBlockOnUploadBlock>>("on_upload");
        set => SetArgument("on_upload", value);
    }

}

/// <summary>
/// Block type for on_partial_upload in AwsTransferServerWorkflowDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerWorkflowDetailsBlockOnPartialUploadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_partial_upload";

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => new TerraformReference<string>(this, "execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The workflow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowId is required")]
    public required TerraformValue<string> WorkflowId
    {
        get => new TerraformReference<string>(this, "workflow_id");
        set => SetArgument("workflow_id", value);
    }

}

/// <summary>
/// Block type for on_upload in AwsTransferServerWorkflowDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferServerWorkflowDetailsBlockOnUploadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_upload";

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRole is required")]
    public required TerraformValue<string> ExecutionRole
    {
        get => new TerraformReference<string>(this, "execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The workflow_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkflowId is required")]
    public required TerraformValue<string> WorkflowId
    {
        get => new TerraformReference<string>(this, "workflow_id");
        set => SetArgument("workflow_id", value);
    }

}


/// <summary>
/// Represents a aws_transfer_server Terraform resource.
/// Manages a aws_transfer_server resource.
/// </summary>
public partial class AwsTransferServer(string name) : TerraformResource("aws_transfer_server", name)
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformValue<string>? DirectoryId
    {
        get => new TerraformReference<string>(this, "directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The function attribute.
    /// </summary>
    public TerraformValue<string>? Function
    {
        get => new TerraformReference<string>(this, "function");
        set => SetArgument("function", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformValue<string>? HostKey
    {
        get => new TerraformReference<string>(this, "host_key");
        set => SetArgument("host_key", value);
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
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformValue<string>? IdentityProviderType
    {
        get => new TerraformReference<string>(this, "identity_provider_type");
        set => SetArgument("identity_provider_type", value);
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformValue<string>? InvocationRole
    {
        get => new TerraformReference<string>(this, "invocation_role");
        set => SetArgument("invocation_role", value);
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string>? LoggingRole
    {
        get => new TerraformReference<string>(this, "logging_role");
        set => SetArgument("logging_role", value);
    }

    /// <summary>
    /// The post_authentication_login_banner attribute.
    /// </summary>
    public TerraformValue<string>? PostAuthenticationLoginBanner
    {
        get => new TerraformReference<string>(this, "post_authentication_login_banner");
        set => SetArgument("post_authentication_login_banner", value);
    }

    /// <summary>
    /// The pre_authentication_login_banner attribute.
    /// </summary>
    public TerraformValue<string>? PreAuthenticationLoginBanner
    {
        get => new TerraformReference<string>(this, "pre_authentication_login_banner");
        set => SetArgument("pre_authentication_login_banner", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string> Protocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
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
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? SecurityPolicyName
    {
        get => new TerraformReference<string>(this, "security_policy_name");
        set => SetArgument("security_policy_name", value);
    }

    /// <summary>
    /// The sftp_authentication_methods attribute.
    /// </summary>
    public TerraformValue<string> SftpAuthenticationMethods
    {
        get => new TerraformReference<string>(this, "sftp_authentication_methods");
        set => SetArgument("sftp_authentication_methods", value);
    }

    /// <summary>
    /// This is a set of arns of destinations that will receive structured logs from the transfer server
    /// </summary>
    public TerraformSet<string>? StructuredLogDestinations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "structured_log_destinations").ResolveNodes(ctx));
        set => SetArgument("structured_log_destinations", value);
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
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> HostKeyFingerprint
    {
        get => new TerraformReference<string>(this, "host_key_fingerprint");
    }

    /// <summary>
    /// EndpointDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointDetails block(s) allowed")]
    public TerraformList<AwsTransferServerEndpointDetailsBlock>? EndpointDetails
    {
        get => GetArgument<TerraformList<AwsTransferServerEndpointDetailsBlock>>("endpoint_details");
        set => SetArgument("endpoint_details", value);
    }

    /// <summary>
    /// ProtocolDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtocolDetails block(s) allowed")]
    public TerraformList<AwsTransferServerProtocolDetailsBlock>? ProtocolDetails
    {
        get => GetArgument<TerraformList<AwsTransferServerProtocolDetailsBlock>>("protocol_details");
        set => SetArgument("protocol_details", value);
    }

    /// <summary>
    /// S3StorageOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageOptions block(s) allowed")]
    public TerraformList<AwsTransferServerS3StorageOptionsBlock>? S3StorageOptions
    {
        get => GetArgument<TerraformList<AwsTransferServerS3StorageOptionsBlock>>("s3_storage_options");
        set => SetArgument("s3_storage_options", value);
    }

    /// <summary>
    /// WorkflowDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkflowDetails block(s) allowed")]
    public TerraformList<AwsTransferServerWorkflowDetailsBlock>? WorkflowDetails
    {
        get => GetArgument<TerraformList<AwsTransferServerWorkflowDetailsBlock>>("workflow_details");
        set => SetArgument("workflow_details", value);
    }

}
