using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in AwsIvschatLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIvschatLoggingConfigurationDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_configuration";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firehose block(s) allowed")]
    public TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsIvschatLoggingConfigurationDestinationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsIvschatLoggingConfigurationDestinationConfigurationBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

}

/// <summary>
/// Block type for firehose in AwsIvschatLoggingConfigurationDestinationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsIvschatLoggingConfigurationDestinationConfigurationBlockFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose";

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    public required TerraformValue<string> DeliveryStreamName
    {
        get => new TerraformReference<string>(this, "delivery_stream_name");
        set => SetArgument("delivery_stream_name", value);
    }

}

/// <summary>
/// Block type for s3 in AwsIvschatLoggingConfigurationDestinationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsIvschatLoggingConfigurationDestinationConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsIvschatLoggingConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsIvschatLoggingConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ivschat_logging_configuration Terraform resource.
/// Manages a aws_ivschat_logging_configuration resource.
/// </summary>
public partial class AwsIvschatLoggingConfiguration(string name) : TerraformResource("aws_ivschat_logging_configuration", name)
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
    public TerraformValue<string>? Name
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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// DestinationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfiguration block(s) allowed")]
    public TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlock>? DestinationConfiguration
    {
        get => GetArgument<TerraformList<AwsIvschatLoggingConfigurationDestinationConfigurationBlock>>("destination_configuration");
        set => SetArgument("destination_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsIvschatLoggingConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsIvschatLoggingConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
