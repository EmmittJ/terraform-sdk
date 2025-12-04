using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_options in AwsFlowLog.
/// Nesting mode: list
/// </summary>
public class AwsFlowLogDestinationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_options";

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformValue<string>? FileFormat
    {
        get => GetArgument<TerraformValue<string>>("file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    public TerraformValue<bool>? HiveCompatiblePartitions
    {
        get => GetArgument<TerraformValue<bool>>("hive_compatible_partitions");
        set => SetArgument("hive_compatible_partitions", value);
    }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    public TerraformValue<bool>? PerHourPartition
    {
        get => GetArgument<TerraformValue<bool>>("per_hour_partition");
        set => SetArgument("per_hour_partition", value);
    }

}


/// <summary>
/// Represents a aws_flow_log Terraform resource.
/// Manages a aws_flow_log resource.
/// </summary>
public partial class AwsFlowLog(string name) : TerraformResource("aws_flow_log", name)
{
    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    public TerraformValue<string>? DeliverCrossAccountRole
    {
        get => GetArgument<TerraformValue<string>>("deliver_cross_account_role");
        set => SetArgument("deliver_cross_account_role", value);
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformValue<string>? EniId
    {
        get => GetArgument<TerraformValue<string>>("eni_id");
        set => SetArgument("eni_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformValue<string> LogDestination
    {
        get => GetArgument<TerraformValue<string>>("log_destination") ?? AsReference("log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string>? LogDestinationType
    {
        get => GetArgument<TerraformValue<string>>("log_destination_type");
        set => SetArgument("log_destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public TerraformValue<string> LogFormat
    {
        get => GetArgument<TerraformValue<string>>("log_format") ?? AsReference("log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public TerraformValue<double>? MaxAggregationInterval
    {
        get => GetArgument<TerraformValue<double>>("max_aggregation_interval");
        set => SetArgument("max_aggregation_interval", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    public TerraformValue<string>? TrafficType
    {
        get => GetArgument<TerraformValue<string>>("traffic_type");
        set => SetArgument("traffic_type", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DestinationOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    public TerraformList<AwsFlowLogDestinationOptionsBlock>? DestinationOptions
    {
        get => GetArgument<TerraformList<AwsFlowLogDestinationOptionsBlock>>("destination_options");
        set => SetArgument("destination_options", value);
    }

}
