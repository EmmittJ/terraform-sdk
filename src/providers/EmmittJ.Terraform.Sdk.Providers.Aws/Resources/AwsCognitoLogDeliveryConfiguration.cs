using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_configurations in AwsCognitoLogDeliveryConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configurations";

    /// <summary>
    /// The event_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSource is required")]
    public required TerraformValue<string> EventSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_source");
        set => SetArgument("event_source", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogLevel is required")]
    public required TerraformValue<string> LogLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// CloudWatchLogsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockCloudWatchLogsConfigurationBlock>? CloudWatchLogsConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockCloudWatchLogsConfigurationBlock>>("cloud_watch_logs_configuration");
        set => SetArgument("cloud_watch_logs_configuration", value);
    }

    /// <summary>
    /// FirehoseConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockFirehoseConfigurationBlock>? FirehoseConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockFirehoseConfigurationBlock>>("firehose_configuration");
        set => SetArgument("firehose_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for cloud_watch_logs_configuration in AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockCloudWatchLogsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_watch_logs_configuration";

    /// <summary>
    /// The log_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupArn
    {
        get => GetArgument<TerraformValue<string>>("log_group_arn");
        set => SetArgument("log_group_arn", value);
    }

}

/// <summary>
/// Block type for firehose_configuration in AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockFirehoseConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose_configuration";

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformValue<string>? StreamArn
    {
        get => GetArgument<TerraformValue<string>>("stream_arn");
        set => SetArgument("stream_arn", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    public TerraformValue<string>? BucketArn
    {
        get => GetArgument<TerraformValue<string>>("bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

}


/// <summary>
/// Represents a aws_cognito_log_delivery_configuration Terraform resource.
/// Manages a aws_cognito_log_delivery_configuration resource.
/// </summary>
public partial class AwsCognitoLogDeliveryConfiguration(string name) : TerraformResource("aws_cognito_log_delivery_configuration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// LogConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock>? LogConfigurations
    {
        get => GetArgument<TerraformList<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock>>("log_configurations");
        set => SetArgument("log_configurations", value);
    }

}
