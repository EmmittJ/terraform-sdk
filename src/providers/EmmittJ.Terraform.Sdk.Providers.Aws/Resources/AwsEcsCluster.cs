using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsEcsCluster.
/// Nesting mode: list
/// </summary>
public class AwsEcsClusterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// ExecuteCommandConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecuteCommandConfiguration block(s) allowed")]
    public TerraformList<AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlock>? ExecuteCommandConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlock>>("execute_command_configuration");
        set => SetArgument("execute_command_configuration", value);
    }

    /// <summary>
    /// ManagedStorageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedStorageConfiguration block(s) allowed")]
    public TerraformList<AwsEcsClusterConfigurationBlockManagedStorageConfigurationBlock>? ManagedStorageConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsClusterConfigurationBlockManagedStorageConfigurationBlock>>("managed_storage_configuration");
        set => SetArgument("managed_storage_configuration", value);
    }

}

/// <summary>
/// Block type for execute_command_configuration in AwsEcsClusterConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execute_command_configuration";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The logging attribute.
    /// </summary>
    public TerraformValue<string>? Logging
    {
        get => new TerraformReference<string>(this, "logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public TerraformList<AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlockLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlockLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

}

/// <summary>
/// Block type for log_configuration in AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsClusterConfigurationBlockExecuteCommandConfigurationBlockLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// The cloud_watch_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CloudWatchEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "cloud_watch_encryption_enabled");
        set => SetArgument("cloud_watch_encryption_enabled", value);
    }

    /// <summary>
    /// The cloud_watch_log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? CloudWatchLogGroupName
    {
        get => new TerraformReference<string>(this, "cloud_watch_log_group_name");
        set => SetArgument("cloud_watch_log_group_name", value);
    }

    /// <summary>
    /// The s3_bucket_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? S3BucketEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "s3_bucket_encryption_enabled");
        set => SetArgument("s3_bucket_encryption_enabled", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => new TerraformReference<string>(this, "s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

}

/// <summary>
/// Block type for managed_storage_configuration in AwsEcsClusterConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsClusterConfigurationBlockManagedStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_storage_configuration";

    /// <summary>
    /// The fargate_ephemeral_storage_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? FargateEphemeralStorageKmsKeyId
    {
        get => new TerraformReference<string>(this, "fargate_ephemeral_storage_kms_key_id");
        set => SetArgument("fargate_ephemeral_storage_kms_key_id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}


/// <summary>
/// Block type for service_connect_defaults in AwsEcsCluster.
/// Nesting mode: list
/// </summary>
public class AwsEcsClusterServiceConnectDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_connect_defaults";

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for setting in AwsEcsCluster.
/// Nesting mode: set
/// </summary>
public class AwsEcsClusterSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "setting";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_ecs_cluster Terraform resource.
/// Manages a aws_ecs_cluster resource.
/// </summary>
public partial class AwsEcsCluster(string name) : TerraformResource("aws_ecs_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsEcsClusterConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsEcsClusterConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// ServiceConnectDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConnectDefaults block(s) allowed")]
    public TerraformList<AwsEcsClusterServiceConnectDefaultsBlock>? ServiceConnectDefaults
    {
        get => GetArgument<TerraformList<AwsEcsClusterServiceConnectDefaultsBlock>>("service_connect_defaults");
        set => SetArgument("service_connect_defaults", value);
    }

    /// <summary>
    /// Setting block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsClusterSettingBlock>? Setting
    {
        get => GetArgument<TerraformSet<AwsEcsClusterSettingBlock>>("setting");
        set => SetArgument("setting", value);
    }

}
