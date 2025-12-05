using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_destination in AwsSesv2ConfigurationSetEventDestination.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_destination";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The matching_event_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingEventTypes is required")]
    public required TerraformSet<string> MatchingEventTypes
    {
        get => GetRequiredArgument<TerraformSet<string>>("matching_event_types");
        set => SetArgument("matching_event_types", value);
    }

    /// <summary>
    /// CloudWatchDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudWatchDestination block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlock>? CloudWatchDestination
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlock>>("cloud_watch_destination");
        set => SetArgument("cloud_watch_destination", value);
    }

    /// <summary>
    /// EventBridgeDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridgeDestination block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockEventBridgeDestinationBlock>? EventBridgeDestination
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockEventBridgeDestinationBlock>>("event_bridge_destination");
        set => SetArgument("event_bridge_destination", value);
    }

    /// <summary>
    /// KinesisFirehoseDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehoseDestination block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockKinesisFirehoseDestinationBlock>? KinesisFirehoseDestination
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockKinesisFirehoseDestinationBlock>>("kinesis_firehose_destination");
        set => SetArgument("kinesis_firehose_destination", value);
    }

    /// <summary>
    /// PinpointDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PinpointDestination block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockPinpointDestinationBlock>? PinpointDestination
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockPinpointDestinationBlock>>("pinpoint_destination");
        set => SetArgument("pinpoint_destination", value);
    }

    /// <summary>
    /// SnsDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnsDestination block(s) allowed")]
    public TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockSnsDestinationBlock>? SnsDestination
    {
        get => GetArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockSnsDestinationBlock>>("sns_destination");
        set => SetArgument("sns_destination", value);
    }

}

/// <summary>
/// Block type for cloud_watch_destination in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_watch_destination";

    /// <summary>
    /// DimensionConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DimensionConfiguration block(s) required")]
    public required TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlockDimensionConfigurationBlock> DimensionConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlockDimensionConfigurationBlock>>("dimension_configuration");
        set => SetArgument("dimension_configuration", value);
    }

}

/// <summary>
/// Block type for dimension_configuration in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockCloudWatchDestinationBlockDimensionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension_configuration";

    /// <summary>
    /// The default_dimension_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultDimensionValue is required")]
    public required TerraformValue<string> DefaultDimensionValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_dimension_value");
        set => SetArgument("default_dimension_value", value);
    }

    /// <summary>
    /// The dimension_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionName is required")]
    public required TerraformValue<string> DimensionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("dimension_name");
        set => SetArgument("dimension_name", value);
    }

    /// <summary>
    /// The dimension_value_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DimensionValueSource is required")]
    public required TerraformValue<string> DimensionValueSource
    {
        get => GetRequiredArgument<TerraformValue<string>>("dimension_value_source");
        set => SetArgument("dimension_value_source", value);
    }

}

/// <summary>
/// Block type for event_bridge_destination in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockEventBridgeDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_bridge_destination";

    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    public required TerraformValue<string> EventBusArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_bus_arn");
        set => SetArgument("event_bus_arn", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose_destination in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockKinesisFirehoseDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose_destination";

    /// <summary>
    /// The delivery_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamArn is required")]
    public required TerraformValue<string> DeliveryStreamArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("delivery_stream_arn");
        set => SetArgument("delivery_stream_arn", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

}

/// <summary>
/// Block type for pinpoint_destination in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockPinpointDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pinpoint_destination";

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformValue<string> ApplicationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_arn");
        set => SetArgument("application_arn", value);
    }

}

/// <summary>
/// Block type for sns_destination in AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlockSnsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns_destination";

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Represents a aws_sesv2_configuration_set_event_destination Terraform resource.
/// Manages a aws_sesv2_configuration_set_event_destination resource.
/// </summary>
public partial class AwsSesv2ConfigurationSetEventDestination(string name) : TerraformResource("aws_sesv2_configuration_set_event_destination", name)
{
    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformValue<string> ConfigurationSetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration_set_name");
        set => SetArgument("configuration_set_name", value);
    }

    /// <summary>
    /// The event_destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestinationName is required")]
    public required TerraformValue<string> EventDestinationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("event_destination_name");
        set => SetArgument("event_destination_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// EventDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventDestination block(s) allowed")]
    public required TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock> EventDestination
    {
        get => GetRequiredArgument<TerraformList<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock>>("event_destination");
        set => SetArgument("event_destination", value);
    }

}
