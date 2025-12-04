using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in AwsBedrockModelInvocationLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The embedding_data_delivery_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EmbeddingDataDeliveryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("embedding_data_delivery_enabled") ?? AsReference("embedding_data_delivery_enabled");
        set => SetArgument("embedding_data_delivery_enabled", value);
    }

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ImageDataDeliveryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("image_data_delivery_enabled") ?? AsReference("image_data_delivery_enabled");
        set => SetArgument("image_data_delivery_enabled", value);
    }

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TextDataDeliveryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("text_data_delivery_enabled") ?? AsReference("text_data_delivery_enabled");
        set => SetArgument("text_data_delivery_enabled", value);
    }

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    public TerraformValue<bool> VideoDataDeliveryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("video_data_delivery_enabled") ?? AsReference("video_data_delivery_enabled");
        set => SetArgument("video_data_delivery_enabled", value);
    }

    /// <summary>
    /// CloudwatchConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlock>? CloudwatchConfig
    {
        get => GetArgument<TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlock>>("cloudwatch_config");
        set => SetArgument("cloudwatch_config", value);
    }

    /// <summary>
    /// S3Config block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockS3ConfigBlock>? S3Config
    {
        get => GetArgument<TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockS3ConfigBlock>>("s3_config");
        set => SetArgument("s3_config", value);
    }

}

/// <summary>
/// Block type for cloudwatch_config in AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_config";

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => GetArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// LargeDataDeliveryS3Config block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlockLargeDataDeliveryS3ConfigBlock>? LargeDataDeliveryS3Config
    {
        get => GetArgument<TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlockLargeDataDeliveryS3ConfigBlock>>("large_data_delivery_s3_config");
        set => SetArgument("large_data_delivery_s3_config", value);
    }

}

/// <summary>
/// Block type for large_data_delivery_s3_config in AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockCloudwatchConfigBlockLargeDataDeliveryS3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "large_data_delivery_s3_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("key_prefix");
        set => SetArgument("key_prefix", value);
    }

}

/// <summary>
/// Block type for s3_config in AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlockS3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("key_prefix");
        set => SetArgument("key_prefix", value);
    }

}


/// <summary>
/// Represents a aws_bedrock_model_invocation_logging_configuration Terraform resource.
/// Manages a aws_bedrock_model_invocation_logging_configuration resource.
/// </summary>
public partial class AwsBedrockModelInvocationLoggingConfiguration(string name) : TerraformResource("aws_bedrock_model_invocation_logging_configuration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}
