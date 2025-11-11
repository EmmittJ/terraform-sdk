using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_options in .
/// Nesting mode: list
/// </summary>
public class AwsFlowLogDestinationOptionsBlock
{
    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformPropertyName("file_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FileFormat { get; set; }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    [TerraformPropertyName("hive_compatible_partitions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HiveCompatiblePartitions { get; set; }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    [TerraformPropertyName("per_hour_partition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PerHourPartition { get; set; }

}

/// <summary>
/// Manages a aws_flow_log resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFlowLog : TerraformResource
{
    public AwsFlowLog(string name) : base("aws_flow_log", name)
    {
    }

    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    [TerraformPropertyName("deliver_cross_account_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeliverCrossAccountRole { get; set; }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    [TerraformPropertyName("eni_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EniId { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformPropertyName("log_destination")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogDestination { get; set; } = default!;

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("log_destination_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogDestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [TerraformPropertyName("log_format")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogFormat { get; set; } = default!;

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    [TerraformPropertyName("max_aggregation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAggregationInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrafficType { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcId { get; set; }

    /// <summary>
    /// Block for destination_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    [TerraformPropertyName("destination_options")]
    public TerraformList<TerraformBlock<AwsFlowLogDestinationOptionsBlock>>? DestinationOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
