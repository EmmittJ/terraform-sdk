using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsFlowLogDestinationOptionsBlock() : TerraformBlock("destination_options")
{
    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformProperty("file_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileFormat { get; set; }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    [TerraformProperty("hive_compatible_partitions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HiveCompatiblePartitions { get; set; }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    [TerraformProperty("per_hour_partition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PerHourPartition { get; set; }

}

/// <summary>
/// Manages a aws_flow_log resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFlowLog : TerraformResource
{
    public AwsFlowLog(string name) : base("aws_flow_log", name)
    {
    }

    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    [TerraformProperty("deliver_cross_account_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliverCrossAccountRole { get; set; }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    [TerraformProperty("eni_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EniId { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformProperty("log_destination")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogDestination { get; set; }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformProperty("log_destination_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogDestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [TerraformProperty("log_format")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogFormat { get; set; }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    [TerraformProperty("max_aggregation_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxAggregationInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    [TerraformProperty("traffic_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrafficType { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_attachment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformProperty("transit_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcId { get; set; }

    /// <summary>
    /// Block for destination_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    [TerraformProperty("destination_options")]
    public TerraformList<AwsFlowLogDestinationOptionsBlock> DestinationOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
