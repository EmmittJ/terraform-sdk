using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in AwsVerifiedaccessInstanceLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_logs";

    /// <summary>
    /// The include_trust_context attribute.
    /// </summary>
    public TerraformValue<bool> IncludeTrustContext
    {
        get => GetArgument<TerraformValue<bool>>("include_trust_context") ?? AsReference("include_trust_context");
        set => SetArgument("include_trust_context", value);
    }

    /// <summary>
    /// The log_version attribute.
    /// </summary>
    public TerraformValue<string> LogVersion
    {
        get => GetArgument<TerraformValue<string>>("log_version") ?? AsReference("log_version");
        set => SetArgument("log_version", value);
    }

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// KinesisDataFirehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisDataFirehose block(s) allowed")]
    public TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockKinesisDataFirehoseBlock>? KinesisDataFirehose
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockKinesisDataFirehoseBlock>>("kinesis_data_firehose");
        set => SetArgument("kinesis_data_firehose", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformValue<string>? LogGroup
    {
        get => GetArgument<TerraformValue<string>>("log_group");
        set => SetArgument("log_group", value);
    }

}

/// <summary>
/// Block type for kinesis_data_firehose in AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockKinesisDataFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_data_firehose";

    /// <summary>
    /// The delivery_stream attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryStream
    {
        get => GetArgument<TerraformValue<string>>("delivery_stream");
        set => SetArgument("delivery_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for s3 in AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_owner attribute.
    /// </summary>
    public TerraformValue<string> BucketOwner
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner") ?? AsReference("bucket_owner");
        set => SetArgument("bucket_owner", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Represents a aws_verifiedaccess_instance_logging_configuration Terraform resource.
/// Manages a aws_verifiedaccess_instance_logging_configuration resource.
/// </summary>
public partial class AwsVerifiedaccessInstanceLoggingConfiguration(string name) : TerraformResource("aws_verifiedaccess_instance_logging_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformValue<string> VerifiedaccessInstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("verifiedaccess_instance_id");
        set => SetArgument("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// AccessLogs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public required TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock> AccessLogs
    {
        get => GetRequiredArgument<TerraformList<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>>("access_logs");
        set => SetArgument("access_logs", value);
    }

}
