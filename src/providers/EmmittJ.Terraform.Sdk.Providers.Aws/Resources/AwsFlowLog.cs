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
        get => new TerraformReference<string>(this, "file_format");
        set => SetArgument("file_format", value);
    }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    public TerraformValue<bool>? HiveCompatiblePartitions
    {
        get => new TerraformReference<bool>(this, "hive_compatible_partitions");
        set => SetArgument("hive_compatible_partitions", value);
    }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    public TerraformValue<bool>? PerHourPartition
    {
        get => new TerraformReference<bool>(this, "per_hour_partition");
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
        get => new TerraformReference<string>(this, "deliver_cross_account_role");
        set => SetArgument("deliver_cross_account_role", value);
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformValue<string>? EniId
    {
        get => new TerraformReference<string>(this, "eni_id");
        set => SetArgument("eni_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// The log_destination attribute.
    /// </summary>
    public TerraformValue<string> LogDestination
    {
        get => new TerraformReference<string>(this, "log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformValue<string>? LogDestinationType
    {
        get => new TerraformReference<string>(this, "log_destination_type");
        set => SetArgument("log_destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public TerraformValue<string> LogFormat
    {
        get => new TerraformReference<string>(this, "log_format");
        set => SetArgument("log_format", value);
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public TerraformValue<double>? MaxAggregationInterval
    {
        get => new TerraformReference<double>(this, "max_aggregation_interval");
        set => SetArgument("max_aggregation_interval", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    /// The traffic_type attribute.
    /// </summary>
    public TerraformValue<string>? TrafficType
    {
        get => new TerraformReference<string>(this, "traffic_type");
        set => SetArgument("traffic_type", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
