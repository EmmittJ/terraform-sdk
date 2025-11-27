using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_filter in AwsWorkspaceswebSessionLogger.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerEventFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_filter";

    /// <summary>
    /// The include attribute.
    /// </summary>
    public TerraformSet<string>? Include
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "include").ResolveNodes(ctx));
        set => SetArgument("include", value);
    }

    /// <summary>
    /// All block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebSessionLoggerEventFilterBlockAllBlock>? All
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebSessionLoggerEventFilterBlockAllBlock>>("all");
        set => SetArgument("all", value);
    }

}

/// <summary>
/// Block type for all in AwsWorkspaceswebSessionLoggerEventFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerEventFilterBlockAllBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all";

}


/// <summary>
/// Block type for log_configuration in AwsWorkspaceswebSessionLogger.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebSessionLoggerLogConfigurationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebSessionLoggerLogConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsWorkspaceswebSessionLoggerLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerLogConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_owner attribute.
    /// </summary>
    public TerraformValue<string> BucketOwner
    {
        get => new TerraformReference<string>(this, "bucket_owner");
        set => SetArgument("bucket_owner", value);
    }

    /// <summary>
    /// The folder_structure attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderStructure is required")]
    public required TerraformValue<string> FolderStructure
    {
        get => new TerraformReference<string>(this, "folder_structure");
        set => SetArgument("folder_structure", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => new TerraformReference<string>(this, "key_prefix");
        set => SetArgument("key_prefix", value);
    }

    /// <summary>
    /// The log_file_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogFileFormat is required")]
    public required TerraformValue<string> LogFileFormat
    {
        get => new TerraformReference<string>(this, "log_file_format");
        set => SetArgument("log_file_format", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_session_logger Terraform resource.
/// Manages a aws_workspacesweb_session_logger resource.
/// </summary>
public partial class AwsWorkspaceswebSessionLogger(string name) : TerraformResource("aws_workspacesweb_session_logger", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_encryption_context").ResolveNodes(ctx));
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "associated_portal_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformValue<string> SessionLoggerArn
    {
        get => new TerraformReference<string>(this, "session_logger_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// EventFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebSessionLoggerEventFilterBlock>? EventFilter
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebSessionLoggerEventFilterBlock>>("event_filter");
        set => SetArgument("event_filter", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

}
